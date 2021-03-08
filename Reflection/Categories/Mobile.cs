using System;

namespace Reflection.Categories
{
    public class Mobile : ICategory
    {
        private readonly DateTime warrentyExpirationDate = DateTime.Now.AddMonths(13);

        public void PrintMe()
        {
            Console.WriteLine("This is Mobile!");
        }
    }
}
