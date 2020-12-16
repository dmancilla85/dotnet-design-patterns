using System;

namespace GangOfFour.Facade.RealWorld
{
	/// <summary>
	/// The 'Subsystem ClassA' class
	/// </summary>
	internal class Bank

	{
		public bool HasSufficientSavings(Customer c, int amount)
		{
			Console.WriteLine($"Check bank for {c.Name} with an amount of {amount}");
			return true;
		}
	}
}