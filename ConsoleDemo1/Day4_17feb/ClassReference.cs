using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemo1.Day4_17feb
{
    internal class ClassReference
    {
        int IdNo;
        string name;

        public ClassReference SetEmp(int IdNo, string name)
        {
            this.IdNo = IdNo;
            this.name = name;
            Console.WriteLine("Emplpyee Details saved");
            return this;
        }
        public void displayEmpData()
        {
            Console.WriteLine($"ID :{IdNo} \t Name :{name}");
        }
        public override string ToString()
        {
            return $"ID :{IdNo} \t\t Name :{name}";
        }
    }
    class Emp1Main
    {
        static void Main(string[] args)
        {
            ClassReference emp = new ClassReference(); //object creation
                                           //  emp.setEmp(101, "Yusuf");
            emp.displayEmpData(); // 0 null

            ClassReference emp1 = new ClassReference();
            emp1.SetEmp(102, "Humayun");
            emp1.displayEmpData();

            Console.WriteLine(emp1); ///address

            ClassReference emp2 = emp1; ///references of emp1 assign to emp2
            emp2.SetEmp(200, "Manoj");

            Console.WriteLine(emp2);
            Console.WriteLine(emp1);

            Console.WriteLine(emp2.GetHashCode());
            Console.WriteLine(emp1.GetHashCode());

            new ClassReference().SetEmp(1000, "Vijay");
            new ClassReference().displayEmpData();// 0  null
            new ClassReference().SetEmp(1000, "Vijay").displayEmpData();



            //Employee enp3 = new(); //c# 9.0 or above

        }
    }
}
