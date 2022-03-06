using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemo1.Day5_18feb
{
    internal class EmpConstructor
    {
        int _IdNo;
        string _name;//non static means object dependent
        static int id;//static data field means object independent

        public EmpConstructor()
        {
            Console.WriteLine("Default Constructor :");
            //this._IdNo = 1000;
            this._IdNo = id++;
            this._name = "yusuf";

        }
        public EmpConstructor(int _IdNo)
        {
            Console.WriteLine("Parametrized Constructor for IdNo");
            this._IdNo=_IdNo;
            id = _IdNo + 1; //updating static id with user value
        }
        public EmpConstructor(string _name)
        {
            Console.WriteLine("Parameterized Constructor For Name");
            this._name = _name;
            this._IdNo=id++;
        }
        public EmpConstructor(int _IdNo ,string _name)
        {
            Console.WriteLine("Parameterized Constructor For IdNo and Name");
            this._IdNo = _IdNo;
            this._name = _name;
            id= _IdNo + 1  ; //updating static id with user value
        }
        //static constructor
       static EmpConstructor()
        {
            Console.WriteLine("Static Constructor Called");
            Console.WriteLine("It is used to initiaze the class static data fields");
            id = 1000;
        }


        public EmpConstructor setEmp(int IdNo, string name)
        {
            this._IdNo = IdNo;
            this._name = name;
            Console.WriteLine("Emplpyee Details saved");
            return this;
        }
        public void displayEmpData()
        {
            Console.WriteLine($"ID :{_IdNo} \t\t Name :{_name}");
        }
        public override string ToString()
        {
            return $"ID :{_IdNo} \t\t Name :{_name}";
        }
    }
    class EmplyeeConsMain
    {
        static void Main(string[] args)
        {
            EmpConstructor emp1 = new EmpConstructor();
            Console.WriteLine(emp1);

            EmpConstructor emp11 = new EmpConstructor();
            Console.WriteLine(emp11);

            EmpConstructor emp2 = new EmpConstructor(1000);
            Console.WriteLine(emp2);

            EmpConstructor emp3 = new EmpConstructor("Vijay");
            Console.WriteLine(emp3);


            EmpConstructor emp4 = new EmpConstructor(104, "Vijay");
            Console.WriteLine(emp4);

        }
    }
}
