namespace GangOfFour.Iterator.Structural
{
	/// <summary>
	/// The 'Iterator' abstract class
	/// </summary>
	internal abstract class Iterator

  {
    public abstract object First();
    public abstract object Next();
    public abstract bool IsDone();
    public abstract object CurrentItem();
  }
}
