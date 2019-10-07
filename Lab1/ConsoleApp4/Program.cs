using System;

namespace First_labs
{
    class Program
    {
        static void Main()
        {
            double R1, R2, R3, result;
            Console.WriteLine("Resistor resistance");
            do
            {
                Console.WriteLine("R1 = ");
                R1 = Single.Parse(Console.ReadLine());
                Console.WriteLine("R2 = ");
                R2 = Single.Parse(Console.ReadLine());
                Console.WriteLine("R3 = ");
                R3 = Single.Parse(Console.ReadLine());
                if (R1 <= 0 || R2 <= 0 || R3 <= 0)
                {
                    Console.WriteLine("Error.Enter numbers again.");
                }
            } while (R1 <= 0 || R2 <= 0 || R3 <= 0);



            result = R1 + R2 + R3;
            Console.WriteLine("R = {0}", result);

            Console.ReadKey();
        }
    }
}