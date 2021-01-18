using System;

namespace GangOfFour.Adapter.Structural
{
	/// <summary>
	/// The 'Adaptee' class
	/// </summary>
	internal class Adaptee
	{
		public void SpecificRequest()
		{
			Console.WriteLine("Called SpecificRequest()");
		}
	}
}