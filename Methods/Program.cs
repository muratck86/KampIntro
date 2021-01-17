using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product prod1 = new Product();
            prod1.Name = "Apple";
            prod1.Price = 6;
            prod1.Description = "Amasya Apple";

            Product prod2 = new Product();
            prod2.Name = "Watermelone";
            prod2.Price = 55;
            prod2.Description = "This is a watermelone..";

            Product[] products = new Product[] { prod1, prod2 };

            foreach (Product prod in products)
            {
                Console.WriteLine(prod.Name + " " + prod.Price + " " + prod.Description);
            }

            Console.WriteLine("\n-------------------Methods----------------------");

            //instantiations 
            CartManager cartManager = new CartManager();
            cartManager.AddToCart(prod1);
            cartManager.AddToCart(prod2);


            Console.WriteLine("\n---------void methods------------");

            //Method does not return a value
            Add1(10, 5);

            Console.WriteLine("\n-------------methods returning value-----------");
            //Method returning value
            //sum2 value will be 15 after this method call
            //We can use var instead of int
            var sum2 = Add2(10, 5);
            Console.WriteLine("Add2 method call: 10 + 5 = " + sum2);
            //sum2 will be 30 after this method call, because the second parameter is not given and the method will use the 
            //default value of the missing parameter which is 20
            sum2 = Add2(10);
            Console.WriteLine("Add2 method call(20 is the default value of the second number): 10 + 20 = " + sum2);


            Console.WriteLine("\n-------------ref keyword with the methods-----------");
            //ref keyword
            //Let we have two variables
            int number1 = 5;
            int number2 = 7;

            //now we pass values of these variables to our Add3 method.
            //the values of the variables above at the 53th and 54th lines are copied to the parameters of the method.
            //the assignment of "number1 = 50;" in the body (see line 98) of this method won't effect our variable of
            //number1 at the 53th line.
            int sum3 = Add3(number1, number2);
            Console.WriteLine("Add3: number1 out of the method: " + number1);

            //if we want to enable the operations to effect the value type variables which are out of the methods,
            //we add ref keyword to both definition and invocation of our method.
            int sum4 = Add4(ref number1, number2);
            Console.WriteLine("Add4: number1 out of the method: " + number1);

            Console.WriteLine("\n-------------out keyword with the methods-----------");
            //out keyword works almost same as ref keyword but it has 2 differences,
            //ref keyword needs an initialized variable, which means the ref variable has to have an initial value.
            //out keyword doesn't need an initial value. Additionally it already has to assign a value to the given variable name.
            //for example, the code below is commented out because won't work:

            //int number1;
            //int number2 = 8;
            //sum4 = Add4(ref number1, number2);

            //But this usage with out is valid:

            int num1;
            int num2 = 3;
            int sum5 = Add5(out num1, num2);
            Console.WriteLine("Add5: num1 out of the method: " + num1);

            //By the way, the variable used with out, or ref keywords does not need to have same name as in the methods.
            int x = 7;
            int y = 19;
            sum5 = Add4(ref x, y);
            Console.WriteLine("Add4: x variable out of the method: " + x);

            int k;
            sum5 = Add5(out k, y);
            Console.WriteLine("Add5: k variable out of the method: " + k);

            Console.WriteLine("\n-------------method overloading-----------");
            //We can define methods with the same name with different parameter count or types as long as C# can distinguish
            //which of the same name methods to invoke by considering the parameters.
            Console.WriteLine("Method with 2 parameters: " + Multiply(3, 9));
            Console.WriteLine("Method with 3 parameters: " + Multiply(3, 7, 17));

            Console.WriteLine("\n-------------methods with params keyword-----------");

            //what if we want a method that returns sum of some arbitrary count of numbers?
            //method definition with params keyword allows us to invoke a method with flexible count of parameters.
            //params can be used with additional other parameters, in this case the keyword with params have to be the last one.

            //calculates and returns sum of the given values
            Console.WriteLine("Method with params usage: " + Total(5, 1, 2, 3, 4, 5, 6, 7, 8));

            //calculates sum of the given values other than first one and multiplys sum by the first parameter which is x
            Console.WriteLine("Method with int x + params: " + Total2(5, 1, 2, 3, 4, 5, 6, 7, 8)); 

        } /* ==========================================End of Main===========================================*/

        //Method does not return a value, it just prints the result and does not store the result in somewhere after method run completes.
        static void Add1(int x, int y)
        {
            Console.WriteLine(x + y);
        }

        //Method returning value
        //We replace int with void, now we use return keyword to get the value that we desired the method to give us. So by placing int instead of void,
        //we declare that the method will return a value of type int.
        // note that this time we don't see a console message after calling this method.
        //But, we can assign the result (the returning value) of this method to a variable as seen above...
        static int Add(int x, int y)
        {
            int result = x + y;
            return result;
        }

        //Giving default values to the parameters of the methods. (the parameters which have default values must be placed after the 
        //parameters without default values.)
        //If a parameter has a default value, we can invoke (call) that method without giving a value to that parameter. In this case, the method
        //will use the default value of the parameter to make the calculation. See above...
        static int Add2(int x, int y = 20)
        {
            return x + y;
        }


        //ref keyword
        //the parameter names are variable names we define them while defining methods. Such as Add2(int x, int y) method. Here, x and y are parameters 
        //and they are just variable names DEFINED IN THE NAMESPACE of the method. Which means they are not recognized out of the method. So, there may be
        //variables with the same name as in the methods and they will be treaten separately. See, definition below and the demonstration of the below method is
        //shown above.
        static int Add3(int number1, int number2)
        {
            number1 = 50; //here, the number1 is a variable of Add3 method and it is not valid int the outer space of the method.
            Console.WriteLine("Add3: number1 in the method: " + number1);
            return number1 + number2;
        }

        static int Add4(ref int number1, int number2)
        {
            number1 = 50; //here, the number1 out of the method will also be changed.
            Console.WriteLine("Add4: number1 in the method: " + number1);
            return number1 + number2;
        }

        //out keyword with the methods
        static int Add5(out int num1, int num2)
        {
            num1 = 11; //Actually, it does'n matter that num1 had an initial value before or not, becaues it has to be set in the method.
            return num1 + num2;
        }

        //overloading methods
        static int Multiply(int x, int y)
        {
            return x * y;
        }

        static int Multiply(int a, int b, int c)
        {
            return a * b * c;
        }

        static int Total(params int[] numbers)
        {
            int sum = 0;
            foreach(int number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        static int Total2(int x, params int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return x * sum;
        }

    }
}

//Do not repeat yourself!...
// DRY!
//Clean Code
// Best Practice
