using System;

namespace GangOfFour.Singleton.Structural
{
	/// <summary>
	/// MainApp startup class for Structural Singleton Design Pattern.
	/// </summary>
	internal static class MainApp

	{
		/// <summary>
		/// Entry point into console application.
		/// </summary>
		internal static void OtherMain()
		{
			// Constructor is protected -- cannot use new

			Singleton s1 = Singleton.Instance();
			Singleton s2 = Singleton.Instance();

			// Test for same instance

			if (s1 == s2)
			{
				Console.WriteLine("Objects are the same instance");
			}

			// Wait for user

			Console.ReadKey();
		}
	}
}