using GangOfFour.Composite.RealWorld;
using GangOfFour.Composite.Structural;
using System;

namespace GangOfFour.Composite
{
	/// <summary>
	/// Compose objects into tree structures to represent part-whole hierarchies. 
	/// Composite lets clients treat individual objects and compositions of objects uniformly.
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

			/* This real-world code demonstrates the Composite pattern used in building a graphical tree 
			 * structure made up of primitive nodes (lines, circles, etc) and composite nodes (groups of 
			 * drawing elements that make up more complex elements).*/

			// Create a tree structure 
			CompositeElement root =
				new CompositeElement("Picture");
			root.Add(new PrimitiveElement("Red Line"));
			root.Add(new PrimitiveElement("Blue Circle"));
			root.Add(new PrimitiveElement("Green Box"));

			// Create a branch
			CompositeElement comp =
				new CompositeElement("Two Circles");
			comp.Add(new PrimitiveElement("Black Circle"));
			comp.Add(new PrimitiveElement("White Circle"));
			root.Add(comp);

			// Add and remove a PrimitiveElement
			PrimitiveElement pe =
				new PrimitiveElement("Yellow Line");
			root.Add(pe);
			root.Remove(pe);

			// Recursively display nodes
			root.Display(1);
		}
	}
}