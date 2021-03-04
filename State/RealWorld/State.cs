﻿namespace GangOfFour.State.RealWorld
{
	/// <summary>
	/// The 'State' abstract class
	/// </summary>
	internal abstract class State

	{
		protected Account account;
		protected double balance;

		protected double interest;
		protected double lowerLimit;
		protected double upperLimit;

		// Properties

		public Account Account
		{
			get { return account; }
			set { account = value; }
		}

		public double Balance
		{
			get { return balance; }
			set { balance = value; }
		}

		public abstract void Deposit(double amount);

		public abstract void PayInterest();

		public abstract void Withdraw(double amount);
	}
}