namespace GangOfFour.Composite.RealWorld
{
	/// <summary>
	/// The 'Component' Treenode
	/// </summary>
	internal abstract class DrawingElement

	{
		protected string _name;

		// Constructor
		protected DrawingElement(string name)
		{
			this._name = name;
		}

		public abstract void Add(DrawingElement d);

		public abstract void Display(int indent);

		public abstract void Remove(DrawingElement d);
	}
}