using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace CircuitBreaker
{
	public interface ICircuitBreaker
	{
		event Action<object, CircuitBreakerState> OnStateChange;

		int Failures { get; }
		bool IsClosed { get; }
		bool IsHalfOpen { get; }
		bool IsOpen { get; }
		int Threshold { get; }
		TimeSpan Timeout { get; }

		/// <summary>
		/// This should be used as followed :
		/// myCircuitBreaker.AttemptCall(()=&gt;{yourCode();}).IsClosed?"AllFine":"Something wrong";
		/// </summary>
		/// <param name="protectedCode"></param>
		/// <returns></returns>
		Task<CircuitBreaker> AttemptCallAsync(Func<Task> protectedCode);
		CircuitBreaker AttemptCall(Func<Task> protectedCode);

		void Close();

		Exception GetExceptionFromLastAttemptCall();

		bool IsThresholdReached();

		void Open();
	}
}