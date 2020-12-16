namespace GangOfFour.Decorator.Structural
{
	/// <summary>
	/// MainApp startup class for Structural Decorator Design Pattern.
	/// </summary>
	internal static class MainApp

	{
		/// <summary>
		/// Entry point into console application.
		/// </summary>
		internal static void OtherMain()
		{
			// Create ConcreteComponent and two Decorators

			ConcreteComponent c = new ConcreteComponent();
			ConcreteDecoratorA d1 = new ConcreteDecoratorA();
			ConcreteDecoratorB d2 = new ConcreteDecoratorB();

			// Link decorators

			d1.SetComponent(c);
			d2.SetComponent(d1);

			d2.Operation();
		}
	}
}