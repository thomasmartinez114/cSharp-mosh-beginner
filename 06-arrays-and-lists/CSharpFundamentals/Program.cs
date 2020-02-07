using System;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 3, 7, 9, 2, 14, 6 };

            // Length
            Console.WriteLine("Length: " + numbers.Length);

            // IndexOf()
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine(index);

            //Clear()
            Array.Clear(numbers, 0, 2);

            foreach (var n in numbers)
                Console.WriteLine(n);
        }
    }
}
