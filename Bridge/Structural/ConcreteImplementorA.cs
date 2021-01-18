using System;

namespace GangOfFour.Bridge.Structural
{
	/// <summary>
	/// The 'ConcreteImplementorA' class
	/// </summary>
	internal class ConcreteImplementorA : Implementor

{
  public override void Operation()
  {
    Console.WriteLine("ConcreteImplementorA Operation");
  }
}
}
