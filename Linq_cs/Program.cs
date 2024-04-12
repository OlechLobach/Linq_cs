using System;
using System.Linq;

namespace StringQueries
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cities = { "New York", "Los Angeles", "Chicago", "Houston", "Phoenix", "Philadelphia", "San Antonio" };

            PrintArray("All cities:", cities);

            int specifiedLength = 7;
            var specifiedLengthCities = cities.Where(city => city.Length == specifiedLength).ToArray();
            PrintArray($"Cities with name length equal to {specifiedLength}:", specifiedLengthCities);

            var startsWithA = cities.Where(city => city.StartsWith("A")).ToArray();
            PrintArray("Cities whose names start with the letter A:", startsWithA);

            var endsWithM = cities.Where(city => city.EndsWith("m")).ToArray();
            PrintArray("Cities whose names end with the letter M:", endsWithM);

            var startWithNEndWithK = cities.Where(city => city.StartsWith("N") && city.EndsWith("k")).ToArray();
            PrintArray("Cities whose names start with N and end with K:", startWithNEndWithK);

            var startWithNe = cities.Where(city => city.StartsWith("Ne")).OrderByDescending(city => city).ToArray();
            PrintArray("Cities whose names start with Ne (descending order):", startWithNe);

            Console.ReadLine();
        }

        static void PrintArray(string title, string[] array)
        {
            Console.WriteLine(title);
            foreach (var city in array)
            {
                Console.Write(city + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}

