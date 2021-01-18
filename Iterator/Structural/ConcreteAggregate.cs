using System.Collections;

namespace GangOfFour.Iterator.Structural
{
	/// <summary>
	/// The 'ConcreteAggregate' class
	/// </summary>
	internal class ConcreteAggregate : Aggregate

  {
    private readonly ArrayList _items = new ArrayList();

    public override Iterator CreateIterator()
    {
      return new ConcreteIterator(this);
    }

    // Gets item count
    public int Count
    {
      get { return _items.Count; }
    }

    // Indexer
    public object this[int index]
    {
      get { return _items[index]; }
      set { _items.Insert(index, value); }
    }
  }
}
