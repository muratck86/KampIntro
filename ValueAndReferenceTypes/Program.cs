using System;

namespace ValueAndReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int number1 = 10;
            int number2 = 30;
            number1 = number2;

            number2 = 65;

            Console.WriteLine("Number1 = " + number1 + " Number2 = " + number2); //30, 65

            int[] numbers1 = new int[] { 10, 20, 30 };
            int[] numbers2 = new int[] { 100, 200, 300 };

            numbers1 = numbers2;

            numbers2[0] = 999;

            Console.WriteLine("first number in the first array: " + numbers1[0]); //999

            string string1 = "Ahmet";
            string string2 = "Murat";

            string1 = string2;
            string2 = "Maaamut";

            Console.WriteLine("First string: " + string1 + " Second string: " + string2); //"Murat", "Maaamut"



            // Value types: int, decimal, float, double, bool, string
            // value types are stored and operated in the "stack"

            // Reference types: array, class, interface
            // references are stored in stack but, values of this types are stored in "heap"
            //This line is a change in the code.. I will "push" to github after adding this line.
        }
    }
}
