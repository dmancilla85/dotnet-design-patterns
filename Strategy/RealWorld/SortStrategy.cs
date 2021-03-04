using System.Collections.Generic;

namespace GangOfFour.Strategy.RealWorld
{
	/// <summary>
	/// The 'Strategy' abstract class
	/// </summary>
	internal abstract class SortStrategy

	{
		public abstract void Sort(List<string> list);
	}
}