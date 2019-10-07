using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main()
        {
            int m, n, k;
            do
            {
                Console.WriteLine("Enter m:");
                m = Int32.Parse(Console.ReadLine());
                if (m <= 0)
                {
                    Console.WriteLine("Error.");
                }
            } while (m <= 0);


            do
            {
                Console.WriteLine("Enter n:");
                n = Int32.Parse(Console.ReadLine());
                if (n <= 0)
                {
                    Console.WriteLine("Error.");
                }
            } while (n <= 0);


            int[,] myArr = new int[m, n];


            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("myArr[{0},{1}]", i, j);
                    myArr[i, j] = Int32.Parse(Console.ReadLine());
                    
                }
                Console.WriteLine();
            }


            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0}\t", myArr[i, j]);

                }
                Console.WriteLine();
            }


            do
            {
                Console.WriteLine("Enter k:");
                k = Int32.Parse(Console.ReadLine());
                if (k <= 0 || k >= n)
                {
                    Console.WriteLine("Error.");
                }
            } while (k <= 0 || k >= n);


            int Sum, Mul;

            Sum = 0;

            Mul = 1;


            for (int i = 0; i < m; i++)
            {
                   Sum += myArr[i, k];
                   Mul *= myArr[i, k];
                        
                
            }

            Console.WriteLine("Summ = {0}", Sum);
            Console.WriteLine("Mul= {0}", Mul);



            Console.ReadKey();

        }
    }
}
