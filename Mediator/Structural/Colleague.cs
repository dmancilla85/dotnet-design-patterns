namespace GangOfFour.Mediator.Structural
{
	/// <summary>
	/// The 'Colleague' abstract class
	/// </summary>
	internal abstract class Colleague

	{
		protected Mediator mediator;

		// Constructor

		public Colleague(Mediator mediator)
		{
			this.mediator = mediator;
		}
	}
}