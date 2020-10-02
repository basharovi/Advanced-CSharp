using System;

namespace Reflection.Categories
{
    public class Charger : ICategory
    {
        public DateTime ManufacturedDate { get; set; } = DateTime.Now;

        public void PrintMe()
        {
            Console.WriteLine("This is Charger");
        }
    }
}
