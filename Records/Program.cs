using System;

namespace Records
{

    public record Student(string FirstName, string LastName, int Age) : Person(Age);

    public record Person(int Age);
    

    class Program
    {

        static void Main(string[] args)
        {

            var aStudent = new Student("Bashar", "Ovi", 23);

            Console.WriteLine($"{aStudent.FirstName} \n" +
                $"{aStudent.LastName} \n{aStudent.Age}");
        }
    }
}
