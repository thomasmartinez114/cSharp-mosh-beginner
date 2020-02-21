﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
class Program
{
    static void Main(string[] args)
    {
        /*
        var fullName = "Thomas Martinez ";
        Console.WriteLine("Trim: '{0}'", fullName.Trim());
        Console.WriteLine("Trim: '{0}'", fullName.Trim().ToUpper());

        var index = fullName.IndexOf(' ');
        var firstName = fullName.Substring(0, index);
        var lastName = fullName.Substring(index + 1);
        Console.WriteLine("FirstName: " + firstName);
        Console.WriteLine("LastName: " + lastName);

        var names = fullName.Split(' ');
        Console.WriteLine("FirstName: " + names[0]);
        Console.WriteLine("LastName: " + names[1]);

        Console.WriteLine(fullName.Replace("Thomas", "Thomasito"));

        if (String.IsNullOrWhiteSpace(" "))
            Console.WriteLine("Invalid");

        // Convert str to #s
        var str = "25";
        var age = Convert.ToByte(str);
        Console.WriteLine(age);

        // Convert # to str
        float price = 29.95f;
        Console.WriteLine(price.ToString("C0"));
        */

        var sentence = "This is a very long long long long long long long long long long text.";
        var summary = SummerizeText(sentence);
            Console.WriteLine(summary);
    }

    static string SummerizeText(string text, int maxLength = 20)
        {

        if (text.Length < maxLength)
            return text;
            var words = text.Split(' ');
            var totalCharacters = 0;
            var summaryWords = new List<string>();

            foreach (var word in words)
            {
                summaryWords.Add(word);

                totalCharacters += word.Length + 1;
                if (totalCharacters > maxLength)
                    break;
            }

            return String.Join(' ', summaryWords) + '...';
        }
    }
}
