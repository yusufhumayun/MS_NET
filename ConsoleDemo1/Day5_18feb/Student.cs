using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemo1.Day5_18feb
{
    internal class Student
    {
        //1 method
        //2 contructor
        //By making data fields public
        int RollNo;
        string Name;
        int Age;

        public void SetRoll(int r)
        {
            this.RollNo = r;//write operations
        }
        public int GetRoll()
        { 
            return this.RollNo;//read operations }

        }
    class StudentMain    
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            //s1.RollNo = 10;
           // Console.WriteLine(s1.RollNo);
               
        }
    }
 }
