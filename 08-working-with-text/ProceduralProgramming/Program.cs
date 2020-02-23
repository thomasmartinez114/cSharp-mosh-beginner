﻿using System;

namespace ProceduralProgramming
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What's your name? ");
            var name = Console.ReadLine();
            var reversed = ReverseName(name);
            Console.WriteLine("Reversed name: " + reversed);
        }

        public static string ReverseName(string name)
        {
            var array = new char[name.length];
            for (var i = name.Length; i > 0; i--)
                array[name.Length - i] =[i - 1];

            var reversed = new string(array);

            return reversed:
        }
    }
}
