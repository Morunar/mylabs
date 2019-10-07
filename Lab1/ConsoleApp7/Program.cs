using System;

namespace First_labs
{
    class Program
    {
        static void Main()
        {
            double h, r, result;
            Console.WriteLine("Radius and Height");
            do
            {
                Console.WriteLine("h = ");
                h = Single.Parse(Console.ReadLine());
                Console.WriteLine("r = ");
                r = Single.Parse(Console.ReadLine());

                if (h <= 0 || r <= 0)
                {
                    Console.WriteLine("Error.Enter numbers again.");
                }
            } while (h <= 0 || r <= 0);



            result = (3.14 * Math.Pow(r, 2) * h)/3;
            Console.WriteLine("V = {0}", result);

            Console.ReadKey();
        }
    }
}