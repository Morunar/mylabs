using System;

namespace First_labs
{
    class Program
    {
        static void Main()
        {
            double  r, result_1,result_2;
            Console.WriteLine("Radius");
            do
            {
                Console.WriteLine("r = ");
                r = Single.Parse(Console.ReadLine());

                if (r <= 0)
                {
                    Console.WriteLine("Error.Enter number again.");
                }
            } while (r <= 0);



            result_1 = (4 *3.14 * Math.Pow(r, 3)) / 3;
            result_2 = 4 * 3.14 * Math.Pow(r, 2);
            Console.WriteLine("V = {0}", result_1);
            Console.WriteLine("S = {0}", result_2);

            Console.ReadKey();
        }
    }
}