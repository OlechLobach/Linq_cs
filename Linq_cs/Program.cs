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
                new Company { Name = "Food Express", FoundationDate = new DateTime(2000, 5, 10), BusinessProfile = "Food", DirectorFullName = "John Smith", NumberOfEmployees = 120, Address = "London" },
                new Company { Name = "Tech Solutions", FoundationDate = new DateTime(2010, 8, 20), BusinessProfile = "IT", DirectorFullName = "Alice White", NumberOfEmployees = 250, Address = "New York" },
                new Company { Name = "Marketing Pro", FoundationDate = new DateTime(2015, 3, 15), BusinessProfile = "Marketing", DirectorFullName = "Bob Johnson", NumberOfEmployees = 80, Address = "London" },
                new Company { Name = "HealthCare Inc.", FoundationDate = new DateTime(2005, 11, 5), BusinessProfile = "Health", DirectorFullName = "Jane Doe", NumberOfEmployees = 300, Address = "Chicago" }
            };

            var allCompanies = companies;
            Console.WriteLine("All companies:");
            foreach (var company in allCompanies)
            {
                Console.WriteLine($"{company.Name}, {company.BusinessProfile}, {company.NumberOfEmployees} employees");
            }

            var foodCompanies = companies.Where(c => c.Name.Contains("Food")).ToList();
            Console.WriteLine("\nFood companies:");
            foreach (var company in foodCompanies)
            {
                Console.WriteLine($"{company.Name}, {company.BusinessProfile}");
            }

            var marketingCompanies = companies.Where(c => c.BusinessProfile == "Marketing").ToList();
            Console.WriteLine("\nMarketing companies:");
            foreach (var company in marketingCompanies)
            {
                Console.WriteLine($"{company.Name}, {company.BusinessProfile}");
            }

            var marketingOrITCompanies = companies.Where(c => c.BusinessProfile == "Marketing" || c.BusinessProfile == "IT").ToList();
            Console.WriteLine("\nMarketing or IT companies:");
            foreach (var company in marketingOrITCompanies)
            {
                Console.WriteLine($"{company.Name}, {company.BusinessProfile}");
            }

            var companiesWithMoreThan100Employees = companies.Where(c => c.NumberOfEmployees > 100).ToList();
            Console.WriteLine("\nCompanies with more than 100 employees:");
            foreach (var company in companiesWithMoreThan100Employees)
            {
                Console.WriteLine($"{company.Name}, {company.NumberOfEmployees} employees");
            }

            var companiesWith100To300Employees = companies.Where(c => c.NumberOfEmployees >= 100 && c.NumberOfEmployees <= 300).ToList();
            Console.WriteLine("\nCompanies with 100 to 300 employees:");
            foreach (var company in companiesWith100To300Employees)
            {
                Console.WriteLine($"{company.Name}, {company.NumberOfEmployees} employees");
            }

            var londonCompanies = companies.Where(c => c.Address == "London").ToList();
            Console.WriteLine("\nCompanies based in London:");
            foreach (var company in londonCompanies)
            {
                Console.WriteLine($"{company.Name}, {company.Address}");
            }

            var companiesWithDirectorLastNameWhite = companies.Where(c => c.DirectorFullName.Split(' ').Last() == "White").ToList();
            Console.WriteLine("\nCompanies with a director's last name White:");
            foreach (var company in companiesWithDirectorLastNameWhite)
            {
                Console.WriteLine($"{company.Name}, {company.DirectorFullName}");
            }

            var companiesFoundedMoreThanTwoYearsAgo = companies.Where(c => (DateTime.Now - c.FoundationDate).TotalDays > 730).ToList();
            Console.WriteLine("\nCompanies founded more than two years ago:");
            foreach (var company in companiesFoundedMoreThanTwoYearsAgo)
            {
                Console.WriteLine($"{company.Name}, founded on {company.FoundationDate}");
            }

            var companiesFounded123DaysAgo = companies.Where(c => (DateTime.Now - c.FoundationDate).TotalDays == 123).ToList();
            Console.WriteLine("\nCompanies founded 123 days ago:");
            foreach (var company in companiesFounded123DaysAgo)
            {
                Console.WriteLine($"{company.Name}, founded on {company.FoundationDate}");
            }

            var companiesWithDirectorLastNameSmithAndCompanyNameContainsWhite = companies.Where(c => c.DirectorFullName.Split(' ').Last() == "Smith" && c.Name.Contains("White")).ToList();
            Console.WriteLine("\nCompanies with director's last name Smith and company name contains White:");
            foreach (var company in companiesWithDirectorLastNameSmithAndCompanyNameContainsWhite)
            {
                Console.WriteLine($"{company.Name}, {company.DirectorFullName}");
            }

            Console.ReadLine();
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
    }
}