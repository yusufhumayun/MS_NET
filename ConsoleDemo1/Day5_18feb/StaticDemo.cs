using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemo1.Day5_18feb
{
    internal static class StaticDemo
    {
        public static int id;
        static StaticDemo()
        {
            Console.WriteLine("Static Constructor");
            id = 1000;
        }
        public static void Display()
        {
            Console.WriteLine(id);
        }

    }
    class StaticMain
    {
        static void Main(string[] args)
        {
            StaticDemo.Display();
            Console.WriteLine(StaticDemo.id);

        }
    }   

}
