using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main()
        {
            int N;
            do
            {
                Console.WriteLine("Enter N:");
                N = Int32.Parse(Console.ReadLine());
                if (N <= 0)
                {
                    Console.WriteLine("Error.");
                }
            } while (N <= 0);

            int[] nums = new int[N];
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Enter nums[{0}]", i + 1);
                nums[i] = Int32.Parse(Console.ReadLine());

            }
            for (int i = N - 1; i >= 0; i--)
            {
                Console.WriteLine("Nums[{0}] ={1} ", i + 1, nums[i]);

            }
            Console.ReadKey();


        }
    }

}
