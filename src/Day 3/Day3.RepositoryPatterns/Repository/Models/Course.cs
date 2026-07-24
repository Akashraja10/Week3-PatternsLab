using System;

namespace Day3.RepositoryPatterns.Repository.Models
{
	public class Course
	{
		public int Id { get; set; }
        public string? CourseName { get; set; }
        public int DurationInMonths { get; set; }
    }
}
