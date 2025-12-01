namespace Question2
{
    internal class Program
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            int a;

            int b;
            int choice;
            Console.WriteLine("Enter first Number : ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your choice :1.Addition 2.Subtraction 3.Multiplication 4.Division");
            choice = int.Parse(Console.ReadLine());
           
            switch (choice)
            {
                case 1:
                    Console.WriteLine("add : " + Add(a,b));
                    break;
                case 2:
                    Console.WriteLine("sub : " + (a - b));
                    break;
                case 3:
                    Console.WriteLine("mul : " + (a * b));
                    break;
                case 4:
                    Console.WriteLine("div : " + (a / b));
                    break;
               default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
            Console.ReadLine();


        }
    }
}
