﻿using System;

namespace GangOfFour.Facade.RealWorld
{
	/// <summary>
	/// The 'Subsystem ClassC' class
	/// </summary>
	internal class Loan

	{
		public bool HasNoBadLoans(Customer c)
		{
			Console.WriteLine("Check loans for " + c.Name);
			return true;
		}
	}
}