using System.Reflection;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\admin\\Desktop\\Assignment3_4\\Assignment4\\MathsLib\\bin\\Debug\\net8.0\\MathsLib.dll";

            Assembly assembly = Assembly.LoadFrom(path);
            Type[] typerarr = assembly.GetTypes();
            Type selectedType = typerarr[0];

            object dynamicObject = Activator.CreateInstance(selectedType);

            foreach (Type  type in typerarr)
            {
                Console.WriteLine("Full Name : " + type.FullName);

                MethodInfo[] allMethods = type.GetMethods();

                while(true)
                {
                    Console.WriteLine("Enter a choice : 1.Add 2.Sub 3.Mul 4.Div 0.Exit");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    if (choice == 0) break;

                    for(int i = 0; i < allMethods.Length; i++)
                    {
                        if (allMethods[i].Name == "Add" && choice == 1)
                        {
                            Console.WriteLine("Enter 2 Numbers : ");
                            int a = Convert.ToInt32(Console.ReadLine());
                            int b = Convert.ToInt32(Console.ReadLine());

                            Object result = allMethods[i].Invoke(dynamicObject, new object[] { a, b });
                            Console.WriteLine("Add : " + result);
                        }
                        else if (allMethods[i].Name == "Sub"  && choice == 2)
                        {
                            Console.WriteLine("Enter 2 Numbers : ");
                            int a = Convert.ToInt32(Console.ReadLine());
                            int b = Convert.ToInt32(Console.ReadLine());

                            Object result = allMethods[i].Invoke(dynamicObject, new object[] {a, b});
                            Console.WriteLine("Sub : " + result);
                        }
                    }
                }
            }
        }
    }
}
