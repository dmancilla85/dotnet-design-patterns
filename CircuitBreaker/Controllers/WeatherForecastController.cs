using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace CircuitBreaker.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class WeatherForecastController : ControllerBase
	{
		private readonly ILogger<WeatherForecastController> _logger;
		private readonly ICircuitBreaker _breaker;

		public WeatherForecastController(ILogger<WeatherForecastController> logger,
			ICircuitBreaker circuitBreaker)
		{
			_logger = logger;
			_breaker = circuitBreaker;
			//circuitBreaker = new CircuitBreaker(2, TimeSpan.FromSeconds(60));
		}

		[HttpGet]
		public async Task<string> GetAsync()
		{
			HttpResponseMessage resolutionOk=null;

			string msg = (await _breaker.AttemptCallAsync(async () =>
		 {
			 var client = new HttpClient();
			 var request = new HttpRequestMessage
			 {
				 Method = HttpMethod.Get,
				 RequestUri = new Uri("https://community-open-weather-map.p.rapidapi.com/weather?q=London%2Cuk&lat=0&lon=0&callback=test&id=2172797&lang=null&units=%22metric%22%20or%20%22imperial%22&mode=xml%2C%20html"),
				 Headers ={{ "x-rapidapi-key", "00df19e8f3mshcb901739332dd84p177e56jsncaa987e6a2aa" },
				{ "x-rapidapi-host", "community-open-weather-map.p.rapidapi.com" },},
			 };

			 Random rr = new Random();

			 if (rr.Next() % 2 == 0)
			 {
				 _logger.LogError("hay problemas...");
				 throw new BrokenCircuitException("rompe algo");
			 }

			 HttpResponseMessage response = await client.SendAsync(request).ConfigureAwait(false);
			 response.EnsureSuccessStatusCode();
			 resolutionOk = response;
		 })).IsClosed?"OK":"Oh no!";

			_logger.LogInformation($"Status: {msg}");

			if (resolutionOk == null)
			{
				return "Failure calling API";
			}

			return await resolutionOk.Content.ReadAsStringAsync().ConfigureAwait(false);
		}
	}
}