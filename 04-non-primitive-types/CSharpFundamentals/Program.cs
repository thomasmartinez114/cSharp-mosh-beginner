using System;

using CSharpFundamentals.Math;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Mosh";
            var lastName = "Hamedi";

            var fullName = firstName + " " + lastName;

            // Format Method to define a template for the string with placeholders {0} {1}
            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);

            // Array of names
            var names = new string[3] { "John", "Jack", "Mary" };
            var formattedNames = string.Join(",", names);
            Console.WriteLine(formattedNames);

            // Using string normally is hard to see
            // var text = "Hi John\nLook into the following paths\nc:\\folder1\\folder2\nc:\\folder3\\folder4";
            // Console.WriteLine(text);

            // Use verbatim string
            var text = @"Hi John
            Look into the following paths
            c:\folder1\folder2
            c:\folder3\folder4";
            Console.WriteLine(text);
        }
    }
}
