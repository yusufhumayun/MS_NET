using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemo1.Day3_16Feb
{
   /* enum Month
    {
        Jan,Feb, March ,April ,May ,June,July,August,September
    }*/
    internal class Third
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key");
            //ConsoleKeyInfo ck = Console.ReadKey();
            //ConsoleKeyInfo ck = Console.ReadKey();//displays pressed keychar on console
            //ConsoleKey and ConsoleKeyInfo are defined in System namespace

            //for password input
            ConsoleKeyInfo ck = Console.ReadKey(true);//hides pressed keychar on console
            Console.Write("*");
            //ConsoleKey.

            Console.WriteLine("\nPressed key:" + ck.Key);//ConsoleKey

            if (ConsoleKey.Enter != ck.Key)
            {
                Console.WriteLine(" keyChar:" + ck.KeyChar);//char
            }





        }
    }
}
