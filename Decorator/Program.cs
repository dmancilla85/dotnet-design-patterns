using GangOfFour.Decorator.RealWorld;
using GangOfFour.Decorator.Structural;
using System;

namespace GangOfFour.Decorator
{
	public static class Program
	{
		/// <summary>
		/// Attach additional responsibilities to an object dynamically. Decorators
		/// provide a flexible alternative to subclassing for extending functionality.
		/// </summary>
		private static void Main()
		{
			Console.WriteLine("** Structural example **");
			MainApp.OtherMain();

			Console.WriteLine();
			Console.WriteLine();

			Console.WriteLine("** Real World example **");
			Console.WriteLine();

			/* This real-world code demonstrates the Decorator pattern in which 'borrowable' functionality
			 * is added to existing library items (books and videos).*/

			// Create book
			Book book = new Book("Worley", "Inside ASP.NET", 10);
			book.Display();

			// Create video
			Video video = new Video("Spielberg", "Jaws", 23, 92);
			video.Display();

			// Make video borrowable, then borrow and display

			Console.WriteLine("\nMaking video borrowable:");

			Borrowable borrowvideo = new Borrowable(video);
			borrowvideo.BorrowItem("Customer #1");
			borrowvideo.BorrowItem("Customer #2");

			borrowvideo.Display();

			// Wait for user

			Console.ReadKey();
		}
	}
}