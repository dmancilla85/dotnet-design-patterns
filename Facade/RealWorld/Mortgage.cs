﻿using System;

namespace GangOfFour.Facade.RealWorld
{
	/// <summary>
	/// The 'Facade' class
	/// </summary>
	internal class Mortgage

	{
		private readonly Bank _bank = new Bank();
		private readonly Credit _credit = new Credit();
		private readonly Loan _loan = new Loan();

		public bool IsEligible(Customer cust, int amount)
		{
			Console.WriteLine("{0} applies for {1:C} loan\n",
				cust.Name, amount);

			bool eligible = true;

			// Check creditworthyness of applicant

			if (!_bank.HasSufficientSavings(cust, amount))
			{
				eligible = false;
			}
			else if (!_loan.HasNoBadLoans(cust))
			{
				eligible = false;
			}
			else if (!_credit.HasGoodCredit(cust))
			{
				eligible = false;
			}

			return eligible;
		}
	}
}