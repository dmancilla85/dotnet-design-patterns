using GangOfFour.FactoryMethod.RealWorld;
using GangOfFour.FactoryMethod.Structural;
using System;

namespace GangOfFour.FactoryMethod
{
	/// <summary>
	/// Define an interface for creating an object, but let subclasses decide which class to 
	/// instantiate. Factory Method lets a class defer instantiation to subclasses.
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

			/* This real-world code demonstrates the Factory method offering flexibility in creating
			 * different documents. The derived Document classes Report and Resume instantiate extended
			 * versions of the Document class. Here, the Factory Method is called in the constructor of
			 * the Document base class.*/

			// Note: constructors call Factory Method

			Document[] documents = new Document[2];

			documents[0] = new Resume();
			documents[1] = new Report();

			// Display document pages

			foreach (Document document in documents)
			{
				Console.WriteLine("\n" + document.GetType().Name + "--");
				foreach (Page page in document.Pages)
				{
					Console.WriteLine(" " + page.GetType().Name);
				}
			}
		}
	}
}