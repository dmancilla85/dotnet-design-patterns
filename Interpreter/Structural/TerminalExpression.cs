using System;

namespace GangOfFour.Interpreter.Structural
{
	/// <summary>
	/// The 'TerminalExpression' class
	/// </summary>
	internal class TerminalExpression : AbstractExpression
  {
    public override void Interpret(Context context)
    {
      Console.WriteLine("Called Terminal.Interpret()");
    }
  }
}
