using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemo1.Day4_17feb
{
    internal class ControlStatement
    {
        static void Main(string[] args)
        {
            // string str = "yusuf";
            // Console.WriteLine(str.GetType());//objects class method

            string weekday;
            Console.WriteLine("Enter any WeekDay :");
            weekday = Console.ReadLine();
            switch (weekday)
            {
                case "Monday":
                    Console.WriteLine("1");
                    break;
                case "Tuesday":
                    Console.WriteLine("2");
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }
        }
    }
}
