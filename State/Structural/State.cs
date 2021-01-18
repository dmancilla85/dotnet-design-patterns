namespace GangOfFour.State.Structural
{
	/// <summary>
	/// The 'State' abstract class
	/// </summary>
	internal abstract class State

  {
    public abstract void Handle(Context context);
  }
}
