using System;

namespace DatesTime
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(2015, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine(now);
            Console.WriteLine();
            Console.WriteLine(today);
            Console.WriteLine();
            Console.WriteLine("Hour: " + now.Hour);
            Console.WriteLine("Minute: " + now.Minute);
        }
    }
}
