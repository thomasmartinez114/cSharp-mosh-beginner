using System;

namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            for (var i = 0; i < 10; i++)
              Console.Write((char)random.Next(97, 122)); //random character a - z
            Console.WriteLine();
        }
    }
}
