namespace GangOfFour.Decorator.RealWorld
{
	/// <summary>
	/// The 'Decorator' abstract class
	/// </summary>
	internal abstract class Decorator : LibraryItem

	{
		protected LibraryItem libraryItem;

		// Constructor
		protected Decorator(LibraryItem libraryItem)
		{
			this.libraryItem = libraryItem;
		}

		public override void Display()
		{
			libraryItem.Display();
		}
	}
}