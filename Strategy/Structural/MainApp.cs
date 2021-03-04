namespace GangOfFour.Strategy.Structural
{
	/// <summary>
	/// MainApp startup class for Structural Strategy Design Pattern.
	/// </summary>
	internal static class MainApp

	{
		/// <summary>
		/// Entry point into console application.
		/// </summary>
		internal static void OtherMain()
		{
			// Three contexts following different strategies
			Context context = new Context(new ConcreteStrategyA());
			context.ContextInterface();

			context = new Context(new ConcreteStrategyB());
			context.ContextInterface();

			context = new Context(new ConcreteStrategyC());
			context.ContextInterface();
		}
	}
}