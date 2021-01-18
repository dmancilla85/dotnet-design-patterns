namespace GangOfFour.Adapter.Structural
{
	/// <summary>
	/// MainApp startup class for Structural Adapter Design Pattern.
	/// </summary>
	internal static class MainApp
	{
		internal static void OtherMain()
		{
			// Create adapter and place a request

			Target target = new Adapter();
			target.Request();
		}
	}
}