using System;

namespace GangOfFour.Facade.RealWorld
{
	/// <summary>
	/// The 'Subsystem ClassB' class
	/// </summary>
	internal class Credit
	{
		public bool HasGoodCredit(Customer c)
		{
			Console.WriteLine("Check credit for " + c.Name);
			return true;
		}
	}
}