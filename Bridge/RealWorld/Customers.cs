using System;
using System.Text;

namespace GangOfFour.Bridge.RealWorld
{

	/// <summary>
	/// The 'RefinedAbstraction' class
	/// </summary>
	internal class Customers : CustomersBase

  {
    // Constructor
    public Customers(string group)
      : base(group)
    {
    }

    public override void ShowAll()
    {
      // Add separator lines
      Console.WriteLine();
      Console.WriteLine("------------------------");
      base.ShowAll();
      Console.WriteLine("------------------------");
    }
  }
}
