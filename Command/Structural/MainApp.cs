namespace GangOfFour.Command.Structural
{
	/// <summary>
	/// MainApp startup class for Structural Command Design Pattern.
	/// </summary>
	internal static class MainApp
	{
		/// <summary>
		/// Entry point into console application.
		/// </summary>
		internal static void OtherMain()
		{
			// Create receiver, command, and invoker

			Receiver receiver = new Receiver();
			Command command = new ConcreteCommand(receiver);
			Invoker invoker = new Invoker();

			// Set and execute command

			invoker.SetCommand(command);
			invoker.ExecuteCommand();
		}
	}
}