using System;

namespace ArrayLoop
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] numbas = new int[6] { 1, 1, 2, 3, 5, 8 };
            foreach (int num in numbas)
            {
                Console.WriteLine(num);
            }
        }
    }
}
