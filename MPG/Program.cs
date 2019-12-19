using System;

namespace MPG
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double miles;
            double gallons;
            double mpg;

            Console.WriteLine("How many miles have you driven?");
            miles = double.Parse(Console.ReadLine());

            Console.WriteLine("How many gallons of gas have you consumed?");
            gallons = double.Parse(Console.ReadLine());

            mpg = miles / gallons;

            Console.WriteLine("If you drove {0} miles and consumed {1} " +
                "gallons of gas, your MPG are {2}!", miles, gallons, mpg);
        }
    }
}
