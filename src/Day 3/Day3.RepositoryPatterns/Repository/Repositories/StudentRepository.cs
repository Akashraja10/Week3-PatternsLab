using System;
using Day3.RepositoryPatterns.Repository.Interfaces;
using Day3.RepositoryPatterns.Repository.Models;

namespace Day3.RepositoryPatterns.Repository.Repositories
{
	public class StudentRepository : IRepository<Student>
    {
		private readonly List<Student> _students = new();

		public void Add(Student entity)
		{
			_students.Add(entity);
        }

		public List<Student> GetAll()
		{
			return _students;
        }

		public Student? GetById(int id)
		{
			return _students.FirstOrDefault(s => s.Id == id);
        }

		public void Update(Student entity)
		{
			Student? existingStudent = GetById(entity.Id);
			if (existingStudent != null)
			{
				existingStudent.Name = entity.Name;
				existingStudent.Age = entity.Age;

				Console.WriteLine($"Student with ID {entity.Id} updated successfully.");
            }
		}

		public void Delete(int id)
		{
			Student? student = GetById(id);
			if (student != null)
			{
				_students.Remove(student);
				Console.WriteLine($"Student with ID {id} deleted");
			}
		}
	}
}
