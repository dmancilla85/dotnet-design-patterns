namespace GangOfFour.Proxy.Structural
{
	/// <summary>
	/// MainApp startup class for Structural Proxy Design Pattern.
	/// </summary>
	internal static class MainApp

	{
		/// <summary>
		/// Entry point into console application.
		/// </summary>
		internal static void OtherMain()
		{
			// Create proxy and request a service
			Proxy proxy = new Proxy();
			proxy.Request();
		}
	}
}