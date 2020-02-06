using System;

namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            for (var i = 0; i < 10; i++)
                Console.WriteLine(random.Next(1, 10));
        }
    }
}
