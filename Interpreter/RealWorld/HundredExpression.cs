﻿namespace GangOfFour.Interpreter.RealWorld
{
	/// <summary>
	/// A 'TerminalExpression' class <remarks> Hundred checks C, CD, D or CM </remarks>
	/// </summary>
	internal class HundredExpression : Expression

	{
		public override string Five()
		{
			return "D";
		}

		public override string Four()
		{
			return "CD";
		}

		public override int Multiplier()
		{
			return 100;
		}

		public override string Nine()
		{
			return "CM";
		}

		public override string One()
		{
			return "C";
		}
	}
}