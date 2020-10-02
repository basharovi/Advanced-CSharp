using System;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            var types = Assembly.GetExecutingAssembly().GetTypes();

            foreach (var type in types)
            {
                var iCategory = type.GetInterface("ICategory");
                if(iCategory is null)
                    continue;

                Console.WriteLine(" {0} ", type.Name);
            }
            
        }
    }
}
