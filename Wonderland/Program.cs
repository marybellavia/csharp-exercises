using System;

namespace Wonderland
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string wonderland;
            string searchTerm;
            int index;

            wonderland = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            Console.WriteLine(wonderland);

            wonderland = wonderland.ToLower();

            Console.WriteLine("What string would you like to search for a string in the text?");
            searchTerm = Console.ReadLine();

            searchTerm = searchTerm.ToLower();

            index = wonderland.IndexOf(searchTerm);

            if(index >= 0)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
