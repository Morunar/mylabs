using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main()
        {

            int A, B, C, D;
            Console.WriteLine("Enter A:");
            A = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter B:");
            B = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter C:");
            C = Int32.Parse(Console.ReadLine());
            D = B * B - 4 * A * C;
            if (A == 0)
            {
                Console.WriteLine("Quadratic equation does not exist");
            }
            else if (D < 0)
            {

                Console.WriteLine("The quadratic equation does not have solution of an equation");

            }
            else if (D == 0)
            {
                Console.WriteLine("Quadratic equation has one solution");
            }
            else if (D > 0)
            {
                Console.WriteLine("Quadratic equation has two solution");
            }

            Console.ReadKey();

        }
    }
}
