namespace GangOfFour.State.Structural
{
	/// <summary>
	/// A 'ConcreteState' class
	/// </summary>
	internal class ConcreteStateB : State

  {
    public override void Handle(Context context)
    {
      context.State = new ConcreteStateA();
    }
  }
}
