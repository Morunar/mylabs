using System;

namespace Lab_2
{
    class Program
    {
        static void Main()
        {
            double k, n, S, N;
            Console.WriteLine("Enter n:");
            do
            {
                n = Single.Parse(Console.ReadLine());
                if (n < 0)
                {
                    Console.WriteLine("Error.");
                }
            } while (n < 0);
            k = n * n;
            N = n * k;
            S = 0;
            if (0 <= n * n || n * n <= n * k)
            {
                for (; k <= N; k++)
                {
                    S = S + ((Math.Pow(k, 3) - 3) / (Math.Pow(-1, k) * Math.Pow(k, 2) + 5));

                }
                Console.WriteLine("S ={0} ", S);
            }
            else
            {
                Console.WriteLine("Error;");
            }
            Console.ReadKey();

        }

        

    }
}
