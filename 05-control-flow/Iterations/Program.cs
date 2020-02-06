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

                // if not empty - echo name
                if (!String.IsNullOrWhiteSpace(input))
                {
                // echo the name
                Console.WriteLine("@Echo: " + input);
                    continue;
                }

                break;                
            }
        }
    }
}
