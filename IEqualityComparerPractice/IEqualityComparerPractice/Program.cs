using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace IEqualityComparerPractice
{
    public class Officer
    {
        Guid id;

        public Guid Id
        {
            get { return id; }
            set { id = value; }
        }
    }
    internal class Program : IEqualityComparer<Officer>
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public bool Equals(Officer x, Officer y)
        {
            return x.Id == y.Id;
        }

        public int GetHashCode([DisallowNull] Officer obj)
        {
            return obj.Id.GetHashCode();    
        }
    }
}
