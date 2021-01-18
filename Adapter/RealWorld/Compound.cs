using System;

namespace GangOfFour.Adapter.RealWorld
{
	/// <summary>
	/// The 'Target' class
	/// </summary>
	internal class Compound
	{
		protected float _boilingPoint;
		protected string _chemical;
		protected float _meltingPoint;
		protected string _molecularFormula;
		protected double _molecularWeight;
		// Constructor

		public Compound(string chemical)
		{
			this._chemical = chemical;
		}

		public virtual void Display()
		{
			Console.WriteLine("\nCompound: {0} ------ ", _chemical);
		}
	}
}