using System;

namespace GangOfFour.Command.Structural
{
	/// <summary>
	/// The 'Receiver' class
	/// </summary>
	internal class Receiver
	{
		public void Action()
		{
			Console.WriteLine("Called Receiver.Action()");
		}
	}
}