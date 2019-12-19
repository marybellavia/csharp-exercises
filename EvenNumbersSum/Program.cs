using System;
using System.Collections.Generic;

namespace EvenNumbersSum
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> integers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            Console.WriteLine(EvenNumbersSum(integers));
            
        }

        public static int EvenNumbersSum(List<int> nums)
        {
            int sum = 0;
            foreach (int num in nums)
            {
                if(num % 2 == 0)
                {
                    sum = sum + num;
                }
                else
                {
                    continue;
                }
            }
            return sum;
        }
    }
}
