﻿using System;
using System.Collections.Generic;

namespace GangOfFour.Composite.RealWorld
{
	/// <summary>
	/// The 'Composite' class
	/// </summary>
	internal class CompositeElement : DrawingElement

	{
		private readonly List<DrawingElement> elements =
			new List<DrawingElement>();

		// Constructor

		public CompositeElement(string name)
			: base(name)
		{
		}

		public override void Add(DrawingElement d)
		{
			elements.Add(d);
		}

		public override void Display(int indent)
		{
			Console.WriteLine(new String('-', indent) +
				"+ " + _name);

			// Display each child element on this node
			foreach (DrawingElement d in elements)
			{
				d.Display(indent + 2);
			}
		}

		public override void Remove(DrawingElement d)
		{
			elements.Remove(d);
		}
	}
}