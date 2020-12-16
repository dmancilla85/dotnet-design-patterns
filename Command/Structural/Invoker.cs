namespace GangOfFour.Command.Structural
{
	/// <summary>
	/// The 'Invoker' class
	/// </summary>
	internal class Invoker
	{
		private Command _command;

		public void ExecuteCommand()
		{
			_command.Execute();
		}

		public void SetCommand(Command command)
		{
			this._command = command;
		}
	}
}