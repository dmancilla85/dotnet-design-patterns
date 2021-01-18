using System.Collections;

namespace GangOfFour.Flyweight.Structural
{
	/// <summary>
	/// The 'FlyweightFactory' class
	/// </summary>
	internal class FlyweightFactory

  {
    private readonly Hashtable flyweights = new Hashtable();

    // Constructor
    public FlyweightFactory()
    {
      flyweights.Add("X", new ConcreteFlyweight());
      flyweights.Add("Y", new ConcreteFlyweight());
      flyweights.Add("Z", new ConcreteFlyweight());
    }

    public Flyweight GetFlyweight(string key)
    {
      return (Flyweight)flyweights[key];
    }
  }
}
