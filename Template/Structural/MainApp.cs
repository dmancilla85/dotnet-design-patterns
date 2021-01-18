namespace GangOfFour.Template.Structural
{
	/// <summary>
	/// MainApp startup class for Real-World Template Design Pattern.
	/// </summary>
	internal static class MainApp

	{
		/// <summary>
		/// Entry point into console application.
		/// </summary>
		internal static void OtherMain()
		{
			AbstractClass aA = new ConcreteClassA();
			aA.TemplateMethod();

			AbstractClass aB = new ConcreteClassB();
			aB.TemplateMethod();
		}
	}
}