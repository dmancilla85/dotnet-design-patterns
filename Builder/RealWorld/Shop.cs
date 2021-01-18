namespace GangOfFour.Builder.RealWorld
{
	/// <summary>
	/// The 'Director' class
	/// </summary>
	internal class Shop

  {
    // Builder uses a complex series of steps
    public void Construct(VehicleBuilder vehicleBuilder)
    {
      vehicleBuilder.BuildFrame();
      vehicleBuilder.BuildEngine();
      vehicleBuilder.BuildWheels();
      vehicleBuilder.BuildDoors();
    }
  }
}
