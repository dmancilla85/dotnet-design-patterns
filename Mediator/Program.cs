using GangOfFour.Mediator.RealWorld;
using GangOfFour.Mediator.Structural;
using System;

namespace GangOfFour.Mediator
{
	internal static class Program
	{
		/// <summary>
		/// Define an object that encapsulates how a set of objects interact.
		/// Mediator promotes loose coupling by keeping objects from referring to
		/// each other explicitly, and it lets you vary their interaction independently.
		/// </summary>
		private static void Main()
		{
			Console.WriteLine("** Structural example **");
			MainApp.OtherMain();

			Console.WriteLine();
			Console.WriteLine();

			Console.WriteLine("** Real World example **");
			Console.WriteLine();

			/* This real-world code demonstrates the Mediator pattern facilitating loosely coupled
			 * communication between different Participants registering with a Chatroom. The Chatroom
			 * is the central hub through which all communication takes place. At this point only
			 * one-to-one communication is implemented in the Chatroom, but would be trivial to change
			 * to one-to-many. */

			// Create chatroom
			Chatroom chatroom = new Chatroom();

			// Create participants and register them
			Participant George = new Beatle("George");
			Participant Paul = new Beatle("Paul");
			Participant Ringo = new Beatle("Ringo");
			Participant John = new Beatle("John");
			Participant Yoko = new NonBeatle("Yoko");

			chatroom.Register(George);
			chatroom.Register(Paul);
			chatroom.Register(Ringo);
			chatroom.Register(John);
			chatroom.Register(Yoko);

			// Chatting participants
			Yoko.Send("John", "Hi John!");
			Paul.Send("Ringo", "All you need is love");
			Ringo.Send("George", "My sweet Lord");
			Paul.Send("John", "Can't buy me love");
			John.Send("Yoko", "My sweet love");

			// Wait for user
			Console.ReadKey();
		}
	}
}