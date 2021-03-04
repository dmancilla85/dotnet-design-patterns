using System;
using System.Collections.Generic;

namespace GangOfFour.Composite.Structural
{
	/// <summary>
	/// The 'Composite' class
	/// </summary>
	internal class Composite : Component

	{
		private readonly List<Component> _children = new List<Component>();

		// Constructor
		public Composite(string name)
			: base(name)
		{
		}

		public override void Add(Component component)
		{
			_children.Add(component);
		}

		public override void Display(int depth)
		{
			Console.WriteLine(new String('-', depth) + name);

			// Recursively display child nodes
			foreach (Component component in _children)
			{
				component.Display(depth + 2);
			}
		}

		public override void Remove(Component component)
		{
			_children.Remove(component);
		}
	}
}