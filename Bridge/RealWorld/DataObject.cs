namespace GangOfFour.Bridge.RealWorld
{
	/// <summary>
	/// The 'Implementor' abstract class
	/// </summary>
	internal abstract class DataObject

	{
		public abstract void AddRecord(string name);

		public abstract void DeleteRecord(string name);

		public abstract void NextRecord();

		public abstract void PriorRecord();

		public abstract void ShowAllRecords();

		public abstract void ShowRecord();
	}
}