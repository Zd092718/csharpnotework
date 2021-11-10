using System;
using System.Collections.Generic;

namespace IEnumerableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //get collection to return list
            IEnumerable<int> unknownCollection;
            unknownCollection = GetCollection(1);

            foreach (int num in unknownCollection)
            {
                Console.WriteLine(num + " ");
            }
                    
            // get collection to return queue
            unknownCollection = GetCollection(2);

            foreach (int num in unknownCollection)
            {
                Console.WriteLine(num + " ");
            }

        }

        static IEnumerable<int> GetCollection(int options)
        {
            List<int> numbersList = new List<int>() { 1, 2, 3, 4, 5 };

            Queue<int> numbersQueue = new Queue<int>();

            numbersQueue.Enqueue(5);
            numbersQueue.Enqueue(6);
            numbersQueue.Enqueue(7);
            numbersQueue.Enqueue(8);
            numbersQueue.Enqueue(9);


            if(options == 1)
            {
                return numbersList;
            } else if(options == 2)
            {
                return numbersQueue;
            } else
            {
                return new int[] { 11, 12, 13, 14, 15 };
            }
        }
    }
}