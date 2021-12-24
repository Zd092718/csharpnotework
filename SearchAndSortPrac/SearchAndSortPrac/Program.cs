using System;
using System.Collections.Generic;

namespace SearchAndSortPrac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> testList = new List<int>() { 1, 2, 3, 4, 5, 6 ,7, 8, 9, 10, 2, 4, 5, 6, 2, 7, 22, 55,};
            binarySearch(testList, 2);
        }

        /// <summary>
        /// Linear Search function, not great for larger collections
        /// </summary>
        /// <param name="elements"></param>
        /// <param name="x"></param>
        /// <returns>if passed int x is found in the elements list, it will return all matching elements</returns>
        //static int linearSearch(List<int> elements, int x)
        //{
        //    int length = elements.Count;
        //    for (int i = 0; i < length; i++)
        //    {
        //        if(elements[i] == x)
        //        {
        //            return i;
        //        }
        //    }
        //    return -1;
        //}

        
        static int binarySearch(List<int> elements, int x)
        {
            int start = 0;
            int stop = elements.Count - 1;
            int middle = (int)((start + stop) / 2);
            while (elements[middle] != x && start < stop)
            {
                if(x < elements[middle])
                {
                    stop = middle - 1;
                } else
                {
                    start = middle - 1;
                }
                middle = (int)((start + stop) / 2);
            }
            return (elements[middle] != x) ? -1 : middle;
        }


    }
}
