using System;
using System.Text;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int price = 100;
            // prints specific currency
            System.Diagnostics.Debug.WriteLine("The Item costs {0:C}", price);

            StringBuilder stringBuilder = new StringBuilder();
            ////Appends to string on current line
            //for (int i = 0; i < 4; i++)
            //{

            //stringBuilder.Append(" nice to see you");
            //}
            //string s = stringBuilder.ToString();
            //Console.WriteLine(s);
            //stringBuilder.Clear();

            ////Appends to following lines
            //stringBuilder.AppendLine("Hello World");
            //stringBuilder.AppendLine("Hello World");
            //Console.WriteLine(stringBuilder.ToString());
        }
    }
}
