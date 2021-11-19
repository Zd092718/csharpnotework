using System;
using System.Text;
using System.Collections.Generic;
using System.IO;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int price = 100;
            //// prints specific currency
            //System.Diagnostics.Debug.WriteLine("The Item costs {0:C}", price);

            //StringBuilder stringBuilder = new StringBuilder();
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

            ////Bool flag technique
            //bool flag = false;
            //List<int> intList = new List<int>() { 1, 2, 3};
            //foreach (int item in intList)
            //{
            //    if(item == 3)
            //    {
            //        flag = true;
            //    }
            //}
            //if (flag)
            //{
            //    Console.WriteLine("Three is in the list");
            //}

            ////Boxing and Unboxing
            //int example = 1;
            //object o = example;
            //int example2 = (int)o;

            ////Anonymous variable
            //var example = 3;

            ////Dynamic variable
            //dynamic example = 3;
            //Console.WriteLine(example);

            //Console.WriteLine(DateTime.UtcNow);
            //Console.WriteLine(DateTime.Now);

            //int x = 3;
            //while (x > 0)
            //{
            //    Console.WriteLine(x);
            //    x--;
            //}

            //Console.WriteLine("Enter a number: ");

            //do
            //{
            //    string input = Console.ReadLine();
            //    int number;

            //    if(!int.TryParse(input, out number))
            //    {
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine("You entered invalid input");
            //        Console.ResetColor();
            //        Console.WriteLine("Please enter a number: ");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Thanks! Enter another number: ");
            //    }

            //} while (true);

            ////File Manipulation
            //string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Example.txt";
            //if (!File.Exists(path))
            //{
            //    File.Create(path);
            //}

            //FileStream fs = File.Open(path, FileMode.Append);
            //byte[] info = new UTF8Encoding(true).GetBytes("Hello World");

            //fs.Write(info, 0, info.Length);
            //fs.Close();

            //StreamReader sr = new StreamReader(path);
            //string fileText = sr.ReadToEnd();

            //Console.WriteLine(fileText);

        }
    }
}
