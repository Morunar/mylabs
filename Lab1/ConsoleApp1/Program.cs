using System;

namespace First_labs
{
    class Program
    {
        static void Main()
        {
            double U,R, result;
            Console.WriteLine("Enter U and R :");
            do
            {
                Console.WriteLine("U = ");
                U = Single.Parse(Console.ReadLine());
                Console.WriteLine("R = ");
                R = Single.Parse(Console.ReadLine());
                if (U <= 0 || R <=0 )
                {
                    Console.WriteLine("Error.Enter numbers again.");
                }
            } while (U <= 0 || R <= 0);



            result = U /R;
            Console.WriteLine("I = {0}", result);

            Console.ReadKey();
        }
    }
}