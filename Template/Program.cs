using GangOfFour.Template.RealWorld;
using GangOfFour.Template.Structural;
using System;

namespace GangOfFour.Template
{
	/// <summary>
	/// Define the skeleton of an algorithm in an operation, deferring some steps
	/// to subclasses. Template Method lets subclasses redefine certain steps of
	/// an algorithm without changing the algorithm's structure.
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
			DataAccessObject daoCategories = new Categories();

			try
			{
				daoCategories.Run();
			}
			catch (SystemException e)
			{
				Console.WriteLine("Error: " + e.Message);
			}
			DataAccessObject daoProducts = new Products();

			try
			{
				daoProducts.Run();
			}
			catch (SystemException e)
			{
				Console.WriteLine("Error: " + e.Message);
			}

			// Wait for user
			Console.ReadKey();
		}
	}
}