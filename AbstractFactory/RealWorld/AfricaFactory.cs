namespace GangOfFour.AbstractFactory.RealWorld
{
	/// <summary>
	/// The 'ConcreteFactory1' class
	/// </summary>
	internal class AfricaFactory : ContinentFactory

	{
		public override Carnivore CreateCarnivore()
		{
			return new Lion();
		}

		public override Herbivore CreateHerbivore()
		{
			return new Wildebeest();
		}
	}
}