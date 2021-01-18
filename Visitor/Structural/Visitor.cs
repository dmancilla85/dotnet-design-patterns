namespace GangOfFour.Visitor.Structural
{
	/// <summary>
	/// The 'Visitor' abstract class
	/// </summary>
	internal abstract class Visitor

  {
    public abstract void VisitConcreteElementA(
      ConcreteElementA concreteElementA);
    public abstract void VisitConcreteElementB(
      ConcreteElementB concreteElementB);
  }
}
