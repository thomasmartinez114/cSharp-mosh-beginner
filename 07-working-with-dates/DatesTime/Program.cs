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

            //Console.WriteLine(now);
            //Console.WriteLine();
            //Console.WriteLine(today);
            //Console.WriteLine();
            //Console.WriteLine("Hour: " + now.Hour);
            //Console.WriteLine("Minute: " + now.Minute);

            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine(now.ToLongDateString()); // Saturday, February 8, 2020
            Console.WriteLine(now.ToShortDateString()); // 2/8/2020
            Console.WriteLine(now.ToLongTimeString()); // 6:46:33 PM
            Console.WriteLine(now.ToShortTimeString()); // 6:46 PM
            Console.WriteLine(now.ToString()); // date and time
            
        }
    }
}
