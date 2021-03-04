using System;

namespace GangOfFour.State.Structural
{
	/// <summary>
	/// The 'Context' class
	/// </summary>
	internal class Context

	{
		private State _state;

		// Constructor
		public Context(State state)
		{
			this.State = state;
		}

		// Gets or sets the state
		public State State
		{
			get => _state;
			set

			{
				_state = value;
				if (_state != null)
				{
					Console.WriteLine("State: " + _state.GetType().Name);
				}
			}
		}

		public void Request()
		{
			_state.Handle(this);
		}
	}
}