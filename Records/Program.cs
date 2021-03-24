using System;

namespace Records
{
    class Program
    {
        record Student(string FirstName, string LastName, int Age);

        static void Main(string[] args)
        {

            var aStudent = new Student("Bashar", "Ovi", 23);

            Console.WriteLine($"{aStudent.FirstName} \n" +
                $"{aStudent.LastName} \n{aStudent.Age}");
        }
    }
}
