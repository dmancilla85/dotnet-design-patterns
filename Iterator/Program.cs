using GangOfFour.Iterator.RealWorld;
using GangOfFour.Iterator.Structural;
using System;

namespace GangOfFour.Iterator
{
	/// <summary>
	/// Provide a way to access the elements of an aggregate object sequentially
	/// without exposing its underlying representation.
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

			/* This real-world code demonstrates the Iterator pattern which is used to iterate over a
			 * collection of items and skip a specific number of items each iteration. */
			// Build a collection

			Collection collection = new Collection();
			collection[0] = new Item("Item 0");
			collection[1] = new Item("Item 1");
			collection[2] = new Item("Item 2");
			collection[3] = new Item("Item 3");
			collection[4] = new Item("Item 4");
			collection[5] = new Item("Item 5");
			collection[6] = new Item("Item 6");
			collection[7] = new Item("Item 7");
			collection[8] = new Item("Item 8");

			// Create iterator
			RealWorld.Iterator iterator = collection.CreateIterator();

			// Skip every other item
			iterator.Step = 2;

			Console.WriteLine("Iterating over collection:");

			for (Item item = iterator.First();
					!iterator.IsDone; item = iterator.Next())
			{
				Console.WriteLine(item.Name);
			}
		}
	}
}