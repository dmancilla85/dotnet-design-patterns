using System;

namespace GangOfFour.Adapter.Structural
{
	/// <summary>
	/// The 'Target' class
	/// </summary>
	internal class Target

	{
		public virtual void Request()
		{
			Console.WriteLine("Called Target Request()");
		}
	}
}