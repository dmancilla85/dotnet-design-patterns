namespace GangOfFour.Builder.Structural
{
	/// <summary>
	/// The 'Director' class
	/// </summary>

	internal class Director

  {
    // Builder uses a complex series of steps
    public void Construct(Builder builder)
    {
      builder.BuildPartA();
      builder.BuildPartB();
    }
  }
}
