using System;

namespace GangOfFour.Mediator.Structural
{
	/// <summary>
	/// A 'ConcreteColleague' class
	/// </summary>
	internal class ConcreteColleague1 : Colleague

	{
		// Constructor

		public ConcreteColleague1(Mediator mediator)
			: base(mediator)
		{
		}

		public void Notify(string message)
		{
			Console.WriteLine("Colleague1 gets message: "

				+ message);
		}

		public void Send(string message)
		{
			mediator.Send(message, this);
		}
	}
}