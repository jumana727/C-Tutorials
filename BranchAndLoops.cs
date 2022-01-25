using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class BranchesAndLoops
    {
        public static void Main(string[] args)
        {
            IfStatement();
            IfElse();
            WhileLoop();
            DoWhileLoop();
            ForLoop();
            NestedFor();
            BranchesAndLoop();
        }

        public static void IfStatement()
        {
            int a = 5;
            int b = 6;
            if (a + b > 10)
                Console.WriteLine("The answer is greater than 10.");
        }
        public static void IfElse()
        {
            int a = 5;
            int b = 3;
            int c = 4;
            if ((a + b + c > 10) || (a == b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("Or the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("And the first number is not equal to the second");
            }
        }

        public static void WhileLoop()
        {
            int counter = 0;
            while (counter < 5)
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            }
        }

        public static void DoWhileLoop()
        {
            int counter = 0;
            do
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            } while (counter < 5);
        }

        public static void ForLoop()
        {
            for (int counter = 0; counter < 5; counter++)
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
            }
        }

        public static void NestedFor()
        {
            for (int row = 1; row < 6; row++)
            {
                for (char column = 'a'; column < 'd'; column++)
                {
                    Console.WriteLine($"The cell is ({row}, {column})");
                }
            }
        }

        public static void BranchesAndLoop()
        {
            int sum = 0;

            for (int i = 1; i <= 20; i++)
            {
                if (i % 3 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine($"The sum of 1 to 20 numbers which is divisible by 3 is {sum}");
        }
    }
}
