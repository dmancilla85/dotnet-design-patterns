﻿using System;

namespace GangOfFour.Chain.Structural
{
	/// <summary>
	/// MainApp startup class for Structural Chain of Responsibility Design Pattern.
	/// </summary>
	internal static class MainApp

	{
		/// <summary>
		/// Entry point into console application.
		/// </summary>
		internal static void OtherMain()
		{
			// Setup Chain of Responsibility

			Handler h1 = new ConcreteHandler1();
			Handler h2 = new ConcreteHandler2();
			Handler h3 = new ConcreteHandler3();
			h1.SetSuccessor(h2);
			h2.SetSuccessor(h3);

			// Generate and process request

			int[] requests = { 2, 5, 14, 22, 18, 3, 27, 20 };

			foreach (int request in requests)
			{
				h1.HandleRequest(request);
			}

			// Wait for user

			Console.ReadKey();
		}
	}
}