using System;
using System.Collections;

namespace IComparerPrac
{
    class Employee
    {
        public int id;
    }
    internal class Program : IComparer
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int Compare(object x, object y)
        {
            Employee employee1 = (Employee)x;
            Employee employee2 = (Employee)y;
            return employee1.id.CompareTo(employee2.id);
        }
    }
}
