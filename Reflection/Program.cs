using System;
using System.Reflection;
using Reflection.Categories;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            var types = Assembly.GetExecutingAssembly().GetTypes();

            Console.WriteLine("Select a category \n");

            foreach (var type in types)
            {
                var iCategory = type.GetInterface("ICategory");
                if(iCategory is null)
                    continue;

                Console.WriteLine("  {0} ", type.Name);
            }

            var userInput =  Console.ReadLine();
            
            var category = new CategoryFactory().CreteCategory(userInput);
            category?.PrintMe();
        }
    }
}
