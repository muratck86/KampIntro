using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            Course kurs1 = new Course();
            kurs1.CourseName = "Python";
            kurs1.CourseTeacher = "Murat Can Kurt";
            kurs1.NumOfStudents = 75;

            Course kurs2 = new Course();
            kurs2.CourseName = "Java";
            kurs2.CourseTeacher = "Maahmut";
            kurs2.NumOfStudents = 85;

            Course kurs3 = new Course();
            kurs3.CourseName = "C#";
            kurs3.CourseTeacher = "Ahmeeeea";
            kurs3.NumOfStudents = 75;

            Console.WriteLine(kurs1.CourseName + " : " + kurs1.CourseTeacher);

            Course[] courses = new Course[] { kurs1, kurs2, kurs3 };

            foreach (Course course in courses)
            {
                Console.WriteLine(course.CourseName + " : " + course.CourseTeacher);
            }
        }
    }

    class Course
    {
        public string CourseName { get; set; }

        public string CourseTeacher { get; set; }

        public int NumOfStudents { get; set; }
    }
}
