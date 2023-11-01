using System;
using System.Text;

namespace Practice2
{
    class pr2
    {
        protected static void ValueTypes()
        {
            byte b = byte.MaxValue;
            Console.WriteLine($"Maximum value of byte: {b}");

            for (byte i=0; i<b; i++)
            {
                byte[] byteArray = { i };
                string str = Encoding.ASCII.GetString(byteArray);
                Console.Write($"{str}, ");
            }
        }

        // main method
        static void Main(string[] args)
        {
            ValueTypes();
        }
    }
}
