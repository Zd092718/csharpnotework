using System;

namespace NullablesC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? num1 = null;
            int? num2 = 1337;


            double? num3 = new double?();
            double? num4 = 3.14157;

            bool? boolVal = new bool?();

            Console.WriteLine($"Our nullable nums are {num1}, {num2}, {num3}, {num4}");
            Console.WriteLine($"Our nullable boolean is {boolVal}");

            bool? isMale = true;
            if(isMale is true)
            {
                Console.WriteLine("User is male");
            }else if(isMale is false)
            {
                Console.WriteLine("User is female");
            }
            else
            {
                Console.WriteLine("No gender chosen");
            }


            double? num5 = 13.1;
            double? num6 = null;
            double num8;
            if(num6 is null)
            {
                num8 = 0.0;
            } else
            {
                num8 = (double)num5;
            }

            Console.WriteLine(num8);

            num8 = num5 ?? 8.54;
            Console.WriteLine(num8);          
            num8 = num6 ?? 8.54;
            Console.WriteLine(num8);


        }
    }
}
