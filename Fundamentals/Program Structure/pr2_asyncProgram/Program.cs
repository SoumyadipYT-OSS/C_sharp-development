using System;
using System.Threading.Tasks;

namespace pr2
{
    class Program
    {
        static async Task Main(string[] args)
        {
            int a = 5;
            int b = 10;
            int sum = await AddAsync(a, b);
            Console.WriteLine($"The sum of {a} and {b} is {sum}");
        }

        static async Task<int> AddAsync(int a, int b)
        {
            await Task.Delay(1000);
            return a + b;
        }
    }
}

