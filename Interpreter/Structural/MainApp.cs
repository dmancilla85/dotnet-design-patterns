using System.Collections;

namespace GangOfFour.Interpreter.Structural
{
	/// <summary>
	/// MainApp startup class for Structural Interpreter Design Pattern.
	/// </summary>
	internal static class MainApp

	{
		/// <summary>
		/// Entry point into console application.
		/// </summary>
		internal static void OtherMain()
		{
			Context context = new Context();

			// Usually a tree
			ArrayList list = new ArrayList
			{
				// Populate 'abstract syntax tree'
				new TerminalExpression(),
				new NonterminalExpression(),
				new TerminalExpression(),
				new TerminalExpression()
			};

			// Interpret
			foreach (AbstractExpression exp in list)
			{
				exp.Interpret(context);
			}
		}
	}
}