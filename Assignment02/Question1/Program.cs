namespace Question1
{
    internal class Program
    {

        struct Student {
             private string name;
            private bool gender;
            private int age;
            private int std;
            private char div;
            private double marks;

            public string Name { get => name; set => name = value; }
            public bool Gender { get => gender; set => gender = value; }
            public int Age { get => age; set => age = value; }
            public int Std { get => std; set => std = value; }
            public char Div { get => div; set => div = value; }
            public double Marks { get => marks; set => marks = value; }

            public Student()
            {
                this.name = "unknown";
                this.gender = true ;
                this.age = 0;
                this.std = 1;
                this.div = 'A';
                this.marks = 100;

            }

            public Student(string name, bool gender, int age, int std, char div, double marks)
            {
                this.name = name;
                this.gender = gender;
                this.age = age;
                this.std = std;
                this.div = div;
                this.marks = marks;
            }

            public void AcceptDetails()
            {
                Console.WriteLine("Enter name : ");
                this.name = Console.ReadLine();

                Console.WriteLine("Enter Gender : ");
                this.gender = bool.Parse( Console.ReadLine());

                Console.WriteLine("Enter age : ");
                this.age =int.Parse( Console.ReadLine());

                Console.WriteLine("Enter std : ");
                this.std = int.Parse( Console.ReadLine());

                Console.WriteLine("Enter div : ");
                this.div = Char.Parse( Console.ReadLine());

                Console.WriteLine("Enter name : ");
                this.marks = int.Parse(Console.ReadLine());

                
            }

            public void PrintDetails()
            {
                Console.WriteLine($"name : {name} gender : {gender} age:{age} div : {div} marks : {marks} ");
            }




            
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello ");

            Student s1= new Student();
            s1.AcceptDetails();
            s1.PrintDetails();
        }
    }
}
