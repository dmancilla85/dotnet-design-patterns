using System;
using System.Collections.Generic;
using System.Text;

namespace GangOfFour.Interpreter.RealWorld
{
	/// <summary>
	/// The 'Context' class
	/// </summary>
	internal class Context

  {

		// Constructor
		public Context(string input)
    {
      this.Input = input;
    }

		// Gets orz sets input
		public string Input { get; set; }

		// Gets or sets output
		public int Output { get; set; }
	}
}
