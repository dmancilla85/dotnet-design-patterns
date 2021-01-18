using System;
using System.Collections.Generic;
using System.Text;

namespace GangOfFour.State.Structural
{
	/// <summary>
	/// MainApp startup class for Structural
	/// State Design Pattern.
	/// </summary>
	internal static class MainApp

  {
    /// <summary>
    /// Entry point into console application.
    /// </summary>
    internal static void OtherMain()
    {
      // Setup context in a state
      Context c = new Context(new ConcreteStateA());

      // Issue requests, which toggles state
      c.Request();
      c.Request();
      c.Request();
      c.Request();
    }
  }
}
