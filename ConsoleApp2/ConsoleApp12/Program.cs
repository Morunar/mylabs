using System;
namespace First_labs
{
    class Program
    {
        static void Main()
        {
            double V1, V2, t1, t2,t3;
            Console.WriteLine("Enter temperature and volume first fluid and second fluid ");
            do
            {
                Console.WriteLine("t1 = ");
                t1 = Single.Parse(Console.ReadLine());
                Console.WriteLine("V1 = ");
                V1 = Single.Parse(Console.ReadLine());
                Console.WriteLine("t2 = ");
                t2 = Single.Parse(Console.ReadLine());
                Console.WriteLine("V2 = ");
                V2 = Single.Parse(Console.ReadLine());
                if (V1 <= 0 || V2 <= 0)
                {
                    Console.WriteLine("Error.Enter volume again.");
                }
            } while (V1 <= 0 || V2 <= 0);



            t3 = (V1 * t1 + V2 * t2) / (V1 + V2);
            Console.WriteLine("Totall temperature = {0}", t3);

            Console.ReadKey();
        }
    }
}