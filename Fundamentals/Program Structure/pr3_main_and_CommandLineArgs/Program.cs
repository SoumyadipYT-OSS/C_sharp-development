using System.Text;

namespace pr3
{
    class Program3_methodARGS
    {
        static void Main(string[] args)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("Hello");
            builder.AppendLine("World!");

            Console.WriteLine(builder.ToString());
        }
    }
}

