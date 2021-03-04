using GangOfFour.Visitor.RealWorld;
using GangOfFour.Visitor.Structural;
using System;

namespace GangOfFour.Visitor
{
	/// <summary>
	/// Represent an operation to be performed on the elements of an object
	/// structure. Visitor lets you define a new operation without changing the
	/// classes of the elements on which it operates.
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

			/* This real-world code demonstrates the Visitor pattern in which two objects traverse a list
			 * of Employees and performs the same operation on each Employee. The two visitor objects
			 * define different operations -- one adjusts vacation days and the other income. */

			// Setup employee collection
			Employees e = new Employees();
			e.Attach(new Clerk());
			e.Attach(new Director());
			e.Attach(new President());

			// Employees are 'visited'
			e.Accept(new IncomeVisitor());
			e.Accept(new VacationVisitor());
		}
	}
}