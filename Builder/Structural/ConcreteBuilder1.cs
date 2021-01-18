namespace GangOfFour.Builder.Structural
{
	/// <summary>
	/// The 'ConcreteBuilder1' class
	/// </summary>
	internal class ConcreteBuilder1 : Builder

  {
    private readonly Product _product = new Product();

    public override void BuildPartA()
    {
      _product.Add("PartA");
    }

    public override void BuildPartB()
    {
      _product.Add("PartB");
    }

    public override Product GetResult()
    {
      return _product;
    }
  }
}
