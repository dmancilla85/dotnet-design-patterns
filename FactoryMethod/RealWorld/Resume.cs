namespace GangOfFour.FactoryMethod.RealWorld
{
	/// <summary>
	/// A 'ConcreteCreator' class
	/// </summary>
	internal class Resume : Document

	{
		// Factory Method implementation
		public override void CreatePages()
		{
			Pages.Add(new SkillsPage());
			Pages.Add(new EducationPage());
			Pages.Add(new ExperiencePage());
		}
	}
}