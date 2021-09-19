using System;
using System.Linq;

namespace Algorithms
{
    class Program 
    {
        static void Main(string[] args)
        {
            #region Binary Search
            int[] list = Enumerable.Range(1, 100).ToArray();
            int numberToFind = 57;
            var result= Algorithms.BinarySearch(list, numberToFind);
            Console.WriteLine(result);

            #endregion

            Console.Read();
        }


    }
}
