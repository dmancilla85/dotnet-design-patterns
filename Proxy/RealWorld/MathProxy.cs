﻿namespace GangOfFour.Proxy.RealWorld
{
	/// <summary>
	/// The 'Proxy Object' class
	/// </summary>
	internal class MathProxy : IMath

	{
		private readonly Math _math = new Math();

		public double Add(double x, double y)
		{
			return _math.Add(x, y);
		}

		public double Div(double x, double y)
		{
			return _math.Div(x, y);
		}

		public double Mul(double x, double y)
		{
			return _math.Mul(x, y);
		}

		public double Sub(double x, double y)
		{
			return _math.Sub(x, y);
		}
	}
}