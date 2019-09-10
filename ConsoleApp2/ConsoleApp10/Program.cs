using System;

namespace First_labs
{
    class Program
    {
        static void Main()
        {
            double V0, h,  result;
            Console.WriteLine("starting speed and height");
            do
            {
                Console.WriteLine("V0 = ");
                V0 = Single.Parse(Console.ReadLine());
                Console.WriteLine("h = ");
                h = Single.Parse(Console.ReadLine());
                if (V0 <= 0 || h <= 0)
                {
                    Console.WriteLine("Error.Enter numbers again.");
                }
            } while (V0 <= 0 || h <= 0);



            result = Math.Sqrt(((h - V0) / 9.8) * 2);
            Console.WriteLine("t = {0}", result);

            Console.ReadKey();
        }
    }
}