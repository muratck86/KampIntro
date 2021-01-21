using System;

namespace MyDict
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDict<string, string> dict1 = new MyDict<string, string>();

            dict1.Add("Murat", "C#");
            dict1.Add("Uygar", "scratch");
            dict1.Add("Tinda", "nenne yok");


            Console.WriteLine(dict1["Murat"]);
            Console.WriteLine(dict1["Tinda"]);

            try
            {
                dict1.Add("Uygar", "English");
            } catch (ArgumentException a)
            {
                Console.WriteLine("Bu zaten sozlukte var");
            }

            Console.WriteLine("Melek: " + dict1.Contains("Melek"));
            Console.WriteLine("Murat: " + dict1.Contains("Murat"));
            Console.WriteLine(dict1.Count);
            dict1.Remove("Murat");
            Console.WriteLine("Murat: " + dict1.Contains("Murat"));
            Console.WriteLine(dict1.Count);

            dict1.Clear();
            Console.WriteLine(dict1.Count);




        }
    }
}
