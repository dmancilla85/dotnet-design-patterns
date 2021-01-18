namespace GangOfFour.Memento.Structural
{
	/// <summary>
	/// MainApp startup class for Structural Memento Design Pattern.
	/// </summary>
	internal static class MainApp

	{
		/// <summary>
		/// Entry point into console application.
		/// </summary>
		internal static void OtherMain()
		{
			Originator o = new Originator
			{
				State = "On"
			};

			// Store internal state
			Caretaker c = new Caretaker
			{
				Memento = o.CreateMemento()
			};

			// Continue changing originator
			o.State = "Off";

			// Restore saved state
			o.SetMemento(c.Memento);
		}
	}
}