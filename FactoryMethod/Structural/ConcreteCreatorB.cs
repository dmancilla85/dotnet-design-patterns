namespace GangOfFour.FactoryMethod.Structural
{
	/// <summary>
	/// A 'ConcreteCreator' class
	/// </summary>
	internal class ConcreteCreatorB : Creator
	{
		public override Product FactoryMethod()
		{
			return new ConcreteProductB();
		}
	}
}