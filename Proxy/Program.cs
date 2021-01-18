using GangOfFour.Proxy.RealWorld;
using GangOfFour.Proxy.Structural;
using System;

namespace GangOfFour.Proxy
{
	/// <summary>
	/// Provide a surrogate or placeholder for another object to control access to it.
	/// </summary>
	internal static class Program
	{
		private static void Main()
		{
			Console.WriteLine("** Structural example **");
			MainApp.OtherMain();

			Console.WriteLine();
			Console.WriteLine();

			Console.WriteLine("** Real World example **");
			Console.WriteLine();

			/* This real-world code demonstrates the Proxy pattern for a Math object represented by a 
			 * MathProxy object. */
			// Create math proxy

			MathProxy proxy = new MathProxy();

			// Do the math

			Console.WriteLine("4 + 2 = " + proxy.Add(4, 2));
			Console.WriteLine("4 - 2 = " + proxy.Sub(4, 2));
			Console.WriteLine("4 * 2 = " + proxy.Mul(4, 2));
			Console.WriteLine("4 / 2 = " + proxy.Div(4, 2));
		}
	}
}