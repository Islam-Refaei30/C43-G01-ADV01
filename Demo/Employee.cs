using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
	internal class Employee
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public decimal? Salary { get; set; }

		public Employee(int ID, string Name, decimal? Salary)
		{
			this.ID = ID;
			this.Name = Name;	
			this.Salary = Salary;
		}

		public override string ToString()
		{
			return $"ID = {ID}, Name is {Name}, Salary = {Salary}";
		}
	}
}
