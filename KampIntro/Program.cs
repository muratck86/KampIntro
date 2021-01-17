using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string isim = "murat can kurt";
            int age = 34;
            double rate = 1.45;
            bool login = true;

            if (age < 35)
            {
                Console.WriteLine("the user is young.");
            }
            else if (age < 45)
            {
                Console.WriteLine("the user is at mid-ages");
            }
            else
            {
                Console.WriteLine("The user is old. ");
            }

            Console.WriteLine(isim + " " + age + " " + rate);
        }
    }
}
