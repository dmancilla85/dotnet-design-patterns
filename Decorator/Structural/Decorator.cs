namespace GangOfFour.Decorator.Structural
{
	/// <summary>
	/// The 'Decorator' abstract class
	/// </summary>
	internal abstract class Decorator : Component

	{
		protected Component component;

		public override void Operation()
		{
			if (component != null)
			{
				component.Operation();
			}
		}

		public void SetComponent(Component component)
		{
			this.component = component;
		}
	}
}