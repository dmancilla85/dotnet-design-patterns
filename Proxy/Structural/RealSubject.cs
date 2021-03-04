using System;

namespace GangOfFour.Proxy.Structural
{
	/// <summary>
	/// The 'RealSubject' class
	/// </summary>
	internal class RealSubject : Subject

	{
		public override void Request()
		{
			Console.WriteLine("Called RealSubject.Request()");
		}
	}
}