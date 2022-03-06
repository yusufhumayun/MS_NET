using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemo1.Day4_17feb
{
    internal class EmpConstructor
    {
        int IdNo;
        string name;

        public void setEmp(int IdNo, string name)
        {
            this.IdNo = IdNo;
            this.name = name;
            Console.WriteLine("Emplpyee Details saved");
        }
        public void displayEmpData()
        {
            Console.WriteLine($"ID :{IdNo} \t\t Name :{name}");
        }
        public override string ToString()
        {
            return $"ID :{IdNo} \t\t Name :{name}";
        }
    }
    class EmpMain
    {
        static void Main(string[] args)
        {
            EmpConstructor emp = new EmpConstructor(); //object creation
          //  emp.setEmp(101, "Yusuf");
            emp.displayEmpData(); // 0 null

            EmpConstructor emp1 = new EmpConstructor();
            emp1.setEmp(102, "Humayun");
            emp1.displayEmpData();

            Console.WriteLine(emp1); ///address

            EmpConstructor emp2 = emp1; ///references of emp1 assign to emp2
            emp2.setEmp(200, "Manoj");

            Console.WriteLine(emp2);
            Console.WriteLine(emp1);

            Console.WriteLine(emp2.GetHashCode());
            Console.WriteLine(emp1.GetHashCode());

            new EmpConstructor().setEmp(1000, "Vijay");
            new EmpConstructor().displayEmpData();// 0  null
            


            //Employee enp3 = new(); //c# 9.0 or above

        }
    }
}
