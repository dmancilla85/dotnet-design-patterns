namespace GangOfFour.Command.Structural
{
	/// <summary>
	/// The 'ConcreteCommand' class
	/// </summary>
	internal class ConcreteCommand : Command

	{
		// Constructor
		public ConcreteCommand(Receiver receiver) :
			base(receiver)
		{
		}

		public override void Execute()
		{
			receiver.Action();
		}
	}
}