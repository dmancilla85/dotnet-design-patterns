using System;
using System.Collections.Generic;

namespace GangOfFour.Visitor.RealWorld
{
	/// <summary>
	/// The 'ObjectStructure' class
	/// </summary>
	internal class Employees

	{
		private readonly List<Employee> _employees = new List<Employee>();

		public void Accept(IVisitor visitor)
		{
			foreach (Employee e in _employees)
			{
				e.Accept(visitor);
			}
			Console.WriteLine();
		}

		public void Attach(Employee employee)
		{
			_employees.Add(employee);
		}

		public void Detach(Employee employee)
		{
			_employees.Remove(employee);
		}
	}
}