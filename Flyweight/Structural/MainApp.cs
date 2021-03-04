namespace GangOfFour.Flyweight.Structural
{
	/// <summary>
	/// MainApp startup class for Structural Flyweight Design Pattern.
	/// </summary>
	internal static class MainApp

	{
		/// <summary>
		/// Entry point into console application.
		/// </summary>
		internal static void OtherMain()
		{
			// Arbitrary extrinsic state
			int extrinsicstate = 22;

			FlyweightFactory factory = new FlyweightFactory();

			// Work with different flyweight instances
			Flyweight fx = factory.GetFlyweight("X");
			fx.Operation(--extrinsicstate);

			Flyweight fy = factory.GetFlyweight("Y");
			fy.Operation(--extrinsicstate);

			Flyweight fz = factory.GetFlyweight("Z");
			fz.Operation(--extrinsicstate);

			UnsharedConcreteFlyweight fu = new

				UnsharedConcreteFlyweight();

			fu.Operation(--extrinsicstate);
		}
	}
}