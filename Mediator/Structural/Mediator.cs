namespace GangOfFour.Mediator.Structural
{
	/// <summary>
	/// The 'Mediator' abstract class
	/// </summary>
	internal abstract class Mediator

	{
		public abstract void Send(string message,
			Colleague colleague);
	}
}