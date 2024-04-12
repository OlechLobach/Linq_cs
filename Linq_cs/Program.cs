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

            Console.WriteLine("All Companies:");
            foreach (var company in companies)
            {
                Console.WriteLine($"{company.Name}, {company.FoundationDate}, {company.BusinessProfile}, {company.DirectorFullName}, {company.NumberOfEmployees}, {company.Address}");
            }
            Console.WriteLine();

            var foodCompanies = companies.Where(c => c.Name.Contains("Food")).ToList();
            PrintCompanies("Food Companies:", foodCompanies);

            var marketingCompanies = companies.Where(c => c.BusinessProfile == "Marketing").ToList();
            PrintCompanies("Marketing Companies:", marketingCompanies);

            var marketingOrITCompanies = companies.Where(c => c.BusinessProfile == "Marketing" || c.BusinessProfile == "IT").ToList();
            PrintCompanies("Marketing or IT Companies:", marketingOrITCompanies);

            var companiesWithMoreThan100Employees = companies.Where(c => c.NumberOfEmployees > 100).ToList();
            PrintCompanies("Companies with more than 100 employees:", companiesWithMoreThan100Employees);

            var companiesWith100To300Employees = companies.Where(c => c.NumberOfEmployees >= 100 && c.NumberOfEmployees <= 300).ToList();
            PrintCompanies("Companies with 100 to 300 employees:", companiesWith100To300Employees);

            var londonCompanies = companies.Where(c => c.Address == "London").ToList();
            PrintCompanies("Companies based in London:", londonCompanies);

            var companiesWithDirectorLastNameWhite = companies.Where(c => c.DirectorFullName.Split(' ').Last() == "White").ToList();
            PrintCompanies("Companies with director's last name White:", companiesWithDirectorLastNameWhite);

            var companiesFoundedMoreThanTwoYearsAgo = companies.Where(c => (DateTime.Now - c.FoundationDate).TotalDays > 2 * 365).ToList();
            PrintCompanies("Companies founded more than two years ago:", companiesFoundedMoreThanTwoYearsAgo);

            var companiesFounded123DaysAgo = companies.Where(c => (DateTime.Now - c.FoundationDate).TotalDays == 123).ToList();
            PrintCompanies("Companies founded 123 days ago:", companiesFounded123DaysAgo);

            var companiesWithDirectorLastNameSmithAndCompanyNameContainsWhite = companies.Where(c => c.DirectorFullName.Split(' ').Last() == "Smith" && c.Name.Contains("White")).ToList();
            PrintCompanies("Companies with director's last name Smith and company name contains White:", companiesWithDirectorLastNameSmithAndCompanyNameContainsWhite);

            Console.ReadLine();
        }

        static void PrintCompanies(string title, List<Company> companies)
        {
            Console.WriteLine(title);
            foreach (var company in companies)
            {
                Console.WriteLine($"{company.Name}, {company.FoundationDate}, {company.BusinessProfile}, {company.DirectorFullName}, {company.NumberOfEmployees}, {company.Address}");
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
    }
}