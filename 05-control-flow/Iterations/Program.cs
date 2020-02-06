using System;

namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
          while (true)
            {
                Console.Write("Type your name: ");
                var input = Console.ReadLine();

                // if no entry - break
                if (String.IsNullOrWhiteSpace(input))
                    break;

                // echo the name
                Console.WriteLine("@Echo: " + input);
            }
        }
    }
}
