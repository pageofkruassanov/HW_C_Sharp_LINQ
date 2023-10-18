using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;
using HW_C_Sharp_LINQ;

namespace CW16_C_Sharp
{
    internal class Program
    {    
        static void Main(string[] args)
        {
            // Task 1:
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 };

            // Pair numbers
            var pairNum = arr.Where(num => num % 2 == 0);
            foreach (var nums in pairNum)
            {
                Console.Write(nums + " ");
            }
            Console.Write("\n");

            // Unpair numbers:
            var unpairNum = arr.Where(num => num % 2 == 1);
            foreach (var nums in unpairNum)
            {
                Console.Write(nums + " ");
            }
            Console.Write("\n");

            // Numbers more than:
            var moreThan = arr.Where(num => num > 5);
            foreach (var nums in moreThan)
            {
                Console.Write(nums + " ");
            }
            Console.Write("\n");

            // Range numbers:
            var rangeNums = arr.Where(num => num > 0 && num < 4);
            foreach (var nums in rangeNums)
            {
                Console.Write(nums + " ");
            }
            Console.Write("\n");

            // Multi + sorted:
            var multSeven = arr.Where(num => num % 7 == 0).OrderBy(num => num);
            foreach (var nums in multSeven)
            {
                Console.Write(nums + " ");
            }
            Console.Write("\n");

            var multiEight = arr.Where(num => num % 8 == 0).OrderByDescending(num => num);
            foreach (var nums in multiEight)
            {
                Console.Write(nums + " ");
            }
            Console.Write("\n");
            Console.WriteLine("--------------------------------");

            // Task 2:

            string[] cities = new string[] { "Odessa", "Kiev", "Zhytomyr", "Rivne", "L'viv", "Kharkiv", "Luhans'k", "Krym", "Kotovsk", "Izmail", "Vinnytsa", "Korosten'", "Izyum", "Chernivitsi", "Kherson" };

            // Output all array:

            var selectedCities = from c in cities
                                 select c;

            Console.Write("All cities: ");

            foreach (var c in selectedCities)
            {
                Console.Write(c + ", ");
            }
            Console.Write("\n");

            // Output cities with range:

            int min = 3;
            int max = 5;

            selectedCities = from c in cities
                             where c.Length > min && c.Length < max
                             select c;

            Console.Write("Cities with range: ");

            foreach (var c in selectedCities)
            {
                Console.Write(c + ", ");
            }
            Console.Write("\n");

            // Output cities, where first letter - 'O'

            char letter = 'O';
            selectedCities = from c in cities
                             where c.ToUpper().StartsWith(Convert.ToString(letter))
                             select c;

            Console.Write("Cities, where first letter - 'O': ");
            
            foreach(var c in selectedCities)
            {
                Console.Write(c + ", ");
            }
            Console.Write("\n");

            // Output cities, where last letter - 'V'

            letter = 'V';
            selectedCities = from c in cities
                             where c.ToUpper().EndsWith(Convert.ToString(letter))
                             select c;

            Console.Write("Cities, where first letter - 'V': ");

            foreach (var c in selectedCities)
            {
                Console.Write(c + ", ");
            }
            Console.Write("\n");

            // Output cities, where first letter - 'K', last letter - 'V'

            string firstLetter = "K";
            string lastLetter = "V";

            selectedCities = from c in cities
                             where c.ToUpper().StartsWith(firstLetter) && c.ToUpper().EndsWith(lastLetter)
                             select c;

            Console.Write("Cities, where first letter - 'K', last letter - 'V': ");

            foreach (var c in selectedCities)
            {
                Console.Write(c + ", ");
            }
            Console.Write("\n");

            // Output cities, where first two letters - "Kh"

            string letters = "Kh";

            selectedCities = cities.Where(c => c.ToUpper().StartsWith(letters.ToUpper()));

            Console.Write("Cities, where first two letters - 'Kh': ");

            foreach (var c in selectedCities)
            {
                Console.Write(c + ", ");
            }
            Console.Write("\n");
            Console.WriteLine("----------------------------------");

            //Task 3:

            Student[] students = new Student[] { new Student("Pavlo", "Khasanov", 24, "ITStep"), new Student("Evgeniy", "Nechepyrenko", 28, "ITStep"), new Student("Oleksandr", "Elenok", 35, "ITStep"), new Student("Belyanskii", "Dmitro", 23, "ITStep") };

            // Show all students:
            var studList = from stud in students
                           select stud;

            Console.WriteLine("\nAll students: \n");
            foreach(var stud in studList)
            {
                Console.WriteLine(stud.ToString());
            }

            
            // Show students with name - Evgeniy

            studList = from stud in students
                           where stud.Name == "Evgeniy"
                           select stud;

            Console.WriteLine("\nWith name - Evgeniy: \n");
            foreach (var stud in studList)
            {
                Console.WriteLine(stud.ToString());
            }

            // Last name start with "Kh"
            string tempLetters = "Kh";

            studList = from stud in students
                       where stud.Surname.ToUpper().StartsWith(tempLetters.ToUpper())
                       select stud;

            Console.WriteLine("\nLast name start with 'Kh': \n");

            foreach(var stud in studList)
            {
                Console.WriteLine(stud.ToString());
            }

            // Age more than 24

            int minAge = 24;

            studList = from stud in students
                       where stud.Age > minAge
                       select stud;

            Console.WriteLine("\nAge more than 24: \n");

            foreach (var stud in studList)
            {
                Console.WriteLine(stud.ToString());
            }

            // Age less than 30 and more than 23
            minAge = 23;
            int maxAge = 30;

            studList = from stud in students
                       where stud.Age < maxAge && stud.Age > minAge
                       select stud;

            Console.WriteLine($"\nAge less than {maxAge} and more than {minAge}\n");

            foreach (var stud in studList)
            {
                Console.WriteLine(stud.ToString());
            }

            // Some sort by Age

            studList = from stud in students
                       orderby stud.Age
                       select stud;

            Console.WriteLine("\n Sort by Age: \n");

            foreach (var stud in studList)
            {
                Console.WriteLine(stud.ToString());
            }

            Console.ReadLine();

        }
    }
}
