using System;

namespace IComparablePractice
{
    internal class Program : IComparable
    {

        public int exampleLength;
        Program ex1 = new Program() { exampleLength = 2 };
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int CompareTo(object obj)
        {
            Program ex2 = (Program)obj;
            if(ex1.exampleLength == ex2.exampleLength)
            {
                return 0;
            } else if (ex1.exampleLength > ex2.exampleLength)
            {
                return 1;
            } else
            {
                return -1;
            }
        }
    }
}
