using System;

namespace GangOfFour.Command.RealWorld
{
	/// <summary>
	/// The 'ConcreteCommand' class
	/// </summary>
	internal class CalculatorCommand : Command
	{
		private readonly Calculator _calculator;
		private int _operand;
		private char _operator;

		// Constructor
		public CalculatorCommand(Calculator calculator,
			char @operator, int operand)
		{
			this._calculator = calculator;
			this._operator = @operator;
			this._operand = operand;
		}

		// Get operand
		public int Operand
		{
			set { _operand = value; }
		}

		// Gets operator
		public char Operator
		{
			set { _operator = value; }
		}

		// Returns opposite operator for given operator
		private char Undo(char @operator)
		{
			return @operator switch
			{
				'+' => '-',
				'-' => '+',
				'*' => '/',
				'/' => '*',
				_ => throw new

ArgumentException("@operator"),
			};
		}

		// Execute new command
		public override void Execute()
		{
			_calculator.Operation(_operator, _operand);
		}

		// Unexecute last command
		public override void UnExecute()
		{
			_calculator.Operation(Undo(_operator), _operand);
		}
	}
}