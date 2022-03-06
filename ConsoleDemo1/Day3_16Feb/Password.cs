using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemo1.Day3_16Feb
{
    internal class Password
    {
        static void Main(string[] args)
        {
            string pwd = "";
            ConsoleKeyInfo ck = Console.ReadKey(true);

            
            while(ck.Key !=ConsoleKey.Enter)
            {
                Console.Write("*");
                pwd += ck.KeyChar;
                ck=Console.ReadKey(true);
            }
            Console.WriteLine("Entered Password :"+pwd);

           
        }
    }
}
