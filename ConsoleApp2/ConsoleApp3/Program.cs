using System;

namespace First_labs
{
    class Program
    {
        static void Main()
        {
            double U, I, result;
            Console.WriteLine("Enter I and U :");
            do
            {
                Console.WriteLine("I = ");
                I = Single.Parse(Console.ReadLine());
                Console.WriteLine("U = ");
                U = Single.Parse(Console.ReadLine());
                if (I <= 0 || U <= 0)
                {
                    Console.WriteLine("Error.Enter numbers again.");
                }
            } while (I <= 0 || U <= 0);



            result = U / I;
            Console.WriteLine("R = {0}", result);

            Console.ReadKey();
        }
    }
}