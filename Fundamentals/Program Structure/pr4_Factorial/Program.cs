using System;

namespace pr4
{
    public class myFunctionClass
    {
        public static long myFactorial(int n)
        {
            // Test for invalid input
            if ((n < 0) || (n > 20))
            {
                return -1;
            }

            // Calculate the factorial iteratively rather than recursively
            long tempResult = 1;
            for (int i = 1; i <= n; i++)
            {
                tempResult = tempResult * i;
            }
            return tempResult;
        }
    }

    class MainClass
    {
        static int Main(string[] args)
        {
            Console.Write("Enter an integer: ");
            string input = Console.ReadLine();
            int num;
            if (input == null || !int.TryParse(input, out num))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                return 1;
            }

            Console.WriteLine($"You entered: {num}");

            // Calculate Factorial
            long result = myFunctionClass.myFactorial(num);
            // printing result
            if (result == -1)
                Console.WriteLine("Input must be >=0 and <=20");
            else
                Console.WriteLine($"The factorial of {num} is {result}");

            return 0;
        }
    }
}
