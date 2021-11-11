﻿using System;
using System.Collections.Generic;

namespace DelegatesDemo2
{
    internal class Program
    {
        //defining delegate type that takes a person object and returns a boolean
        public delegate bool FilterDelegate(Person p);
        static void Main(string[] args)
        {
            Person p1 = new Person() { Name = "Zack", Age = 25 };
            Person p2 = new Person() { Name = "Allie", Age = 26 };
            Person p3 = new Person() { Name = "Bennet", Age = 70 };
            Person p4 = new Person() { Name = "Matt", Age = 12 };

            //add objects to people list
            List<Person> people = new List<Person>() { p1, p2, p3, p4 };


            DisplayPeople("Adults", people, IsAdult);
            DisplayPeople("Kids", people, IsMinor);
            DisplayPeople("Senior", people, IsSenior);
        }

        // method to display list of people that passes the filter condition
        static void DisplayPeople(string title, List<Person> people, FilterDelegate filter)
        {
            //print title
            Console.WriteLine(title);
            foreach (Person p in people)
            {
                if (filter(p))
                {
                    Console.WriteLine($"{p.Name}, {p.Age} years old");
                }
            }
        }

        //==================FILTERS==================
        static bool IsMinor(Person p)
        {
            return p.Age < 18;
        }

        static bool IsAdult(Person p)
        {
            return p.Age >= 18;
        }

        static bool IsSenior(Person p)
        {
            return p.Age >= 65;
        }
    }
}
