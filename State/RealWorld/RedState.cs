﻿using System;

namespace GangOfFour.State.RealWorld
{
	/// <summary>
	/// A 'ConcreteState' class <remarks>Red indicates that account is overdrawn</remarks>
	/// </summary>
	internal class RedState : State

	{
		private double _serviceFee;

		// Constructor

		public RedState(State state)
		{
			this.balance = state.Balance;
			this.account = state.Account;
			Initialize();
		}

		private void Initialize()
		{
			// Should come from a datasource

			interest = 0.0;
			lowerLimit = -100.0;
			upperLimit = 0.0;
			_serviceFee = 15.00;
		}

		private void StateChangeCheck()
		{
			if (balance > upperLimit)
			{
				account.State = new SilverState(this);
			}
		}

		public override void Deposit(double amount)
		{
			balance += amount;
			StateChangeCheck();
		}

		public override void PayInterest()
		{
			// No interest is paid
		}

		public override void Withdraw(double amount)
		{
			amount -= _serviceFee;
			Console.WriteLine("No funds available for withdrawal!");
		}
	}
}