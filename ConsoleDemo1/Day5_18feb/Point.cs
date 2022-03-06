using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemo1.Day5_18feb
{
    internal class Point
    {
        int x,y;

        public Point()
        {
            this.x = 20;
            this.y = 30;
        }
        //public Point(int x , int y)
        //{
        //    this.x = x;
        //    this.y = y;
        //}
        public Point(int x=50, int y=60)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return $"Point({x},{y})";
        }
        //overloading + operator
        public static Point operator +(Point ob1 , Point ob2)
        {
            return new Point(ob1.x + ob2.x, ob1.y + ob2.y);
        }
        //overloading + operator
        public static Point operator -(Point ob1, Point ob2)
        {
            return new Point(ob1.x - ob2.x, ob1.y - ob2.y);
        }
        //overloading + operator
        public static Point operator *(Point ob1, Point ob2)
        {
            return new Point(ob1.x * ob2.x, ob1.y * ob2.y);
        }
        //overloading + operator
        public static Point operator /(Point ob1, Point ob2)
        {
            return new Point(ob1.x / ob2.x, ob1.y / ob2.y);
        }
        ~Point()
        {
            Console.WriteLine("Point Destructor  called");
        }

    }
    class PointMain
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            Console.WriteLine(p1);

            Point p2 = new Point(40,30);
            Console.WriteLine(p2);

            Point p3 = new Point(70);
            Console.WriteLine(p3);

            Point p4 = new Point(y:70);
            Console.WriteLine(p4);

            Point p5 = new Point(y: 70,x:20);
            Console.WriteLine(p5);

            //Console.WriteLine(p1+p2);  p1-p2invalid
            //Point p1 = p2  valid

            Point p6 = p1 + p2;
            Console.WriteLine(p6);

            Point p7 = p1 - p2;
            Console.WriteLine(p6);
            //GC.Collect(0)

            Point p8 = p1 * p2;
            Console.WriteLine(p8);

            Point p9 = p1 / p2;
            Console.WriteLine(p9);

        }
    }
}
