using System;
using System.Collections;
using System.Collections.Generic;

namespace IEnumeratorPrac
{
    internal class Program : IEnumerator
    {
        List<object> items = new List<object>();
        int current;
        public object Current => items[current];

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public bool MoveNext()
        {
            if(items.Count == 0 || items.Count <= current)
            {
                return false;
            } else
            {
                return true;
            }
        }

        public void Reset()
        {
            current = 0;
        }
    }
}
