using System;

namespace Algorithms
{
    
    public static partial class Algorithms
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="list"> Assuming the list in already sorted</param>
        /// <param name="item"></param>
        /// <returns></returns>
        public static string BinarySearch(int[] list, int item)
        {
            int iterationsCounter = 0;
            int low = list[0];
            int high = list[list.Length - 1];

            while (low<=high)
            {   
                iterationsCounter++;
                int mid = (low + high) / 2;
                int guess = list[mid];
                if(guess==item)
                {
                    return $"It took {iterationsCounter} iterations to find {item}";
                }
                if(guess> item)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }

            }
            return $"It took {iterationsCounter} iterations to find {item}";
        }
        
    }
}