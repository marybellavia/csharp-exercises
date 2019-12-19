using System;

namespace Area
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            bool cont = true;

            while (cont == true)
            {
                Console.WriteLine("Enter a radius: ");
                string r = Console.ReadLine();
                double radius;

                if (double.TryParse(r, out radius))
                {
                    if (radius > 0)
                    {
                        double area = Math.PI * Math.Pow(radius, 2);
                        Console.WriteLine("The area of a circle with radius {0} is: {1}", radius, area);
                        Console.WriteLine("Type 'yes' if you would like to find the area from a different radius.");
                        string input = Console.ReadLine();
                        if (input != "yes")
                        {
                            cont = false;
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine("You must enter a radius greeater than 0.");
                    }
                }

                else
                {
                    Console.WriteLine("Unable to parse '{0}', please type a valid number.", r);
                }
            }
        }
    }
}
