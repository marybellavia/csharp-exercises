using System;
using System.Collections.Generic;

namespace StudentRoster
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();
            string newStudent;

            Console.WriteLine("Enter your students (or ENTER to finish):");
            do
            {
                Console.Write("name: ");
                newStudent = Console.ReadLine();
                if (newStudent != "")
                {
                    // Get the student's grade
                    Console.WriteLine("student ID: ");
                    int newID = int.Parse(Console.ReadLine());

                    students.Add(newID, newStudent);
                }
            }
            while (newStudent != "");

            // Print class roster
            Console.WriteLine("\nClass roster:");
            foreach (KeyValuePair<int, string> student in students)
            {
                Console.WriteLine("Student ID: {0}, Student Name: {1}", student.Key, student.Value);
            }

            //double sum = students.Values.Sum();
            //double avg = sum / students.Count;
            //Console.WriteLine("Average grade: " + avg);

            Console.ReadLine();
        }
    }
}
