using System;

namespace Practice1
{
    public class MyClass
    {
        private string[] programmingLanguages = { "C", "C#", "Python", "Java" };

        public string GetName(int ID)
        {
            if (ID < programmingLanguages.Length)
                return programmingLanguages[ID];
            else
                return String.Empty;
        }

        public void myMethod()
        {
            char firstLetter = 'C';
            var limit = 3;
            int[] source = { 0, 1, 2, 3, 4, 5 };
            var query = from item in source
                        where item <= limit
                        select item;

            MyClass obj = new MyClass();
            foreach (var i in query)
            {
                obj.GetName(i);
            }
        }

        public void displayTemparatureLocation(float temp, string name)
        {
            Console.WriteLine($"Weather: {temp} degree celsius");
            Console.WriteLine($"Location: {name}");
        }
    }


    class pr1
    {
        protected static void SpecifyTypes()
        {
            // Declaration only:
            float temparature;
            string LocationName;
            Console.Write("Enter weather temparature (Celsius value): ");
            temparature = float.Parse(Console.ReadLine());
            Console.Write("Enter Location: ");
            LocationName = Console.ReadLine();

            MyClass myl = new MyClass();
            myl.displayTemparatureLocation(temparature, LocationName);
        }

        static void Main(string[] args)
        {
            int a = 5;
            int b = a + 2;
            bool test = true;
            // int c = a + test;   this will gives you an error
            int c = a + b;
            Console.WriteLine($"Value of C: {c}");

            // method calling 
            SpecifyTypes();
            // calling class and its method
            MyClass ms = new MyClass();
            ms.myMethod();
        }
    }
}
