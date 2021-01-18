namespace GangOfFour.Observer.RealWorld
{
	/// <summary>
	/// The 'ConcreteSubject' class
	/// </summary>
	internal class IBM : Stock

	{
		// Constructor
		public IBM(string symbol, double price)
			: base(symbol, price)
		{
		}
	}
}