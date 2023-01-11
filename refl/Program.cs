using System;
using System.Reflection;

namespace REFL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product(4)
            {
                Name = "fhj",
                salePrice = 454,


            };
            var type = product.GetType();
            foreach (var item in type.GetFields(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic))
            {
                if (item.Name == "_costPrice")
                {
                    item.SetValue(product, 100);
                }
                Console.WriteLine($"{item.Name} - {item.GetValue(product)}");
            }
            foreach (var item in type.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic))
            {
                Console.WriteLine($"{item.Name} - {item.GetValue(product)}");
            }
     
            foreach (var item in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic))
            {
                Console.WriteLine(item.Name);
            }
            var asemmblies = Assembly.GetExecutingAssembly();


            Console.WriteLine("All types");
            foreach (var item in asemmblies.GetTypes())
            {
                Console.WriteLine(item.Name + " - " + item.Namespace);
                foreach (var field in item.GetFields())
                {
                    Console.WriteLine("\t" + field.Name);
                }
            }
        }
    }
}
