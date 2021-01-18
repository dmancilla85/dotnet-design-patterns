namespace GangOfFour.Mediator.RealWorld
{
	/// <summary>
	/// The 'Mediator' abstract class
	/// </summary>
	internal abstract class AbstractChatroom

	{
		public abstract void Register(Participant participant);

		public abstract void Send(
			string from, string to, string message);
	}
}