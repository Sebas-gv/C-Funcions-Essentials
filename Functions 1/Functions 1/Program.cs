using System.Reflection.Metadata;

namespace Functions_1
{
    internal class Program
    {
        //Functions Overload - you can have the same name, but is going to take the one that meet the parameters
        static int AddNumbers(int a, int b)
        {
            return a + b;
        }
        static int AddNumbers(int a, int b, int c)
        {
            return a + b + c;
        }



        static double AddNumbers1(double a, double b)
        {
            return a + b;
        }

        static int AddNumbers1(int a, int b, int c)
        {
            return a + b + c;
        }

        static double AddNumbers1(double a, double b, double c)
        {
            return a + b + c;
        }

        static void Main(string[] args)
        {
            int a, b, c;
            a = 5;
            b = 7;
            c = 100;
            Console.WriteLine($"{a} + {b} = {AddNumbers(a, b)}");

            Console.WriteLine($"{a} + {b} + {c} = {AddNumbers(a, b, c)}");
            //------------------------------------------------------------------//
            Console.WriteLine("--------------------------------------------------------");

            a = 2; b = 3; c = 4;

            double x = 5.5;
            double y = 6.5;
            double z = 7.5;

            Console.WriteLine($"{x} + {y} = {AddNumbers1(x, y)}");
            Console.WriteLine($"{x} + {y} + {z} = {AddNumbers1(x, y, z)}");
            Console.WriteLine($"{a} + {b} + {c} = {AddNumbers1(a, b, c)}");

            Console.WriteLine("----------------------------------------------------------");

            Console.WriteLine($"{a} + {c} = {AddNumbers1(a, c)}"); // convert the integers to double and use the double function
            Console.WriteLine($"{x} + {b} + {c} = {AddNumbers1(x, b, c)}"); // can't convert the double to int so uses the double version

        }
    }
}
