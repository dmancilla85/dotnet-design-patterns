namespace GangOfFour.Prototype.Structural
{
	/// <summary>
	/// The 'Prototype' abstract class
	/// </summary>
	internal abstract class Prototype

	{
		// Constructor
		protected Prototype(string id)
		{
			this.Id = id;
		}

		// Gets id
		public string Id { get; }

		public abstract Prototype Clone();
	}
}