using System;
using System.IO;

namespace File_and_fileinfo_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            File.Copy(@"c:\temp\myfile.jpg", "d:\temp\myfile.jpg", true)
        }
    }
}
