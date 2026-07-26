using System;
using Day5.OOPConcepts.Task113a.Abstracts;

namespace Day5.OOPConcepts.Task113a.Models
{
	public class Developer : Employee
    {
		public Developer(string name, decimal salary) : base(name, salary)
		{
		}
		public override void CalculateSalary()
		{
            Console.WriteLine($"{Name}'s Salary : {Salary}");
        }
    }
}
