using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class StringOperations
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string s1 = Console.ReadLine();
            Console.WriteLine($"length of string {s1} is {s1.Length}");
            Console.WriteLine("Enter a statement:");
            string s = Console.ReadLine();
            if (s[s.Length - 1] == '.')
            {
                Console.WriteLine("It is a declarative Statement");
            }
            else if (s[s.Length - 1] == '?')
            {
                Console.WriteLine("It is an Interrogative Statement");
            }
            else if (s[s.Length - 1] == '!')
            {
                Console.WriteLine("It is an Exclamatory Statement");
            }
            else
            {
                Console.WriteLine("None");
            }

            Console.WriteLine("Enter Your name");
            string name = Console.ReadLine();
            
            if(!name.Contains(" "))
            {
                Console.WriteLine($"Name: {name}");
            }
            else
            {
                string[] words = name.Split(' ');
                Console.WriteLine($"Surname: {words[1]}");
                Console.WriteLine($"Name: {words[0]}");
            }
            



        }
    }
}
