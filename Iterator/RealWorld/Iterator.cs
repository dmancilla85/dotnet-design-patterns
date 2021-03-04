namespace GangOfFour.Iterator.RealWorld
{
	/// <summary>
	/// The 'ConcreteIterator' class
	/// </summary>
	internal class Iterator : IAbstractIterator

	{
		private readonly Collection _collection;
		private int _current = 0;

		// Constructor
		public Iterator(Collection collection)
		{
			this._collection = collection;
		}

		// Gets current iterator item
		public Item CurrentItem
		{
			get { return _collection[_current] as Item; }
		}

		// Gets whether iteration is complete
		public bool IsDone
		{
			get { return _current >= _collection.Count; }
		}

		// Gets or sets stepsize
		public int Step { get; set; } = 1;

		// Gets first item
		public Item First()
		{
			_current = 0;
			return _collection[_current] as Item;
		}

		// Gets next item
		public Item Next()
		{
			_current += Step;
			if (!IsDone)
				return _collection[_current] as Item;
			else

				return null;
		}
	}
}