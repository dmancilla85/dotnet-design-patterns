namespace GangOfFour.Iterator.RealWorld
{
	/// <summary>
	/// The 'Iterator' interface
	/// </summary>
	internal interface IAbstractIterator
	{
		Item CurrentItem { get; }

		bool IsDone { get; }

		Item First();

		Item Next();
	}
}