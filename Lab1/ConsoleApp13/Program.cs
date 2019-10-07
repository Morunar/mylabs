using System;
namespace First_labs
{
    class Program
    {
        static void Main()
        {
            double n, r, a, result;
            Console.WriteLine("Enter N(number of sides) and R ");
            do
            {
                Console.WriteLine("R = ");
                r = Single.Parse(Console.ReadLine());
                Console.WriteLine("N = ");
                n = Single.Parse(Console.ReadLine());

                if (r <= 0 || n <= 0)
                {
                    Console.WriteLine("Error.Enter volume again.");
                }
            } while (r <= 0 || n <= 0);



            a = 2 * r * Math.Sin((Math.PI/180)*(180 / n));
            result = n * a;
            Console.WriteLine("P = {0}", result);

            Console.ReadKey();
        }
    }
}