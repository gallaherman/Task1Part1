using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_Part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadFromConsoleAndWriteChars();
            Console.WriteLine();
            MultiplicateTable(7);
            Console.WriteLine();
            ForWildLoop();
            FillArrayWithRandom();
            PrintNumbersInFormA(5);
            Console.WriteLine();
            PrintNumbersInFormB(5);
            Console.WriteLine();
            PrintNumbersInFormC();
            Console.WriteLine();
            PrintNumbersInFormD();
        }

        static void ReadFromConsoleAndWriteChars()
        {
            Console.WriteLine("Enter the string:");

            string input = Console.ReadLine();

            if (input != null)
            {
                foreach (char c in input)
                {
                    Console.WriteLine(c);
                }
            }
            else
            {
                Console.WriteLine("you didnt enter anything.");
            }
        }
        static void MultiplicateTable(int n)
        {
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine($"{i} * {n} = {i * n}");
            }
        }

        static void ForWildLoop()
        {
            int i = 1;
            while (i < 11)
            {
                Console.WriteLine(i);
                i++;
            }

        }

        static void FillArrayWithRandom()
        {
            Random random = new Random();
            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 26);
            }

            foreach (int i in array)
            {
                Console.WriteLine(i + " ");
            }

            int sum = 0;
            bool found22 = false;
            for (int i = 0; i <array.Length; i++)
            {
                if (array[i] == 22)
                {
                    found22 = true;
                    break;
                }
                sum += array[i];
            }
            if (found22)
            {
                Console.WriteLine("Sum of all digits untill 22 is: " + sum);
            }
            else
            {
                Console.WriteLine("22 wasnt found. Sum of all digits: " + sum);
            }
        }

        static void PrintNumbersInFormA(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(n + " ");
                }
                Console.WriteLine();
            }
        }

        static void PrintNumbersInFormB(int n)
        {
            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(1 + " ");
                }
                Console.WriteLine();
            }
        }

        static void PrintNumbersInFormC()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i * 10 + " ");
                }
                Console.WriteLine();
            }
        }

        static void PrintNumbersInFormD()
        {
            int start = 5;
            int increment = 5;
            int rows = 5;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < rows - i; j++)
                {
                    Console.Write((start + i * increment) + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
