namespace Day5.OOPConcepts.Task114.Models
{
    public class Employees : IComparable<Employees>
    {
        public int EmployeeId { get; set; }

        public string? Name { get; set; }

        public decimal Salary { get; set; }

        public int CompareTo(Employees? other)
        {
            if (other == null)
                return 1;

            return Salary.CompareTo(other.Salary);
        }
    }
}