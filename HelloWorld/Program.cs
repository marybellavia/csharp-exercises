using System;
using HelloWorld.People;
using HelloWorld.Calc;

namespace HelloWorld
{

    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello {0}!", name);

            //string name = "mary";
            //name = name.ToUpper();
            //Console.WriteLine(name);

            //Person person = new Person();

            //person.Name = "Mary";
            //person.Age = 29;
            //person.HasPet = true;

            //person.Greeting();
            //int result = Calculator.Add(5, 10);
            //Console.WriteLine(result);

            //string name01 = "Daniel";
            //string name02 = "John";
            //string name03 = "Jane";
            //string name04 = "Tobi";

            //string[] names = new string[4];
            //names[0] = "Daniel";
            //names[1] = "John";
            //names[2] = "Jane";
            //names[3] = "Tobi";

            //Console.WriteLine(names[0]);

        }
    }

}
