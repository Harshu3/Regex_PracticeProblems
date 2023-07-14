using System;
using System.Text.RegularExpressions;

namespace Regex_PracticeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regex Practice Problem!");
            Console.WriteLine("C# program to find sequences of lowercase letters joined by an underscore");
            string pattern = "^[a-z]{2,}_[a-z]{2,}$";
            Regex regex = new Regex(pattern);
            Console.WriteLine("Enter lower case input");
            string s = Console.ReadLine();
            Console.WriteLine("It is: " + regex.IsMatch(s));
        }
    }
}