using System;

namespace First_labs
{
    class Program
    {
        static void Main()
        {
            double a, t, result;
            Console.WriteLine("Acceleration and Time in seconds");
            do
            {
                Console.WriteLine("a = ");
                a = Single.Parse(Console.ReadLine());
                Console.WriteLine("t = ");
                t = Single.Parse(Console.ReadLine());
                if (a <= 0 || t<=0 ||t>=60)
                {
                    Console.WriteLine("Error.Enter number again.");
                }
            } while (a <= 0 || t <= 0 || t >= 60);



            result = (a* Math.Pow(t, 2)) /2;
            
            Console.WriteLine("S = {0}", result);
            

            Console.ReadKey();
        }
    }
}