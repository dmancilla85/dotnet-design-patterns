namespace GangOfFour.Decorator.RealWorld
{
	/// <summary>
	/// The 'Component' abstract class
	/// </summary>
	internal abstract class LibraryItem

	{
		// Property
		public int NumCopies { get; set; }

		public abstract void Display();
	}
}