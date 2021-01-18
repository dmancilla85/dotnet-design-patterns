using System;

namespace GangOfFour.Bridge.Structural
{
	/// <summary>
	/// The 'ConcreteImplementorB' class
	/// </summary>
	internal class ConcreteImplementorB : Implementor

{
  public override void Operation()
  {
    Console.WriteLine("ConcreteImplementorB Operation");
  }
}
}
