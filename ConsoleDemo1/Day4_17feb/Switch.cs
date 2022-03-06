using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemo1.Day4_17feb
{
    internal class Switch
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Enter any character :");
            ch = Char.Parse(Console.ReadLine());
            switch (ch)
            {
                case 'a':
                    //Console.WriteLine("vowel");
                    //break;
                case 'e':
                //Console.WriteLine("vowel");
                // break;
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine($" {ch} vowel");
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }
        }
        
    }
}
