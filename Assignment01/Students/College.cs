using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College
{
    namespace StudentInfo
    {
        public class Student
        {
            public int rollno;
            public string name;
                
            Student(int r, string n)
            {
                Console.WriteLine("Constructor College Called");
                rollno = r;
                name = n;
            }


            public void ShowDetails()
            {
                Console.WriteLine("Roll No: " + rollno); ;
                Console.WriteLine($"Name: {name}");
            }
        } 

       
        
    }
}
