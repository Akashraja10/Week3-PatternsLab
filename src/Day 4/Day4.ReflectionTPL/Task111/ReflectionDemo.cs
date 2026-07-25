using System.Reflection;

namespace Day4.ReflectionTPL.Task111
{
    public class ReflectionDemo
    {
        public void Run()
        {
            Type type = typeof(Invoice);
            Console.WriteLine("===== Reflection Demo =====");
            Console.WriteLine($"Class Name : {type.Name}");

            Console.WriteLine("\nProperties:");
            PropertyInfo[] properties = type.GetProperties();

            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine($"{property.Name} ({property.PropertyType.Name})");
            }

            Console.WriteLine("\nMethods:");
            MethodInfo[] methods = type.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.Name);
            }

            Console.WriteLine("\nConstructors:");
            ConstructorInfo[] constructors = type.GetConstructors();

            foreach (ConstructorInfo constructor in constructors)
            {
                ParameterInfo[] parameters = constructor.GetParameters();

                string parameterList = string.Join(",",
                    parameters.Select(p => $"{p.ParameterType.Name} {p.Name}"));

                Console.WriteLine(parameterList);
            }

            // Create object dynamically
            object invoice = Activator.CreateInstance(type)!;

            Console.WriteLine("\nObject Created Successfully!");

            PropertyInfo invoiceId = type.GetProperty("InvoiceId")!;
            invoiceId.SetValue(invoice, 101);

            PropertyInfo customer = type.GetProperty("CustomerName")!;
            customer.SetValue(invoice, "Ahash");

            PropertyInfo amount = type.GetProperty("Amount")!;
            amount.SetValue(invoice, 5000m);

            MethodInfo printMethod = type.GetMethod("PrintInvoice")!;

            printMethod.Invoke(invoice, null);
        }
    }
}