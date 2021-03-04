namespace GangOfFour.Interpreter.RealWorld
{
	/// <summary>
	/// A 'TerminalExpression' class <remarks> Ten checks for X, XL, L and XC </remarks>
	/// </summary>
	internal class TenExpression : Expression

	{
		public override string Five()
		{
			return "L";
		}

		public override string Four()
		{
			return "XL";
		}

		public override int Multiplier()
		{
			return 10;
		}

		public override string Nine()
		{
			return "XC";
		}

		public override string One()
		{
			return "X";
		}
	}
}