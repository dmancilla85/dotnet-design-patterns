namespace GangOfFour.State.Structural
{
	/// <summary>
	/// A 'ConcreteState' class
	/// </summary>
	internal class ConcreteStateA : State

	{
		public override void Handle(Context context)
		{
			context.State = new ConcreteStateB();
		}
	}
}