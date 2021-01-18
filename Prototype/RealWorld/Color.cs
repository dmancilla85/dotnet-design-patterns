using System;

namespace GangOfFour.Prototype.RealWorld
{
	/// <summary>
	/// The 'ConcretePrototype' class
	/// </summary>
	internal class Color : ColorPrototype

  {
    private readonly int _red;
    private readonly int _green;
    private readonly int _blue;

    // Constructor
    public Color(int red, int green, int blue)
    {
      this._red = red;
      this._green = green;
      this._blue = blue;
    }

    // Create a shallow copy
    public override ColorPrototype Clone()
    {
      Console.WriteLine(
        "Cloning color RGB: {0,3},{1,3},{2,3}",
        _red, _green, _blue);

      return this.MemberwiseClone() as ColorPrototype;
    }
  }
}
