namespace GangOfFour.Flyweight.RealWorld
{
	/// <summary>
	/// The 'Flyweight' abstract class
	/// </summary>
	internal abstract class Character

	{
		protected int ascent;
		protected int descent;
		protected int height;
		protected int pointSize;
		protected char symbol;
		protected int width;

		public abstract void Display(int pointSize);
	}
}