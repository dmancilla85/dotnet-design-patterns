using System;

namespace GangOfFour.FactoryMethod.Structural
{
	/// <summary>
	/// MainApp startup class for Structural Factory Method Design Pattern.
	/// </summary>
	internal static class MainApp

	{
		/// <summary>
		/// Entry point into console application.
		/// </summary>
		internal static void OtherMain()
		{
			// An array of creators

			Creator[] creators = new Creator[2];

			creators[0] = new ConcreteCreatorA();
			creators[1] = new ConcreteCreatorB();

			// Iterate over creators and create products

			foreach (Creator creator in creators)
			{
				Product product = creator.FactoryMethod();
				Console.WriteLine("Created {0}",
					product.GetType().Name);
			}
		}
	}
}