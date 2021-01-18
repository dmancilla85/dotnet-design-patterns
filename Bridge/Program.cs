using GangOfFour.Bridge.RealWorld;
using GangOfFour.Bridge.Structural;
using System;

namespace GangOfFour.Bridge
{
	/// <summary>
	/// Decouple an abstraction from its implementation so that the two can vary independently.
	/// </summary>
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

			/* This real-world code demonstrates the Bridge pattern in which a BusinessObject abstraction 
			 * is decoupled from the implementation in DataObject. The DataObject implementations can 
			 * evolve dynamically without changing any clients. */

			// Create RefinedAbstraction
			Customers customers = new Customers("Chicago")
			{

				// Set ConcreteImplementor
				Data = new CustomersData()
			};

			// Exercise the bridge
			customers.Show();
			customers.Next();
			customers.Show();
			customers.Next();
			customers.Show();
			customers.Add("Henry Velasquez");

			customers.ShowAll();

		}
	}
}
