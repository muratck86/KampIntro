using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names2 = new List<string> { "Mahmut", "Ahmet", "Sencer", "Ökkeş", "Cebbar" };
            names2.Add("İlker");
            Console.WriteLine(names2[0]);
            Console.WriteLine(names2[5]);

        }
    }
}
