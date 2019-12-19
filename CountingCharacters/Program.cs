using System;
using System.Collections.Generic;

namespace CountingCharacters
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";
            //Console.WriteLine("What text would you like to count?");
            //string text = Console.ReadLine();
            Dictionary<string, int> counts = CountCharacters(text);
            foreach (KeyValuePair<string, int> letter in counts)
            {
                Console.WriteLine("{0} : {1}", letter.Key, letter.Value);
            }
        }

        public static Dictionary<string, int> CountCharacters(string text)
        {
            Dictionary<string, int> letterDict = new Dictionary<string, int>();
            foreach (char letter in text)
            {
                if (letterDict.ContainsKey(letter.ToString()))
                {
                    letterDict[letter.ToString()] += 1;
                }
                else
                {
                    letterDict.Add(letter.ToString(), 1);
                }
            }
            return letterDict;
        }
    }
}
