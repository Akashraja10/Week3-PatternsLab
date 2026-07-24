using Day3.RepositoryPatterns.Repository.Interfaces;
using Day3.RepositoryPatterns.Repository.Repositories;

namespace Day3.RepositoryPatterns.Repository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public StudentRepository Students { get; }

        public CourseRepository Courses { get; }

        public UnitOfWork()
        {
            Students = new StudentRepository();
            Courses = new CourseRepository();
        }

        public void Save()
        {
            Console.WriteLine("\nAll changes have been saved successfully.");
        }
    }
}