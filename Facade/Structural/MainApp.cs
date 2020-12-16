namespace GangOfFour.Facade.Structural
{
	/// <summary>
	/// MainApp startup class for Structural Facade Design Pattern.
	/// </summary>
	internal static class MainApp

	{
		/// <summary>
		/// Entry point into console application.
		/// </summary>
		public static void OtherMain()
		{
			Facade facade = new Facade();

			facade.MethodA();
			facade.MethodB();
		}
	}
}