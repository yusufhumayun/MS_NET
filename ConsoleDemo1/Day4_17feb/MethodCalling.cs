using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemo1.Day4_17feb
{
    internal class MethodCalling
    {
        static void Call_ByValue(int x, int y)
        {
            x = x + 30;
            y = y + 20;
            Console.WriteLine("Function");
            Console.WriteLine($" x:{x} \t\t y:{y}");
        }
        static void Main(string[] args)
        {
            int a = 20, b = 40;
            Console.WriteLine($" a:{a} \t\t b:{b}");

            Call_ByValue(a, b);

            Console.WriteLine("*******************");
            Console.WriteLine($" a:{a} \t\t b:{b}");

        }
    }
    
}
