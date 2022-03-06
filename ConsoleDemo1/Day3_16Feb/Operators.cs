using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemo1.Day3_16Feb
{
    internal class Operators
    {
        static void Main(string[] args)
        {
            //int x = -10;
            // Console.WriteLine("Complement of "+x+"(~x) ="+ ~x); //1's complement

            //Console.WriteLine("Complement of " + x + "(~x+1) =" + (~x+1)); //2's complement

            int x = 30, y = 20;
            Console.WriteLine(x+~y+1);//10

            int z = x++ +  ++y;
            
            Console.WriteLine(z);//51
            
            int x1 = 30, y1 = 20;
            int z1 = ++x1 + ++y1;

            Console.WriteLine(z1);//52

            int x2 = 30, y2 = 20;
            int z2 = ++x2 + ++x2;

            Console.WriteLine(z2);//63


            int x3 = 30, y3 = 20;
            int z3 =x3++ + x3++;

            Console.WriteLine(z3);//61


            object str = "yusuf";
            // string mystr = (String)str;
            string mystr = str as string;
            Console.WriteLine(mystr);


            int? p = 20;
            if(p is null)
            {
                Console.WriteLine(p);
            }
            
            if(mystr is string)
            {
                Console.WriteLine(mystr);
            }

            Type tp = typeof(int);
            Console.WriteLine(tp.Name);
            Console.WriteLine(tp.Namespace);




        }
    }

}
