namespace GangOfFour.AbstractFactory.RealWorld
{
	/// <summary>
	/// The 'ConcreteFactory2' class
	/// </summary>
	internal class AmericaFactory : ContinentFactory

	{
		public override Carnivore CreateCarnivore()
		{
			return new Wolf();
		}

		public override Herbivore CreateHerbivore()
		{
			return new Bison();
		}
	}
}