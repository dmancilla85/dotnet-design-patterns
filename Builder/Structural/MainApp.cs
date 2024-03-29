﻿namespace GangOfFour.Builder.Structural
{
	/// <summary>
	/// MainApp startup class for Structural Builder Design Pattern.
	/// </summary>
	public static class MainApp

	{
		/// <summary>
		/// Entry point into console application.
		/// </summary>
		public static void OtherMain()
		{
			// Create director and builders
			Director director = new Director();

			Builder b1 = new ConcreteBuilder1();
			Builder b2 = new ConcreteBuilder2();

			// Construct two products
			director.Construct(b1);
			Product p1 = b1.GetResult();
			p1.Show();

			director.Construct(b2);
			Product p2 = b2.GetResult();
			p2.Show();
		}
	}
}