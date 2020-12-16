namespace GangOfFour.Singleton.Structural
{
	/// <summary>
	/// The 'Singleton' class
	/// </summary>
	internal class Singleton

	{
		private static Singleton _instance;

		// Constructor is 'protected'
		protected Singleton()
		{
		}

		public static Singleton Instance()
		{
			// Uses lazy initialization.
			// Note: this is not thread safe.
			return _instance ??= new Singleton();
		}
	}
}