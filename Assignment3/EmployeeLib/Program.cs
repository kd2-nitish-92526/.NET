using System;

namespace EmployeeLib
{
    public enum DepartmentType
    {
        HR,
        IT,
        Finance,
        Marketing,
        Operations
    }


    // 1. DATE CLASS

    public class Date
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public Date()
        {
            Day = 1;
            Month = 1;
            Year = 2000;
        }

        public Date(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public void AcceptDate()
        {
            Console.Write("Enter Day: ");
            Day = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Month: ");
            Month = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Year: ");
            Year = Convert.ToInt32(Console.ReadLine());
        }

        public void PrintDate()
        {
            Console.WriteLine(ToString());
        }

        public bool IsValid()
        {
            if (Year < 1000 || Year > 9999) return false;
            if (Month < 1 || Month > 12) return false;

            int[] days = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (Day < 1 || Day > days[Month]) return false;

            return true;
        }

        public static int CalculateAge(Date dob)
        {
            DateTime today = DateTime.Now;
            int age = today.Year - dob.Year;

            if (today.Month < dob.Month ||
                (today.Month == dob.Month && today.Day < dob.Day))
                age--;

            return age;
        }

        public override string ToString()
        {
            return $"{Day}/{Month}/{Year}";
        }
    }


    // 2. PERSON CLASS

    public class Person
    {
        public string Name { get; set; }
        public bool Gender { get; set; }
        public Date Birth { get; set; }
        public string Address { get; set; }

        public int Age
        {
            get { return Date.CalculateAge(Birth); }
        }

        public Person()
        {
            Birth = new Date();
        }

        public Person(string name, bool gender, Date birth, string address)
        {
            Name = name;
            Gender = gender;
            Birth = birth;
            Address = address;
        }

        public virtual void Accept()
        {
            Console.Write("Enter Name: ");
            Name = Console.ReadLine();

            Console.Write("Enter Gender (M/F): ");
            char g = Convert.ToChar(Console.ReadLine());
            Gender = (g == 'M' || g == 'm');

            Console.WriteLine("Enter Birth Date:");
            Birth = new Date();
            Birth.AcceptDate();

            Console.Write("Enter Address: ");
            Address = Console.ReadLine();
        }

        public virtual void Print()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            string gen = Gender ? "Male" : "Female";
            return $"Name: {Name}, Gender: {gen}, DOB: {Birth}, Age: {Age}, Address: {Address}";
        }
    }


    // 3. EMPLOYEE CLASS

    public class Employee : Person
    {
        private static int count = 0;

        public int Id { get; private set; }
        public double Salary { get; set; }
        public string Designation { get; set; }
        public DepartmentType Dept { get; set; }

        public Employee()
        {
            count++;
            Id = count;
        }

        public Employee(double salary, string designation, DepartmentType dept)
        {
            count++;
            Id = count;
            Salary = salary;
            Designation = designation;
            Dept = dept;
        }

        public override void Accept()
        {
            base.Accept();

            Console.Write("Enter Salary: ");
            Salary = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Department (0=HR 1=IT 2=Finance 3=Marketing 4=Operations): ");
            Dept = (DepartmentType)Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Designation: ");
            Designation = Console.ReadLine();
        }

        public override void Print()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return base.ToString() +
                   $", Id: {Id}, Salary: {Salary}, Dept: {Dept}, Designation: {Designation}";
        }
    }


    // 4. MANAGER CLASS

    public class Manager : Employee
    {
        public double Bonus { get; set; }

        public Manager()
        {
            Designation = "Manager";
        }

        public Manager(double salary, double bonus, DepartmentType dept)
            : base(salary, "Manager", dept)
        {
            Bonus = bonus;
        }

        public override void Accept()
        {
            base.Accept();
            Designation = "Manager";

            Console.Write("Enter Bonus: ");
            Bonus = Convert.ToDouble(Console.ReadLine());
        }

        public override void Print()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return base.ToString() + $", Bonus: {Bonus}";
        }
    }


    // 5. SUPERVISOR CLASS

    public class Supervisor : Employee
    {
        public int Subordinates { get; set; }

        public Supervisor()
        {
            Designation = "Supervisor";
        }

        public Supervisor(double salary, int sub, DepartmentType dept)
            : base(salary, "Supervisor", dept)
        {
            Subordinates = sub;
        }

        public override void Accept()
        {
            base.Accept();
            Designation = "Supervisor";

            Console.Write("Enter Number of Subordinates: ");
            Subordinates = Convert.ToInt32(Console.ReadLine());
        }

        public override void Print()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return base.ToString() + $", Subordinates: {Subordinates}";
        }
    }


    //  WAGE EMPLOYEE CLASS

    public class WageEmp : Employee
    {
        public int Hours { get; set; }
        public int Rate { get; set; }

        public WageEmp()
        {
            Designation = "Wage";
        }

        public WageEmp(int hours, int rate, DepartmentType dept)
            : base(hours * rate, "Wage", dept)
        {
            Hours = hours;
            Rate = rate;
        }

        public override void Accept()
        {
            base.Accept();
            Designation = "Wage";

            Console.Write("Enter Hours Worked: ");
            Hours = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Rate per Hour: ");
            Rate = Convert.ToInt32(Console.ReadLine());
        }

        public override void Print()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return base.ToString() + $", Hours: {Hours}, Rate: {Rate}";
        }
    }
}
