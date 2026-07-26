using System;

namespace Day5.OOPConcepts.Task113a.Abstracts
{
	public abstract class Employee
	{
		public string Name { get; set; }
		public decimal Salary { get; set; }

		public Employee(string name, decimal salary)
		{
			Name = name;
			Salary = salary;
        }

		public abstract void CalculateSalary();
    }
}
