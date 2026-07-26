using Day5.OOPConcepts.Task114.Models;

namespace Day5.OOPConcepts.Task114.Comparers
{
    public class EmployeeNameComparer : IComparer<Employees>
    {
        public int Compare(Employees? firstEmployee,
                           Employees? secondEmployee)
        {
            if (firstEmployee == null || secondEmployee == null)
                return 0;

            return firstEmployee.Name.CompareTo(secondEmployee.Name);
        }
    }
}