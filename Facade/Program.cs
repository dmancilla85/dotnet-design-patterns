using GangOfFour.Facade.RealWorld;
using GangOfFour.Facade.Structural;
using System;

namespace GangOfFour.Facade
{
	internal static class Program
	{
		private static void Main()
		{
			Console.WriteLine("** Structural example **");
			MainApp.OtherMain();

			Console.WriteLine();
			Console.WriteLine();

			Console.WriteLine("** Real World example **");
			Console.WriteLine();

			// Facade
			Mortgage mortgage = new Mortgage();

			// Evaluate mortgage eligibility for customer

			Customer customer = new Customer("Ann McKinsey");
			bool eligible = mortgage.IsEligible(customer, 125000);

			Console.WriteLine("\n" + customer.Name +
					" has been " + (eligible ? "Approved" : "Rejected"));
		}
	}
}