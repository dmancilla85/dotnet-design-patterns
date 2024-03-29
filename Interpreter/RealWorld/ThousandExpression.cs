﻿namespace GangOfFour.Interpreter.RealWorld
{
	/// <summary>
	/// A 'TerminalExpression' class <remarks> Thousand checks for the Roman
	/// Numeral M </remarks>
	/// </summary>
	internal class ThousandExpression : Expression

	{
		public override string Five()
		{
			return " ";
		}

		public override string Four()
		{
			return " ";
		}

		public override int Multiplier()
		{
			return 1000;
		}

		public override string Nine()
		{
			return " ";
		}

		public override string One()
		{
			return "M";
		}
	}
}