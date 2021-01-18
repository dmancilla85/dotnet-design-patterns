namespace GangOfFour.Memento.Structural
{
	/// <summary>
	/// The 'Memento' class
	/// </summary>
	internal class Memento

	{
		// Constructor
		public Memento(string state)
		{
			this.State = state;
		}

		// Gets or sets state
		public string State { get; }
	}
}