﻿using System;

namespace GangOfFour.Iterator.Structural
{
	/// <summary>
	/// MainApp startup class for Structural Iterator Design Pattern.
	/// </summary>
	internal static class MainApp

	{
		/// <summary>
		/// Entry point into console application.
		/// </summary>
		internal static void OtherMain()
		{
			ConcreteAggregate a = new ConcreteAggregate();
			a[0] = "Item A";
			a[1] = "Item B";
			a[2] = "Item C";
			a[3] = "Item D";

			// Create Iterator and provide aggregate
			Iterator i = a.CreateIterator();

			Console.WriteLine("Iterating over collection:");

			object item = i.First();
			while (item != null)
			{
				Console.WriteLine(item);
				item = i.Next();
			}
		}
	}
}