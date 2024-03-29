﻿using System;
using System.Collections.Generic;

namespace GangOfFour.Strategy.RealWorld
{
	/// <summary>
	/// The 'Context' class
	/// </summary>
	internal class SortedList

	{
		private readonly List<string> _list = new List<string>();
		private SortStrategy _sortstrategy;

		public void Add(string name)
		{
			_list.Add(name);
		}

		public void SetSortStrategy(SortStrategy sortstrategy)
		{
			this._sortstrategy = sortstrategy;
		}

		public void Sort()
		{
			_sortstrategy.Sort(_list);

			// Iterate over list and display results
			foreach (string name in _list)
			{
				Console.WriteLine(" " + name);
			}
			Console.WriteLine();
		}
	}
}