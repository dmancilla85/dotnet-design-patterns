namespace GangOfFour.Facade.RealWorld
{
	/// <summary>
	/// Customer class
	/// </summary>
	internal class Customer

	{
		private string _name;

		// Constructor

		public Customer(string name)
		{
			this._name = name;
		}

		// Gets the name

		public string Name
		{
			get { return _name; }
		}
	}
}