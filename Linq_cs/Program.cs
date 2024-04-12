using System;
using System.Linq;

namespace StudentQueries
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = {
                new Student { Name = "John", Surname = "Doe", Age = 20, Institution = "MIT" },
                new Student { Name = "Alice", Surname = "Brown", Age = 19, Institution = "Oxford" },
                new Student { Name = "Boris", Surname = "Smith", Age = 21, Institution = "Harvard" },
                new Student { Name = "Emily", Surname = "Brooks", Age = 22, Institution = "MIT" },
                new Student { Name = "Charlie", Surname = "Brooks", Age = 24, Institution = "Oxford" },
            };

            PrintArray("All students:", students);

            var borisStudents = students.Where(student => student.Name == "Boris").ToArray();
            PrintArray("Students with the name Boris:", borisStudents);

            var broSurnameStudents = students.Where(student => student.Surname.StartsWith("Bro")).ToArray();
            PrintArray("Students whose surname starts with Bro:", broSurnameStudents);

            var over19Students = students.Where(student => student.Age > 19).ToArray();
            PrintArray("Students who are over 19:", over19Students);

            var between20And23Students = students.Where(student => student.Age > 20 && student.Age < 23).ToArray();
            PrintArray("Students who are over 20 and under 23:", between20And23Students);

            var mitStudents = students.Where(student => student.Institution == "MIT").ToArray();
            PrintArray("Students who study at MIT:", mitStudents);

            var oxfordOver18Students = students.Where(student => student.Institution == "Oxford" && student.Age > 18)
                                                .OrderByDescending(student => student.Age).ToArray();
            PrintArray("Students who study at Oxford, are over 18, sorted by age in descending order:", oxfordOver18Students);

            Console.ReadLine();
        }

        static void PrintArray(string title, Student[] array)
        {
            Console.WriteLine(title);
            foreach (var student in array)
            {
                Console.WriteLine($"Name: {student.Name}, Surname: {student.Surname}, Age: {student.Age}, Institution: {student.Institution}");
            }
            Console.WriteLine();
        }
    }

    class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Institution { get; set; }
    }
}