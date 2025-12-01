using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    namespace StudentInfo
    {
          
        public class Student
        {
            public int roll;
            public string name;

            Student(int r, string n)
            {
                Console.WriteLine("Constructor school Called");
                roll = r;
                name = n;
            }

            public void ShowDetails()
            {
                Console.WriteLine("Roll No: " + roll); ;
                Console.WriteLine($"Name: {name}");
            }
        }
    }

}
