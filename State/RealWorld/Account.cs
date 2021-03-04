using System;

namespace GangOfFour.State.RealWorld
{
	/// <summary>
	/// The 'Context' class
	/// </summary>
	internal class Account

	{
		private readonly string _owner;

		// Constructor
		public Account(string owner)
		{
			// New accounts are 'Silver' by default

			this._owner = owner;
			this.State = new SilverState(0.0, this);
		}

		// Properties
		public double Balance
		{
			get { return State.Balance; }
		}

		public State State { get; set; }

		public void Deposit(double amount)
		{
			State.Deposit(amount);
			Console.WriteLine("Deposited {0:C} --- ", amount);
			Console.WriteLine(" Balance = {0:C}", this.Balance);
			Console.WriteLine(" Status = {0}",
				this.State.GetType().Name);
			Console.WriteLine("Owner: " + _owner);
		}

		public void PayInterest()
		{
			State.PayInterest();
			Console.WriteLine("Interest Paid --- ");
			Console.WriteLine(" Balance = {0:C}", this.Balance);
			Console.WriteLine(" Status = {0}\n",
				this.State.GetType().Name);
		}

		public void Withdraw(double amount)
		{
			State.Withdraw(amount);
			Console.WriteLine("Withdrew {0:C} --- ", amount);
			Console.WriteLine(" Balance = {0:C}", this.Balance);
			Console.WriteLine(" Status = {0}\n",
				this.State.GetType().Name);
		}
	}
}