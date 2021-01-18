using GangOfFour.Interpreter.Structural;
using GangOfFour.Interpreter.RealWorld;
using System;
using System.Collections.Generic;

namespace GangOfFour.Interpreter
{
	/// <summary>
	///  Given a language, define a representation for its grammar along with an interpreter that 
	///  uses the representation to interpret sentences in the language.
	/// </summary>
	internal static class Program
	{
		private static void Main()
		{
			Console.WriteLine("** Structural example **");
			MainApp.OtherMain();

			Console.WriteLine();
			Console.WriteLine();

			Console.WriteLine("** Real World example **");
			Console.WriteLine();

			/* This real-world code demonstrates the Interpreter pattern which is used to convert a 
			 * Roman numeral to a decimal. */

			const string roman = "MCMXXVIII";
			RealWorld.Context context = new RealWorld.Context(roman);

			// Build the 'parse tree'
			List<Expression> tree = new List<Expression>
			{
				new ThousandExpression(),
				new HundredExpression(),
				new TenExpression(),
				new OneExpression()
			};

			// Interpret
			foreach (Expression exp in tree)
			{
				exp.Interpret(context);
			}

			Console.WriteLine("{0} = {1}",
				roman, context.Output);
		}
	}
}
