using GangOfFour.Strategy.RealWorld;
using GangOfFour.Strategy.Structural;
using System;

namespace GangOfFour.Strategy
{
	/// <summary>
	/// Define a family of algorithms, encapsulate each one, and make them
	/// interchangeable. Strategy lets the algorithm vary independently from
	/// clients that use it.
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

			/* This real-world code demonstrates the Strategy pattern which encapsulates sorting algorithms
			 * in the form of sorting objects. This allows clients to dynamically change sorting strategies
			 * including Quicksort, Shellsort, and Mergesort.*/

			// Two contexts following different strategies
			SortedList studentRecords = new SortedList();

			studentRecords.Add("Samual");
			studentRecords.Add("Jimmy");
			studentRecords.Add("Sandra");
			studentRecords.Add("Vivek");
			studentRecords.Add("Anna");

			studentRecords.SetSortStrategy(new QuickSort());
			studentRecords.Sort();

			studentRecords.SetSortStrategy(new ShellSort());
			studentRecords.Sort();

			studentRecords.SetSortStrategy(new MergeSort());
			studentRecords.Sort();
		}
	}
}