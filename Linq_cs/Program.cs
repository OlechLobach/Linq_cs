using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyQueries
{
    class Program
    {
        static void Main(string[] args)
        {
            var companies = new List<Company>
            {
                new Company
                {
                    Name = "Food Express",
                    FoundationDate = new DateTime(2000, 5, 10),
                    BusinessProfile = "Food",
                    DirectorFullName = "John Smith",
                    NumberOfEmployees = 120,
                    Address = "London",
                    Employees = new List<Employee>
                    {
                        new Employee { FullName = "Alice Johnson", Position = "Manager", ContactNumber = "23456789", Email = "alice@example.com", Salary = 5000 },
                        new Employee { FullName = "Bob White", Position = "Developer", ContactNumber = "23987654", Email = "bob@example.com", Salary = 4000 }
                    }
                },
                new Company
                {
                    Name = "Tech Solutions",
                    FoundationDate = new DateTime(2010, 8, 20),
                    BusinessProfile = "IT",
                    DirectorFullName = "Alice White",
                    NumberOfEmployees = 250,
                    Address = "New York",
                    Employees = new List<Employee>
                    {
                        new Employee { FullName = "Charlie Brown", Position = "Manager", ContactNumber = "23451234", Email = "charlie@example.com", Salary = 5500 },
                        new Employee { FullName = "Diana Green", Position = "Developer", ContactNumber = "23567890", Email = "diana@example.com", Salary = 4500 }
                    }
                }
            };

            var foodExpressEmployees = companies.FirstOrDefault(c => c.Name == "Food Express")?.Employees;
            PrintEmployees("Employees of Food Express:", foodExpressEmployees);

            var highSalaryEmployees = companies.SelectMany(c => c.Employees).Where(e => e.Salary > 5000).ToList();
            PrintEmployees("Employees with salary higher than 5000:", highSalaryEmployees);

            var managerEmployees = companies.SelectMany(c => c.Employees).Where(e => e.Position == "Manager").ToList();
            PrintEmployees("Employees with manager position:", managerEmployees);

            var phoneNumberStartingWith23 = companies.SelectMany(c => c.Employees).Where(e => e.ContactNumber.StartsWith("23")).ToList();
            PrintEmployees("Employees whose phone number starts with '23':", phoneNumberStartingWith23);

            var emailStartingWithDi = companies.SelectMany(c => c.Employees).Where(e => e.Email.StartsWith("di", StringComparison.OrdinalIgnoreCase)).ToList();
            PrintEmployees("Employees whose email begins with 'di':", emailStartingWithDi);

            var lionelEmployees = companies.SelectMany(c => c.Employees).Where(e => e.FullName == "Lionel").ToList();
            PrintEmployees("Employees whose name is Lionel:", lionelEmployees);

            Console.ReadLine();
        }

        static void PrintEmployees(string title, List<Employee> employees)
        {
            Console.WriteLine(title);
            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.FullName}, {employee.Position}, {employee.ContactNumber}, {employee.Email}, {employee.Salary}");
            }
            Console.WriteLine();
        }
    }

    public class Company
    {
        public string Name { get; set; }
        public DateTime FoundationDate { get; set; }
        public string BusinessProfile { get; set; }
        public string DirectorFullName { get; set; }
        public int NumberOfEmployees { get; set; }
        public string Address { get; set; }
        public List<Employee> Employees { get; set; }
    }

    public class Employee
    {
        public string FullName { get; set; }
        public string Position { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public decimal Salary { get; set; }
    }
}