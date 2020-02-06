using System;

namespace assignment
{
    class Program
    {
        public void Exercise1()
        {
            Console.WriteLine("Enter a number: ");
            var number = Console.ReadLine();
            var convert = Convert.ToInt32(number);
            if (number >= 1 && number <= 10)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("Invalid");
        }
    }
}
