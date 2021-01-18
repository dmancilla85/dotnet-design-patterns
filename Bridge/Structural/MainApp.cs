using System;
using System.Collections.Generic;
using System.Text;

namespace GangOfFour.Bridge.Structural
{
	internal static class MainApp {
  /// <summary>
  /// Entry point into console application.
  /// </summary>
  internal static void OtherMain()
  {
			Abstraction ab = new RefinedAbstraction
			{

				// Set implementation and call
				Implementor = new ConcreteImplementorA()
			};
			ab.Operation();

    // Change implemention and call
    ab.Implementor = new ConcreteImplementorB();
    ab.Operation();
  }
}
}
