using System.Collections.Generic;

namespace GangOfFour.Visitor.Structural
{
	/// <summary>
	/// The 'ObjectStructure' class
	/// </summary>
	internal class ObjectStructure

	{
		private readonly List<Element> _elements = new List<Element>();

		public void Accept(Visitor visitor)
		{
			foreach (Element element in _elements)
			{
				element.Accept(visitor);
			}
		}

		public void Attach(Element element)
		{
			_elements.Add(element);
		}

		public void Detach(Element element)
		{
			_elements.Remove(element);
		}
	}
}