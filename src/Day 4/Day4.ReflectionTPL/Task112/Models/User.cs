using Day4.ReflectionTPL.Task112.Attributes;

namespace Day4.ReflectionTPL.Task112.Models
{
    public class User
    {
        [MaxLengthNo(10)]
        public string? Name { get; set; }

        [MaxLengthNo(30)]
        public string? City { get; set; }
    }
}