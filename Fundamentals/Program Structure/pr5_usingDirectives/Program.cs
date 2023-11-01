using System.Text;

StringBuilder builder = new StringBuilder();
builder.AppendLine("Hello");
builder.AppendLine("World!");
Console.WriteLine(builder.ToString());



/* 
    __Global namespace__
        Namespaces and type definitions: A file with top-level statements
      can also contain namespaces and type definitions, but they must come 
      after the top-level statements.
*/


MyClass.TestMethod();
MyNamespace.MyClass.MyMethod();

public class MyClass
{
    public static void TestMethod()
    {
        Console.WriteLine("Class: 'MyClass' \n Method: 'TestMethod'\n");
    }
}

namespace MyNamespace
{
    class MyClass
    {
        public static void MyMethod()
        {
            Console.WriteLine("__Under the namespace__ \nClass: 'MyClass' \n Method: 'MyMethod'\n");
        }
    }
}

