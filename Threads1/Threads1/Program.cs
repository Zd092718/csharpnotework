using System;
using System.Threading;
using Log = System.Diagnostics.Debug;

namespace Threads1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World! 1");
            //Thread.Sleep(1000);
            //Console.WriteLine("Hello World! 2");
            //Thread.Sleep(1000);
            //Console.WriteLine("Hello World! 3");
            //Thread.Sleep(1000);
            //Console.WriteLine("Hello World! 4");


            //new Thread(() =>
            //{
            //    Thread.Sleep(1000);
            //    Console.WriteLine("Thread 1");
            //}).Start();            
            //new Thread(() =>
            //{
            //    Thread.Sleep(1000);
            //    Console.WriteLine("Thread 2");
            //}).Start();            
            //new Thread(() =>
            //{
            //    Thread.Sleep(1000);
            //    Console.WriteLine("Thread 3");
            //}).Start();           
            //new Thread(() =>
            //{
            //    Thread.Sleep(1000);
            //    Console.WriteLine("Thread 4");
            //}).Start();
            //Console.Read();

            //Thread t = new Thread(ExampleFunction);
            //t.Name = "Example Thread 1";
            //t.IsBackground = true; //specifies background thread
            //t.IsBackground = false; //specifies foreground thread (foreground by default)
            //t.Start();  


            //Thread t = new Thread(ExampleFunction);
            //t.Priority = ThreadPriority.Normal;

            Log.WriteLine(DateTime.Now.ToString());
            Thread.Sleep(2000);
            Log.WriteLine(DateTime.Now.ToString());
        }

        static void ExampleFunction()
        {
            for (int i = 0; i < 30; i++)
            {
                
                Log.WriteLine("Hello World");

            }

        }
    }
}
