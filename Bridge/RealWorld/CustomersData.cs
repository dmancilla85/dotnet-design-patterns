﻿using System;
using System.Collections.Generic;

namespace GangOfFour.Bridge.RealWorld
{
	/// <summary>
	/// The 'ConcreteImplementor' class
	/// </summary>
	internal class CustomersData : DataObject

	{
		private readonly List<string> _customers = new List<string>();
		private int _current = 0;

		public CustomersData()
		{
			// Loaded from a database
			_customers.Add("Jim Jones");
			_customers.Add("Samual Jackson");
			_customers.Add("Allen Good");
			_customers.Add("Ann Stills");
			_customers.Add("Lisa Giolani");
		}

		public override void AddRecord(string customer)
		{
			_customers.Add(customer);
		}

		public override void DeleteRecord(string customer)
		{
			_customers.Remove(customer);
		}

		public override void NextRecord()
		{
			if (_current <= _customers.Count - 1)
			{
				_current++;
			}
		}

		public override void PriorRecord()
		{
			if (_current > 0)
			{
				_current--;
			}
		}

		public override void ShowAllRecords()
		{
			foreach (string customer in _customers)
			{
				Console.WriteLine(" " + customer);
			}
		}

		public override void ShowRecord()
		{
			Console.WriteLine(_customers[_current]);
		}
	}
}