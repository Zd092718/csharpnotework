using System;
using System.Collections.Generic;

namespace DelegatesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //list of names
            List<string> names = new List<string> { "Zack", "Allie", "Bennet", "Matt" };

            Console.WriteLine("------before-------");
            //print names before remove all method
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            //calling removeAll and passing filter method that was created
            names.RemoveAll(Filter);

            Console.WriteLine("------after--------");
            //print names after the remove all method
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }

        //a method called filter that takes in a string
        static bool Filter(string s)
        {
            //return whether the string s contains the letter i
            return s.Contains("a");
        }
    }
}
