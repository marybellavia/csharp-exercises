using System;
using System.Collections.Generic;

namespace School
{
    public class Student
    {

        private const double CREDITS_PER_YEAR = 29.0;

        

        public string Name { get; set; }
        public int StudentId { get; protected set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public Student(string name,
            int studentId,
            int numberOfCredits,
            double gpa)
        {
            this.Name = name;
            this.StudentId = studentId;
            this.NumberOfCredits = numberOfCredits;
            this.Gpa = gpa;
        }

        public Student(string name, int studentId)
        : this(name, studentId, 0, 0) { }

        public void AddGrade(int courseCredits, double grade)
        {
            double newTotalGrade = (Gpa * NumberOfCredits) + (grade * courseCredits);

            NumberOfCredits += courseCredits;
            Gpa = newTotalGrade / NumberOfCredits;
        }

        public string GetGradeLevel()
        {
            if (NumberOfCredits > CREDITS_PER_YEAR * 3)
            {
                return "Senior";
            }
            else if (NumberOfCredits > CREDITS_PER_YEAR * 2 )
            {
                return "Junior";
            }
            else if (NumberOfCredits > CREDITS_PER_YEAR)
            {
                return "Sophomore";
            }
            else
            {
                return "Freshman";
            }
        }

        public override string ToString()
        {
            return $"{Name} (Credits: {NumberOfCredits}, GPA: {Gpa})";
        }

        public override bool Equals(object obj)
        {
            bool compare = false;
            Student studentObj = obj as Student;

            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            if (this.StudentId == studentObj.StudentId
                && this.Name == studentObj.Name)
            {
                compare = true;
            }

            return compare;

        }

        public static double GetCreditsPerYear()
        {
            return CREDITS_PER_YEAR;
        }
    }

    public class Course
    {
        public int CourseId { get; protected set; }
        public string Name { get; set; }
        public bool RequiresPrereq { get; set; }
        public decimal NumCredits { get; protected set; }
        public string Instructor { get; set; }
        public List<Student> ClassRoster { get; set; }

        public Course(int courseId,
            string name,
            bool requiresPrereq,
            decimal  numCredits,
            string instructor
            )
        {
            this.CourseId = courseId;
            this.Name = name;
            this.RequiresPrereq = requiresPrereq;
            this.NumCredits = numCredits;
            this.Instructor = instructor;
            this.ClassRoster = null;
        }

        public Course(int courseId, string name) :
            this(courseId, name, false, 3, "") { }

    }

    //public class Course
    //{
    //    public string CourseName { get; set; }
    //    public int CourseId { get; set; }
    //    public double CourseCredit { get; set; }
    //    public string Semester { get; set; }
    //    public int Year { get; set; }
    //    public List<Dictionary<int, string>> StudentIds { get; set; }

    //    public Course(
    //        string courseName,
    //        int courseId,
    //        double courseCredit,
    //        string semester,
    //        int year,
    //        List<Dictionary<int, string>> studentIds)
    //    {
    //        this.CourseName = courseName;
    //        this.CourseId = courseId;
    //        this.CourseCredit = courseCredit;
    //        this.Semester = semester;
    //        this.Year = year;
    //        this.StudentIds = studentIds;
    //    }
    //}

    class MainClass
    {
        public static void Main(string[] args)
        {
            int id = 0;
            int id2 = 1;
            int id3 = 2;
         
            List<Dictionary<int, string>> studentList = new List<Dictionary<int, string>>();
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(id, "Mary");

            studentList.Add(dict);

            Student st = new Student("Mary", id);

            Student st2 = new Student("Josiah", id2);

            Student st3 = new Student("Ben", id3);

            Student st4 = st;

            st.Gpa = 4.0;
            st3.NumberOfCredits = 18;
            st2.Gpa = 3.98;

            Console.WriteLine(st3.Name + " " + st3.NumberOfCredits);

            Course c0 = new Course(10, "CodeCamp", false, 14, "Ben Clark");
            Course c1 = new Course(12, "LC101");

            List<Student> roster = new List<Student>() { st, st2, st3};

            c0.ClassRoster = roster;

            Console.WriteLine(c0.NumCredits);
            Console.WriteLine(c1.NumCredits + c1.Name + c1.RequiresPrereq);

            foreach(Student stu in c0.ClassRoster)
            {
                Console.WriteLine(stu.Name);
            }

            st.AddGrade(4, 4.0);
            st.AddGrade(3, 4.0);
            st.AddGrade(3, 4.0);
            Console.WriteLine($"Student: {st.Name}. GPA: {st.Gpa}");

            Console.WriteLine("Student ToString: " + st.ToString());
            Console.WriteLine($"Student ToString: {st}");

            Console.WriteLine($"1. {st.Equals(st2)}");
            Console.WriteLine($"2. {st.Equals(st4)}");
            Console.WriteLine("3. " + st.Equals(new Student("Mary", 0)));
        }
    }
}
