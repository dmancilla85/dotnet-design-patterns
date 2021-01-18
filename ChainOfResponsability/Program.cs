using GangOfFour.Chain.RealWorld;
using GangOfFour.Chain.Structural;
using System;

namespace GangOfFour.Chain
{
	public static class Program
	{
		/// <summary>
		/// Avoid coupling the sender of a request to its receiver by giving more
		/// than one object a chance to handle the request. Chain the receiving
		/// objects and pass the request along the chain until an object handles it.
		/// </summary>
		private static void Main()
		{
			Console.WriteLine("** Structural example **");
			MainApp.OtherMain();

			Console.WriteLine();
			Console.WriteLine();

			Console.WriteLine("** Real World example **");
			Console.WriteLine();

			/* This real-world code demonstrates the Chain of Responsibility pattern in which several linked
			 * managers and executives can respond to a purchase request or hand it off to a superior. Each
			 * position has can have its own set of rules which orders they can approve.*/

			// Setup Chain of Responsibility
			Approver larry = new Director();
			Approver sam = new VicePresident();
			Approver tammy = new President();

			larry.SetSuccessor(sam);
			sam.SetSuccessor(tammy);

			// Generate and process purchase requests
			Purchase p = new Purchase(2034, 350.00, "Assets");
			larry.ProcessRequest(p);

			p = new Purchase(2035, 32590.10, "Project X");
			larry.ProcessRequest(p);

			p = new Purchase(2036, 122100.00, "Project Y");
			larry.ProcessRequest(p);
		}
	}
}