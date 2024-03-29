﻿using System;

namespace GangOfFour.Mediator.RealWorld
{
	/// <summary>
	/// A 'ConcreteColleague' class
	/// </summary>
	internal class Beatle : Participant

	{
		// Constructor

		public Beatle(string name)
			: base(name)
		{
		}

		public override void Receive(string from, string message)
		{
			Console.Write("To a Beatle: ");
			base.Receive(from, message);
		}
	}
}