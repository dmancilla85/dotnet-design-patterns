namespace GangOfFour.AbstractFactory.RealWorld
{
	/// <summary>
	/// The 'AbstractFactory' abstract class
	/// </summary>
	internal abstract class ContinentFactory

	{
		public abstract Carnivore CreateCarnivore();

		public abstract Herbivore CreateHerbivore();
	}
}