namespace GangOfFour.Composite.Structural
{
	/// <summary>
	/// The 'Component' abstract class
	/// </summary>
	internal abstract class Component

	{
		protected string name;

		// Constructor
		protected Component(string name)
		{
			this.name = name;
		}

		public abstract void Add(Component c);

		public abstract void Display(int depth);

		public abstract void Remove(Component c);
	}
}