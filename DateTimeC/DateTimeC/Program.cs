using System;

namespace DateTimeC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(1996, 2, 7);

            Console.WriteLine($"My birthday is {dateTime}");

            //write today on screen
            Console.WriteLine(DateTime.Today);
            //write current time
            Console.WriteLine(DateTime.Now);

            //get tomorrow
            DateTime tomorrow = GetTomorrow();
            Console.WriteLine(tomorrow);

            //get day of week
            Console.WriteLine(DateTime.Today.DayOfWeek);
            //get first day of year
            Console.WriteLine(GetFirstDayOfYear(1999));

            //get days of month
            int days = DateTime.DaysInMonth(2000, 2);
            Console.WriteLine($"Days in feb 2000: {days}");

            //get current minute
            DateTime now = DateTime.Now;
            Console.WriteLine($"Current minute: {now.Minute}");
            Console.WriteLine
                ($"Current time: {now.Hour} o' clock {now.Minute} minutes and {now.Second} seconds");


            //// get time passed since specific date
            //Console.WriteLine("Write a date in this format: yyyy-mm-dd");
            //string input = Console.ReadLine();
            //if(DateTime.TryParse(input, out dateTime)) {
            //    Console.WriteLine(dateTime);
            //    TimeSpan daysPassed = now.Subtract(dateTime);
            //    Console.WriteLine($"Days passed since: {daysPassed.Days}");
            //}           
            
            
            Console.WriteLine("Write your birthday in this format: yyyy-mm-dd");
            string bday = Console.ReadLine();
            if(DateTime.TryParse(bday, out dateTime)) {
                Console.WriteLine(dateTime);
                TimeSpan daysPassed = now.Subtract(dateTime);
                Console.WriteLine($"Days passed since your birthday: {daysPassed.Days}");
            }
        }
        static DateTime GetTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }


        static DateTime GetFirstDayOfYear(int year)
        {
            return new DateTime(year, 1, 1);
        }
    }
}
