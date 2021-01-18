using System;
using System.Collections.Generic;

namespace GangOfFour.Observer.RealWorld
{
	/// <summary>
	/// The 'Subject' abstract class
	/// </summary>
	internal abstract class Stock

	{
		private readonly List<IInvestor> _investors = new List<IInvestor>();
		private double _price;
		// Constructor

		protected Stock(string symbol, double price)
		{
			this.Symbol = symbol;
			this._price = price;
		}

		public double Price
		{
			get { return _price; }
			set

			{
				if (_price != value)
				{
					_price = value;
					Notify();
				}
			}
		}

		public string Symbol { get; }

		public void Attach(IInvestor investor)
		{
			_investors.Add(investor);
		}

		public void Detach(IInvestor investor)
		{
			_investors.Remove(investor);
		}

		public void Notify()
		{
			foreach (IInvestor investor in _investors)
			{
				investor.Update(this);
			}

			Console.WriteLine("");
		}

		// Gets or sets the price Gets the symbol
	}
}