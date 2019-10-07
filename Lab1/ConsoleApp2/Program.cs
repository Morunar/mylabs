using System;

namespace First_labs
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Oscillation period of a mathematical pendulum.");
            double l, result;
            Console.WriteLine("Enter lenght:");
            do
            {
                
                l = Single.Parse(Console.ReadLine());
                if (l <= 0)
                {
                    Console.WriteLine("Error.Enter number again.");
                }
            } while (l <= 0);


         
            result =2*3.14*Math.Pow(l/9.8,2);
            Console.WriteLine("T = {0}",result);

            Console.ReadKey();
        }
    }
}