﻿using System;

namespace GangOfFour.Observer.RealWorld
{
	/// <summary>
	/// The 'ConcreteObserver' class
	/// </summary>
	internal class Investor : IInvestor

	{
		private readonly string _name;

		// Constructor

		public Investor(string name)
		{
			this._name = name;
		}

		public Stock Stock { get; set; }

		public void Update(Stock stock)
		{
			Console.WriteLine("Notified {0} of {1}'s " +
				"change to {2:C}", _name, stock.Symbol, stock.Price);
		}

		// Gets or sets the stock
	}
}