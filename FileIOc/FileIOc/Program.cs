using System;
using System.IO;

namespace FileIOc
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Method 1
            string[] lines = { "First 30", "Second 2", "Third 100" };

            File.WriteAllLines(@"C:\Users\zdowd\OneDrive\Desktop\lesson.txt", lines);

            ////Method 2
            //Console.WriteLine("Give the file a name");
            //string fileName = Console.ReadLine();
            //Console.WriteLine("Please enter text for file");
            //string input = Console.ReadLine();

            //File.WriteAllText(@"C:\Users\zdowd\OneDrive\Desktop\" + fileName + ".txt", input);

            //Method 3
            using (StreamWriter file = new StreamWriter(@"C:\Users\zdowd\OneDrive\Desktop\myTxt.txt"))
            {
                foreach (string line in lines)
                {
                    if (line.Contains("Third"))
                    {
                        file.WriteLine(line);
                    }
                }
            };               
            using (StreamWriter file = new StreamWriter(@"C:\Users\zdowd\OneDrive\Desktop\myTxt2.txt"))
            {
                foreach (string line in lines)
                {
                    if (line.Contains("2"))
                    {
                        file.WriteLine(line);
                    }
                }
            };             
            using (StreamWriter file = new StreamWriter(@"C:\Users\zdowd\OneDrive\Desktop\myTxt2.txt", true))
            {
                file.WriteLine("Additional line");
            };   
            





            /*
            //Example 1
            string text = System.IO.File.ReadAllText
                (@"C:\Users\zdowd\OneDrive\Desktop\lesson.txt");

            Console.WriteLine($"Text file contains the following text: {text}");


            //Example 2

            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\zdowd\OneDrive\Desktop\lesson.txt");
            Console.WriteLine($"Contents of text file are: ");
            foreach (string line in lines)
            {
                Console.WriteLine("\t" + line);
            }
            */
        }
    }
}
