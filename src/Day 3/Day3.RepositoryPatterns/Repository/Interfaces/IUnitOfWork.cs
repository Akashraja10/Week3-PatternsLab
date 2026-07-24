using Day3.RepositoryPatterns.Repository.Repositories;

namespace Day3.RepositoryPatterns.Repository.Interfaces
{
	public interface IUnitOfWork
	{
		StudentRepository Students { get; }

		CourseRepository Courses { get; }

		void Save();
	}
}