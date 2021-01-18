using System.Collections.Generic;
using System.Text;

namespace GangOfFour.Prototype.RealWorld
{

	/// <summary>
	/// Prototype manager
	/// </summary>
	internal class ColorManager

  {
    private readonly Dictionary<string, ColorPrototype> _colors =
      new Dictionary<string, ColorPrototype>();

    // Indexer
    public ColorPrototype this[string key]
    {
      get { return _colors[key]; }
      set { _colors.Add(key, value); }
    }
  }
}
