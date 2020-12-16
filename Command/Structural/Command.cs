namespace GangOfFour.Command.Structural
{
	/// <summary>
	/// The 'Command' abstract class
	/// </summary>
	internal abstract class Command

	{
		protected Receiver receiver;

		// Constructor
		protected Command(Receiver receiver)
		{
			this.receiver = receiver;
		}

		public abstract void Execute();
	}
}