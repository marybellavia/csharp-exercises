using System;
using System.Collections.Generic;
using System.Linq;

namespace FiveLetterList
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<string> stringList = new List<string>();

            stringList.Add("love");
            stringList.Add("Dovey");
            stringList.Add("letter");
            stringList.Add("better");
            stringList.Add("gotta");
            stringList.Add("fivey");
            stringList.Add("tryna");

            List<string> fiveLetterStrings = new List<string>(FiveLetterList(stringList));
            foreach (string str in fiveLetterStrings)
            {
                Console.WriteLine(str); 
            }

        }
        public static List<string> FiveLetterList(List<string> strings)
        {
            List<string> five_strings = new List<string>();

            foreach (string str in strings)
            {
                if (str.Length == 5)
                {
                    five_strings.Add(str);
                }
                else
                {
                    continue;
                }
            }

            return five_strings;
        }
    }
}
