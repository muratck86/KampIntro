using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[] {"Murat can kurt", "Mahmut kara", "Semih taş", "can baş"};
            students.Length

            Console.WriteLine("for loop...");

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("Line " + i + " " + students[i]);
            }

            Console.WriteLine("\nforeach loop...");

            foreach (string item in students)
            {
                Console.WriteLine(item);
            }
        }
    }
}
