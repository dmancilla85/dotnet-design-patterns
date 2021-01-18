using System;

namespace GangOfFour.Interpreter.Structural
{
	/// <summary>
	/// The 'NonterminalExpression' class
	/// </summary>
	internal class NonterminalExpression : AbstractExpression

  {
    public override void Interpret(Context context)
    {
      Console.WriteLine("Called Nonterminal.Interpret()");
    }
  }
}
