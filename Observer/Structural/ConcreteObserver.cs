using GangOfFour.Observer.Structural;
using System;

namespace GangOfFourMediator.Structural
{
	/// <summary>
	/// The 'ConcreteObserver' class
	/// </summary>
	internal class ConcreteObserver : Observer
	{
		private readonly string _name;
		private string _observerState;

		// Constructor

		public ConcreteObserver(
			ConcreteSubject subject, string name)
		{
			this.Subject = subject;
			this._name = name;
		}

		public ConcreteSubject Subject { get; set; }

		public override void Update()
		{
			_observerState = Subject.SubjectState;
			Console.WriteLine("Observer {0}'s new state is {1}",
				_name, _observerState);
		}

		// Gets or sets subject
	}
}