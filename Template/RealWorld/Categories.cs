﻿using System;
using System.Data;
using System.Data.OleDb;

namespace GangOfFour.Template.RealWorld
{
	/// <summary>
	/// A 'ConcreteClass' class
	/// </summary>
	internal class Categories : DataAccessObject

	{
		public override void Process()
		{
			Console.WriteLine("Categories ---- ");

			DataTable dataTable = dataSet.Tables["Categories"];
			foreach (DataRow row in dataTable.Rows)
			{
				Console.WriteLine(row["CategoryName"]);
			}
			Console.WriteLine();
		}

		public override void Select()
		{
			string sql = "select CategoryName from Categories";
			OleDbDataAdapter dataAdapter = new OleDbDataAdapter(
				sql, connectionString);

			dataSet = new DataSet();
			dataAdapter.Fill(dataSet, "Categories");
		}
	}
}