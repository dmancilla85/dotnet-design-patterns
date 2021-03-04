namespace GangOfFour.Iterator.RealWorld
{
	/// <summary>
	/// A collection item
	/// </summary>
	internal class Item

	{
		private readonly string _name;

		// Constructor
		public Item(string name)
		{
			this._name = name;
		}

		// Gets name
		public string Name
		{
			get { return _name; }
		}
	}
}