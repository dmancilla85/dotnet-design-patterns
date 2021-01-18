﻿namespace GangOfFour.Adapter.Structural
{
	/// <summary>
	/// The 'Adapter' class
	/// </summary>
	internal class Adapter : Target

	{
		private Adaptee _adaptee = new Adaptee();

		public override void Request()
		{
			// Possibly do some other work and then call SpecificRequest
			_adaptee.SpecificRequest();
		}
	}
}