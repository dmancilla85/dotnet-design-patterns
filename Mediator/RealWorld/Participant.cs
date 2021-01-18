using System;

namespace GangOfFour.Mediator.RealWorld
{
	/// <summary>
	/// The 'AbstractColleague' class
	/// </summary>
	internal class Participant

	{
		// Constructor

		public Participant(string name)
		{
			this.Name = name;
		}

		// Gets participant name

		public Chatroom Chatroom { set; get; }
		public string Name { get; }

		// Gets chatroom Sends message to given participant

		public virtual void Receive(
			string from, string message)
		{
			Console.WriteLine("{0} to {1}: '{2}'",
				from, Name, message);
		}

		public void Send(string to, string message)
		{
			Chatroom.Send(Name, to, message);
		}

		// Receives message from given participant
	}
}