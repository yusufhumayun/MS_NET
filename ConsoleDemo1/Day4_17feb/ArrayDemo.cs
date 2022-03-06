using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemo1.Day4_17feb
{
    internal class ArrayDemo
    {
        static void Main(string[] args)
        {
            int[] arr = new int[]{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            Console.WriteLine("Array Elements :");

            //1. forward loop
            //2. readonly 
            //item = item + 2;invalid in foreach
            //foreach(int i in arr) 
            //{
            //    // Console.WriteLine(arr[i-1]);
            //    Console.WriteLine(i);
            //}

            //foreach (object item in arr)
            //{
            //    Console.WriteLine(item.GetType());
            //    if ((int)item > 5)
            //    // if ((float)item > 5)   invalid
            //    {
            //        Console.WriteLine(item);
            //    }

            //}
            //Console.WriteLine("=================================");
            //Console.WriteLine("Foreach with Var");
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item.GetType());
            //        if(item > 5)
            //           Console.WriteLine(item);

            //}
            //dynamic obj;
            //foreach (dynamic item in arr)
            //{
            //    Console.WriteLine(item.GetType());
            //        if(item > 5)
            //           Console.WriteLine(item);

            //}
        }
    }
}
