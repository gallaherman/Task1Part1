using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_Part_3
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintTheNumber();
            Console.WriteLine();
            DisplayCMultiplesInRange();
            Console.WriteLine();
            ThreeDigitNumber();
        }

        static void PrintTheNumber()
        {
            int number = 201;

            while (number%17 != 0)
            {
                number++;
            }
            Console.WriteLine($"The minimum number greater than 200 and divisible by 17 is {number}");
        }

        static void DisplayCMultiplesInRange()
        {
            int a, b, c;

            Console.WriteLine("Enter the start number of the range (a)");
            while (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Invalid input. Enter the integer for the start of the range");
            }

            Console.WriteLine("Enter the end number of the range (b)");
            while (!int.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Invalid input. Enter the integer for the end of the range");
            }

            Console.WriteLine("Enter the number for check of multiplies of c (c)");
            while (!int.TryParse(Console.ReadLine(), out c)|| c == 0)
            {
                Console.WriteLine("Invalid input. Enter non zero value of c");
            }

            Console.WriteLine($"Multiplies of {c} for range from {a} to {b}");
            for (int i = a; i <= b; i++)
            {
                if (i % c == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void ThreeDigitNumber()
        {
            int number;

            while (true)
            {
                Console.WriteLine("Enter the three digit number");
                string input = Console.ReadLine();
                if (int.TryParse(input, out number) && number >= 100 && number <= 999)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Enter the three digit number");
                }
            }

            Console.WriteLine($"The number of units: {GetNumberUnits(number)}");
            Console.WriteLine($"The number of tens: {GetNumberTens(number)}");
            Console.WriteLine($"The sum of digits: {GetSumDigits(number)}");
            Console.WriteLine($"The product of digits: {GetProductDigits(number)}");
            Console.WriteLine($"The number from right to left: {GetReversedNumber(number)}");
            Console.WriteLine($"The number from swaping first and second digit: {GetSwapFirstSecond(number)}");
            Console.WriteLine($"All digits are the same: {AllDigitsSame(number)}");
            Console.WriteLine($"Is any digits are the same: {AnyDigitsSame(number)}");
        }
        static int GetNumberUnits(int number)
        {
            return number % 10;
        }

        static int GetNumberTens(int number)
        {
            return (number / 10) % 10;
        }

        static int GetNumberHundreds(int number)
        {
            return (number / 100);
        }

        static int GetSumDigits(int number)
        {
            int units = GetNumberUnits(number);
            int tens = GetNumberTens(number);
            int hundreds = GetNumberHundreds(number);
            return units + tens + hundreds;
        }

        static int GetProductDigits(int number)
        {
            int units = GetNumberUnits(number);
            int tens = GetNumberTens(number);
            int hundreds = GetNumberHundreds(number);
            return units * tens * hundreds;
        }

        static int GetReversedNumber(int number)
        {
            int units = GetNumberUnits(number);
            int tens = GetNumberTens(number);
            int hundreds = GetNumberHundreds(number);
            return units * 100 + tens * 10 + hundreds;
        }

        static int GetSwapFirstSecond(int number)
        {
            int units = GetNumberUnits(number);
            int tens = GetNumberTens(number);
            int hundreds = GetNumberHundreds(number);
            return tens * 100 + hundreds * 10 + units;
        }

        static bool AllDigitsSame(int number)
        {
            int units = GetNumberUnits(number);
            int tens = GetNumberTens(number);
            int hundreds = GetNumberHundreds(number);
            return units == tens && tens == hundreds;
        }

        static bool AnyDigitsSame(int number)
        {
            int units = GetNumberUnits(number);
            int tens = GetNumberTens(number);
            int hundreds = GetNumberHundreds(number);
            return units == tens || tens == hundreds || units == hundreds;
        }
    }
}
