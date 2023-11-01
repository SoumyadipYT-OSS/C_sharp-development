/*  Built-in types in C# reference */

using System;

namespace Practice3
{
    class Program3
    {
        public static void literals_built_in_types()
        {
            // bool
            Console.WriteLine("\n__bool keyword__");
            bool check = true;
            Console.WriteLine(check);

            // nested function
            void Display(bool? b) => Console.WriteLine(b is null ? "null" : b.Value.ToString());
            
            // Nullable Boolean Logical Operators
            Console.WriteLine("\n__Nullable Boolean Logical Operators__");
            bool? test = null;
            Display(!test);
            Display(test ^ false);
            Display(true & true);
            Display(true ^ false);
            Display(true ^ true);
            Display(false & false);
            Display(test | false);
            Display(test | true);
            Display(false | true);
            Display(false | false);
            Display(true | true);

            // Compound Assignment (binary operation)
            Console.WriteLine("\n__Compound Assignment__");
            bool test1 = true;
            test1 &= false;
            Console.WriteLine("bool test1 = true -> "+ test1);

            test1 |= true;
            Console.WriteLine($"test1 |= true -> {test1}");
        }

        public static void OperatorPrecendence()
        {
            Console.WriteLine(true | true & false);
            Console.WriteLine((true | true) & false);

            bool myOperand(string name, bool value)
            {
                Console.WriteLine($"Operand {name} is evaluated.");
                return value;
            }

            var byDefaultPrecedence = myOperand("A", true) && myOperand("B", true) && myOperand("C", false);
            Console.WriteLine(byDefaultPrecedence);

            var changedOrder = (myOperand("A", true) || myOperand("B", true)) && myOperand("C", true);
            Console.WriteLine(changedOrder);
        }


        // main method
        static void Main(string[] args)
        {
            literals_built_in_types();
            Console.WriteLine("\n");
            OperatorPrecendence();
        }
    }
}
