using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Division
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter numerator:");
            int numerator = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter denominator:");
            int denominator = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The result of integer division is {numerator/denominator} and remainder is {numerator%denominator}");
            Console.WriteLine($"The result of Floating point division is {(double)numerator / denominator}");
            Console.WriteLine($"The result of Mixed Fraction division is {numerator / denominator} {numerator % denominator}/{denominator}");
        }
    }
}
