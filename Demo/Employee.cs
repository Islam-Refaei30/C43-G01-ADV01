using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
	internal class Employee : IComparable<Employee>
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

		public override bool Equals(object? obj)
		{
			Employee? other = (Employee?) obj; //Explicit casting   unsafe casting
			if (other == null) return false;
			return this.ID == other.ID && this.Name == other.Name && this.Salary == other.Salary;
		}

		public override int GetHashCode()
		{
			return HashCode.Combine(this.ID.GetHashCode(), this.Name?.GetHashCode() ?? default(int), this.Salary.GetHashCode());
			//int HashValue = 7;
			//HashValue = (HashValue *17) ^ this.ID.GetHashCode();
			//HashValue = (HashValue * 17) ^ this.Name?.GetHashCode() ?? default(int);
			//HashValue = (HashValue *17) ^ this.Salary.GetHashCode();
			//return HashValue;

			//return this.ID.GetHashCode() ^ this.Name?.GetHashCode() ?? default(int) ^ this.Salary.GetHashCode();
		}

		public int CompareTo(object? obj)
		{
			Employee? other = (Employee?)obj; // Explicit casting Unsafe Casting

			if (this.Salary > other?.Salary) // compare to object based on salary
				return 1;

			else if (this.Salary < other?.Salary)
				return -1;

			else return 0;
			
		}

		public int CompareTo(Employee? other)
		{

			if (this.Salary > other?.Salary) // compare to object based on salary
				return 1;

			else if (this.Salary < other?.Salary)
				return -1;

			else return 0;
		}
	}
}
