namespace GangOfFour.Proxy.Structural
{
	/// <summary>
	/// The 'Proxy' class
	/// </summary>
	internal class Proxy : Subject

	{
		private RealSubject _realSubject;

		public override void Request()
		{
			// Use 'lazy initialization'
			(_realSubject ??= new RealSubject()).Request();
		}
	}
}