namespace GangOfFour.Strategy.Structural
{
	/// <summary>
	/// The 'Context' class
	/// </summary>
	internal class Context

	{
		private readonly Strategy _strategy;

		// Constructor
		public Context(Strategy strategy)
		{
			this._strategy = strategy;
		}

		public void ContextInterface()
		{
			_strategy.AlgorithmInterface();
		}
	}
}