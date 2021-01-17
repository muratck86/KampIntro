using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //lets have a number of strings keeping the names of some students...
            string st1 = "murat";
            string st2 = "mahmut";
            string st3 = "hasan";

            //An arrray is a container keeps values of given type as a list. And every element in an array has a number called "index" 
            // the index is the row number of the element.
            //index number starts from 0, which means the first element in the array has the index of 0

            //---------creating an array----------

            //if we plan to insert the data to store in the array later, we have to specify the number of the elements that we will store
            //an array can not grow or shrink after creation.

            //this array has 3 storages of strings which means we can store 3 strings in it. Initially they are empty strings which we
            //will change later.
            string[] studens = new string[3];
            //now we change the strings in the students array
            studens[0] = "murat";
            studens[1] = "mahmut";
            studens[2] = "hasan";

            //we can create an array with initial data...
            string[] students2 = { "ahmet", "mehmet", "hasan" };

            //we can perform for operations on arrays..
            int counter = 0;
            foreach(var student in students2)
            {
                counter++;
                Console.WriteLine(counter + " " + student);
            }

            //We have to define the type which we will store in them and we cant put another type.
            int[] numbers = new int[] { 5, 2, 6, 3, 3, 8 };
            double[] rates = new double[10];

            //We can define multidimensional arrays like matrices.

            string[,] regions = new string[5, 3] //we have an array of 5 rows x 3 columns
            {
                {"istanbul", "izmit", "gebze"},
                {"ankara", "konya","afyon"},
                {"rize", "trabzon", "ordu"},
                {"izmir", "mugla", "manisa"},
                {"antalya", "adana", "mersin" }
            };

            Console.WriteLine("\n-------Traveling elements of a multidimensional array----------");
            for(int i = 0; i <= regions.GetUpperBound(0); i++) //travel each row which of each is also an array...
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++) //travel each element of a row...
                {
                    Console.WriteLine(regions[i, j]);
                }
            }

        }
    }
}
