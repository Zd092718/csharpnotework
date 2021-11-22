using System;

namespace InterfacePractice
{
    internal class Program : IExample
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public void Example()
        {
            throw new NotImplementedException();
        }

        public int Example1()
        {
            return 1;
        }

        public string Example3(string string1, string string2)
        {
            return string1 + " " + string2;
        }
    }
        interface IExample
        {
            void Example();
            int Example1();
            string Example3(string string1, string string2);
        }
}
