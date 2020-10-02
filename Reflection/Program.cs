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

            var input = "Reflection.Categories." + Console.ReadLine();
            var userSelection = Type.GetType(input);

            var constructorInfo = userSelection?.GetConstructor(new Type[]{ });
            var category = (ICategory)constructorInfo?.Invoke(new object[] { });

            category?.PrintMe();
        }
    }
}
