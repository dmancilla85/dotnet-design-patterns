using System;

namespace GangOfFour.Mediator.Structural
{
	/// <summary>
	/// A 'ConcreteColleague' class
	/// </summary>
	internal class ConcreteColleague2 : Colleague

	{
		// Constructor

		public ConcreteColleague2(Mediator mediator)
			: base(mediator)
		{
		}

		public void Notify(string message)
		{
			Console.WriteLine("Colleague2 gets message: "

				+ message);
		}

		public void Send(string message)
		{
			mediator.Send(message, this);
		}
	}
}