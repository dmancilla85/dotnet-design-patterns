using GangOfFour.Observer.RealWorld;
using GangOfFour.Observer.Structural;
using System;

namespace GangOfFour.Observer
{
	public static class Program
	{
		/// <summary>
		/// Define a one-to-many dependency between objects so that when one object
		/// changes state, all its dependents are notified and updated automatically.
		/// </summary>
		public static void Main()
		{
			Console.WriteLine("** Structural example **");
			MainApp.OtherMain();

			Console.WriteLine();
			Console.WriteLine();

			Console.WriteLine("** Real World example **");
			Console.WriteLine();

			/* This real-world code demonstrates the Observer pattern in which registered investors are 
			 * notified every time a stock changes value. */

			// Create IBM stock and attach investors
			IBM ibm = new IBM("IBM", 120.00);
			ibm.Attach(new Investor("Sorros"));
			ibm.Attach(new Investor("Berkshire"));

			// Fluctuating prices will notify investors

			ibm.Price = 120.10;
			ibm.Price = 121.00;
			ibm.Price = 120.50;
			ibm.Price = 120.75;

			// Wait for user
			Console.ReadKey();
		}
	}
}