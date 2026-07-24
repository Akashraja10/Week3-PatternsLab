using Day3.RepositoryPatterns.Repository.Interfaces;
using Day3.RepositoryPatterns.Repository.Models;

namespace Day3.RepositoryPatterns.Repository.Repositories
{
    public class CourseRepository : IRepository<Course>
    {
        private readonly List<Course> _courses = new();

        public void Add(Course course)
        {
            _courses.Add(course);
            Console.WriteLine($"Course '{course.CourseName}' added.");
        }

        public List<Course> GetAll()
        {
            return _courses;
        }

        public Course? GetById(int id)
        {
            return _courses.FirstOrDefault(c => c.Id == id);
        }

        public void Update(Course course)
        {
            Course? existingCourse = GetById(course.Id);
            if (existingCourse != null)
            {
                existingCourse.CourseName = course.CourseName;
                existingCourse.DurationInMonths = course.DurationInMonths;

                Console.WriteLine($"Course with ID {course.Id} updated successfully.");
            }
        }

        public void Delete(int id)
        {
            Course? course = GetById(id);

            if (course != null)
            {
                _courses.Remove(course);

                Console.WriteLine($"Course {course.CourseName} deleted.");
            }
        }
    }
}