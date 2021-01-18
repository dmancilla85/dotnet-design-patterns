namespace GangOfFour.Adapter.RealWorld
{
	/// <summary>
	/// The 'Adaptee' class
	/// </summary>
	internal class ChemicalDatabank

	{
		// The databank 'legacy API'
		public float GetCriticalPoint(string compound, string point)
		{
			// Melting Point
			if (point == "M")
			{
				return (compound.ToLower()) switch
				{
					"water" => 0.0f,
					"benzene" => 5.5f,
					"ethanol" => -114.1f,
					_ => 0f,
				};
			}
			// Boiling Point
			else

			{
				return (compound.ToLower()) switch
				{
					"water" => 100.0f,
					"benzene" => 80.1f,
					"ethanol" => 78.3f,
					_ => 0f,
				};
			}
		}

		public string GetMolecularStructure(string compound)
		{
			switch (compound.ToLower())
			{
				case "water": return "H20";
				case "benzene": return "C6H6";
				case "ethanol": return "C2H5OH";
				default: return "";
			}
		}

		public double GetMolecularWeight(string compound)
		{
			switch (compound.ToLower())
			{
				case "water": return 18.015;
				case "benzene": return 78.1134;
				case "ethanol": return 46.0688;
				default: return 0d;
			}
		}
	}
}