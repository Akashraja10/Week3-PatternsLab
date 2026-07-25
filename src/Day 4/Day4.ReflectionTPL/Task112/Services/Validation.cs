using System.Reflection;
using Day4.ReflectionTPL.Task112.Attributes;

namespace Day4.ReflectionTPL.Task112.Services
{
    public class Validation
    {
        public void Validate(object obj)
        {
            Type type = obj.GetType();

            Console.WriteLine($"Validating {type.Name}\n");

            PropertyInfo[] properties = type.GetProperties();

            foreach (PropertyInfo property in properties)
            {
                // Check if the property has MaxLengthNoAttribute
                MaxLengthNoAttribute? attribute =
                    property.GetCustomAttribute<MaxLengthNoAttribute>();

                // If no attribute, skip this property
                if (attribute == null)
                    continue;

                string? value = property.GetValue(obj)?.ToString();

                if (value != null && value.Length > attribute.Length)
                {
                    Console.WriteLine($"{property.Name} is INVALID.");
                    Console.WriteLine($"Maximum Length : {attribute.Length}");
                    Console.WriteLine($"Actual Length  : {value.Length}\n");
                }
                else
                {
                    Console.WriteLine($"{property.Name} is VALID.");
                }
            }
        }
    }
}