using GangOfFour.State.RealWorld;
using GangOfFour.State.Structural;
using System;

namespace GangOfFour.State
{
	/// <summary>
	/// Allow an object to alter its behavior when its internal state changes. The
	/// object will appear to change its class.
	/// </summary>
	internal static class Program
	{
		private static void Main()
		{
			Console.WriteLine("** Structural example **");
			MainApp.OtherMain();

			Console.WriteLine();
			Console.WriteLine();

			Console.WriteLine("** Real World example **");
			Console.WriteLine();

			/* This real-world code demonstrates the State pattern which allows an Account to behave
			 * differently depending on its balance. The difference in behavior is delegated to State
			 * objects called RedState, SilverState and GoldState. These states represent overdrawn
			 * accounts, starter accounts, and accounts in good standing. */

			// Open a new account
			Account account = new Account("Jim Johnson");

			// Apply financial transactions
			account.Deposit(500.0);
			account.Deposit(300.0);
			account.Deposit(550.0);
			account.PayInterest();
			account.Withdraw(2000.00);
			account.Withdraw(1100.00);
		}
	}
}