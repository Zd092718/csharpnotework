using System;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Ticket t1 = new Ticket(5);
            Ticket t2 = new Ticket(5);

            Console.WriteLine(t2.Equals(t1));
         }
    }
}
