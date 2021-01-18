using GangOfFour.Singleton.RealWorld;
using GangOfFour.Singleton.Structural;
using System;

namespace GangOfFour.Singleton
{
	public static class Program
	{
		/// <summary>
		/// Ensure a class has only one instance and provide a global point of
		/// access to it.
		/// </summary>
		internal static void Main()
		{
			Console.WriteLine("** Structural example **");
			MainApp.OtherMain();

			Console.WriteLine();
			Console.WriteLine();

			Console.WriteLine("** Real World example **");
			Console.WriteLine();

			/* This real-world code demonstrates the Singleton pattern as a LoadBalancing object. Only a
			 * single instance (the singleton) of the class can be created because servers may dynamically
			 * come on- or off-line and every request must go throught the one object that has knowledge
			 * about the state of the (web) farm.
			 */

			LoadBalancer b1 = LoadBalancer.GetLoadBalancer();
			LoadBalancer b2 = LoadBalancer.GetLoadBalancer();
			LoadBalancer b3 = LoadBalancer.GetLoadBalancer();
			LoadBalancer b4 = LoadBalancer.GetLoadBalancer();

			// Same instance?

			if (b1 == b2 && b2 == b3 && b3 == b4)
			{
				Console.WriteLine("Same instance\n");
			}

			// Load balance 15 server requests

			LoadBalancer balancer = LoadBalancer.GetLoadBalancer();
			for (int i = 0; i < 15; i++)
			{
				string server = balancer.Server;
				Console.WriteLine("Dispatch Request to: " + server);
			}
		}
	}
}