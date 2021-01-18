using GangOfFourMediator.Structural;
using System;

namespace GangOfFour.Observer.Structural
{
	internal static class MainApp
	{
		/// <summary>
		/// Entry point into console application.
		/// </summary>
		public static void OtherMain()
		{
			// Configure Observer pattern

			ConcreteSubject s = new ConcreteSubject();

			s.Attach(new ConcreteObserver(s, "X"));
			s.Attach(new ConcreteObserver(s, "Y"));
			s.Attach(new ConcreteObserver(s, "Z"));

			// Change subject and notify observers

			s.SubjectState = "ABC";
			s.Notify();

			// Wait for user

			Console.ReadKey();
		}
	}
}