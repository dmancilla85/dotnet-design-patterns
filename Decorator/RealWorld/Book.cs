﻿using System;

namespace GangOfFour.Decorator.RealWorld
{
	/// <summary>
	/// The 'ConcreteComponent' class
	/// </summary>
	internal class Book : LibraryItem

	{
		private readonly string _author;
		private readonly string _title;

		// Constructor
		public Book(string author, string title, int numCopies)
		{
			this._author = author;
			this._title = title;
			this.NumCopies = numCopies;
		}

		public override void Display()
		{
			Console.WriteLine("\nBook ------ ");
			Console.WriteLine(" Author: {0}", _author);
			Console.WriteLine(" Title: {0}", _title);
			Console.WriteLine(" # Copies: {0}", NumCopies);
		}
	}
}