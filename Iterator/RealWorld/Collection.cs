using System.Collections;

namespace GangOfFour.Iterator.RealWorld
{
	/// <summary>
	/// The 'ConcreteAggregate' class
	/// </summary>
	internal class Collection : IAbstractCollection

	{
		private ArrayList _items = new ArrayList();

		// Gets item count
		public int Count
		{
			get { return _items.Count; }
		}

		// Indexer
		public object this[int index]
		{
			get { return _items[index]; }
			set { _items.Add(value); }
		}

		public Iterator CreateIterator()
		{
			return new Iterator(this);
		}
	}
}