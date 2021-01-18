namespace GangOfFour.Memento.RealWorld
{
	/// <summary>
	/// The 'Memento' class
	/// </summary>
	internal class Memento

	{
		// Constructor
		public Memento(string name, string phone, double budget)
		{
			this.Name = name;
			this.Phone = phone;
			this.Budget = budget;
		}

		// Gets or sets budget
		public double Budget { get; set; }

		// Gets or sets name
		public string Name { get; set; }

		// Gets or set phone
		public string Phone { get; set; }
	}
}