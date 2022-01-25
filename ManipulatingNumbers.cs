using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class ManipulatingNumbers
    {
        public static void Main(string[] args)
        {
            IntegerMath();
            OrderOfOperators();
            PrecisionAndLimits();
            DoubleType();
            DecimalType();
            AreaOfCircle();


        }

        public static void IntegerMath()
        {
            int a = 18;
            int b = 6;
            int c = a + b;
            int d = a * b;
            int e = a - b;
            int f = a / b;
            Console.WriteLine($"Sum of {a} and {b} is {c}");
            Console.WriteLine($"Multiplication of {a} and {b} is {d}");
            Console.WriteLine($"Subtraction of {a} and {b} is {e}");
            Console.WriteLine($"Division of {a} and {b} is {f}");

        }

        public static void OrderOfOperators()
        {
            int a = 5;
            int b = 4;
            int c = 2;
            int d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
            Console.WriteLine(d);
        }

        public static void PrecisionAndLimits()
        {
            int a = 7;
            int b = 4;
            int c = 3;
            int d = (a + b) / c;
            int e = (a + b) % c;
            Console.WriteLine($"quotient: {d}");
            Console.WriteLine($"remainder: {e}");
            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} to {max}");
            int what = max + 3;
            Console.WriteLine($"An example of overflow: {what}");
        }

        public static void DoubleType()
        {
            double a = 19;
            double b = 23;
            double c = 8;
            double d = (a + b) / c;
            Console.WriteLine(d);
            double max = double.MaxValue;
            double min = double.MinValue;
            Console.WriteLine($"The range of double is {min} to {max}");
            double third = 1.0 / 3.0;
            Console.WriteLine(third);
        }

        public static void DecimalType()
        {
            decimal min = decimal.MinValue;
            decimal max = decimal.MaxValue;
            Console.WriteLine($"The range of the decimal type is {min} to {max}");
            double a = 1.0;
            double b = 3.0;
            Console.WriteLine(a / b);

            decimal c = 1.0M;
            decimal d = 3.0M;
            Console.WriteLine(c / d);
        }

        public static void AreaOfCircle()
        {
            double r = 2.50;
            double area = Math.PI * r * r;
            Console.WriteLine($"Area of circle is {area}");
        }
    }
}
