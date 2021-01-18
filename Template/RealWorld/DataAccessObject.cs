using System.Data;

namespace GangOfFour.Template.RealWorld
{
	/// <summary>
	/// The 'AbstractClass' abstract class
	/// </summary>
	internal abstract class DataAccessObject

	{
		protected string connectionString;
		protected DataSet dataSet;

		public virtual void Connect()
		{
			// Make sure mdb is available to app

			connectionString =
				"provider=Microsoft.JET.OLEDB.4.0; " +
				"data source=..\\..\\..\\db1.mdb";
		}

		public virtual void Disconnect()
		{
			connectionString = "";
		}

		public abstract void Process();

		public void Run()
		{
			Connect();
			Select();
			Process();
			Disconnect();
		}

		public abstract void Select();

		// The 'Template Method'
	}
}