namespace GangOfFour.Builder.RealWorld
{
	/// <summary>
	/// The 'Builder' abstract class
	/// </summary>
	internal abstract class VehicleBuilder

	{
		protected Vehicle vehicle;

		// Gets vehicle instance
		public Vehicle Vehicle
		{
			get { return vehicle; }
		}

		public abstract void BuildDoors();

		public abstract void BuildEngine();

		// Abstract build methods
		public abstract void BuildFrame();

		public abstract void BuildWheels();
	}
}