namespace GangOfFour.AbstractFactory.RealWorld
{
	/// <summary>
	/// The 'Client' class
	/// </summary>
	internal class AnimalWorld

	{
		private readonly Carnivore _carnivore;
		private readonly Herbivore _herbivore;

		// Constructor
		public AnimalWorld(ContinentFactory factory)
		{
			_carnivore = factory.CreateCarnivore();
			_herbivore = factory.CreateHerbivore();
		}

		public void RunFoodChain()
		{
			_carnivore.Eat(_herbivore);
		}
	}
}