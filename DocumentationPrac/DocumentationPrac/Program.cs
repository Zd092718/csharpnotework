using System;

namespace DocumentationPrac
{
    /// <summary>
    /// Program for xml practice
    /// </summary>
    /// <remarks>
    /// More Info can go in these tags
    /// </remarks>
    internal class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <example>
        /// <code>
        /// int c = Example.Add(1,2);
        /// </code>
        /// </example>
        /// <returns>The sum of two integers</returns>
        public static int Add(int a, int b)
        {
            return a + b;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <value>
        /// Gets value of Val
        /// </value>
        public static string Val { get; }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
