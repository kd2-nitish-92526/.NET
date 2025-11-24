using EmployeeLib;
using System;
namespace HRMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            Console.WriteLine(p.ToString());
            Console.WriteLine("jh");
            p.Print();
            Manager m = new Manager();
            m.Accept();
            m.Print();

            Supervisor s = new Supervisor();
            s.Accept();
            s.Print();

            WageEmp w = new WageEmp();
            w.Accept();
            w.Print();

        }
    }
}

