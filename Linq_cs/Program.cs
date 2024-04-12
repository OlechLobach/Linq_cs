using System;
using System.Collections.Generic;
using System.Linq;

namespace IntegerQueries
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 14, 16, 18, 21, 24, 28, 32, 36 };

            PrintArray("All integers:", numbers);

            var evenNumbers = numbers.Where(n => n % 2 == 0).ToArray();
            PrintArray("Even integers:", evenNumbers);

            var oddNumbers = numbers.Where(n => n % 2 != 0).ToArray();
            PrintArray("Odd integers:", oddNumbers);

            int specifiedValue = 10;
            var greaterThanSpecified = numbers.Where(n => n > specifiedValue).ToArray();
            PrintArray($"Numbers greater than {specifiedValue}:", greaterThanSpecified);

            int startRange = 5, endRange = 15;
            var numbersInRange = numbers.Where(n => n >= startRange && n <= endRange).ToArray();
            PrintArray($"Numbers in range {startRange} - {endRange}:", numbersInRange);

            var multiplesOfSeven = numbers.Where(n => n % 7 == 0).OrderBy(n => n).ToArray();
            PrintArray("Multiples of seven (ascending):", multiplesOfSeven);

            var multiplesOfEight = numbers.Where(n => n % 8 == 0).OrderByDescending(n => n).ToArray();
            PrintArray("Multiples of eight (descending):", multiplesOfEight);

            Console.ReadLine();
        }

        static void PrintArray(string title, int[] array)
        {
            Console.WriteLine(title);
            foreach (var number in array)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}