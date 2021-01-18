using GangOfFour.Memento.RealWorld;
using GangOfFour.Memento.Structural;
using System;

namespace GangOfFour.Memento
{
	/// <summary>
	/// Without violating encapsulation, capture and externalize an object's
	/// internal state so that the object can be restored to this state later.
	/// </summary>
	internal static class Program
	{
		internal static void Main()
		{
			Console.WriteLine("** Structural example **");
			MainApp.OtherMain();

			Console.WriteLine();
			Console.WriteLine();

			Console.WriteLine("** Real World example **");
			Console.WriteLine();

			/* This real-world code demonstrates the Memento pattern which temporarily saves and then
			 * restores the SalesProspect's internal state.*/

			SalesProspect s = new SalesProspect
			{
				Name = "Noel van Halen",
				Phone = "(412) 256-0990",
				Budget = 25000.0
			};

			// Store internal state

			ProspectMemory m = new ProspectMemory
			{
				Memento = s.SaveMemento()
			};

			// Continue changing originator

			s.Name = "Leo Welch";
			s.Phone = "(310) 209-7111";
			s.Budget = 1000000.0;

			// Restore saved state

			s.RestoreMemento(m.Memento);
		}
	}
}