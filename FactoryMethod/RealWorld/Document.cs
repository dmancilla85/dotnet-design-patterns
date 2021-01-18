using System.Collections.Generic;

namespace GangOfFour.FactoryMethod.RealWorld
{
	/// <summary>
	/// The 'Creator' abstract class
	/// </summary>
	internal abstract class Document

	{
		private readonly List<Page> _pages = new List<Page>();

		// Constructor calls abstract Factory method
		protected Document()
		{
			this.CreatePages();
		}

		public List<Page> Pages
		{
			get { return _pages; }
		}

		// Factory Method
		public abstract void CreatePages();
	}
}