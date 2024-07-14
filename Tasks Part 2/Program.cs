using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculateTheFunction();
            Console.WriteLine();
            SwapTheValues();
            Console.WriteLine();
            CompareTheShapes();
            Console.WriteLine();
            CheckTheNumber();
            Console.WriteLine();
            NumberTheDayOfTheWeek();
        }

        static void CalculateTheFunction()
        {
            double a;

            while (true)
            {
                Console.WriteLine("Enter the value of 'a' in function x = 12a^2 + 7a + 12 :");
                string input = Console.ReadLine();

                if(double.TryParse(input, out a))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid value. Please enter a valid value.");
                }
            }
            double x = 12 * a * a + 7 * a + 12;
            Console.WriteLine($"For a = {a}, x = {x}");
        }
        static void SwapTheValues()
        {
            int a = 3;
            int b = 6;
            int temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"a = {a}, b = {b}");
        }

        static void CompareTheShapes()
        {
            double radius, side;
            while (true)
            {
                Console.WriteLine("Enter the raduis of the circle");
                string input = Console.ReadLine();
                if (double.TryParse(input, out radius) && radius > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid number. The value hould be positive");
                }
            }
            while (true)
            {
                Console.WriteLine("Enter the side of the square");
                string input = Console.ReadLine();
                if (double.TryParse(input, out side) && side > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid number. The value hould be positive");
                }
            }
            double areaCircle = Math.PI * radius * radius;
            double areaSquare = side * side;

            Console.WriteLine($"\nArea of the circle : {areaCircle}");
            Console.WriteLine($"Area of the square : {areaSquare}");
            if (areaCircle > areaSquare)
            {
                Console.WriteLine("The circle has more area");
            }
            else if (areaCircle < areaSquare)
            {
                Console.WriteLine("The square has more area");
            }
            else
            {
                Console.WriteLine("Areas are equal");
            }
        }

        static void CheckTheNumber()
        {
            double number;

            while (true)
            {
                Console.Write("Enter a number: ");
                string input = Console.ReadLine();

                if (double.TryParse(input, out number))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }

            if (number > -5 && number < 3)
            {
                Console.WriteLine($"The number {number} belongs to the interval (-5, 3).");
            }
            else
            {
                Console.WriteLine($"The number {number} does not belong to the interval (-5, 3).");
            }
        }
        static void NumberTheDayOfTheWeek()
        {
            int dayNumber;
            
            while(true)
            {
                Console.Write("Enter the ordinal number of the day of the week: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out dayNumber) && dayNumber >= 1 && dayNumber <=7)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid number. The value should be from 1 to 7");
                }
            }
            string dayName = "";
            switch (dayNumber)
            {
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                case 7:
                    dayName = "Sunday";
                    break;
                default:
                    dayName = "Invalid day";
                    break;
            }

            Console.WriteLine($"The day number {dayNumber} corresponds to {dayName}.");
        }
    }
}
