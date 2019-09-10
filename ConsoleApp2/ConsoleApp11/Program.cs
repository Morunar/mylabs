using System;

namespace First_labs
{
    class Program
    {
        static void Main()
        {
            int m, h, s,time;
            Console.WriteLine("Time in seconds:");
            do
            {
               
                time = Int32.Parse(Console.ReadLine());
                
                if (time <= 0)
                {
                    Console.WriteLine("Error.Enter number again.");
                }
            } while (time <= 0);
            h = time / 3600;
            m = time / 60 % 60;
            s = time % 60;



            Console.WriteLine("Time in totall = {0}", time);
            Console.WriteLine("{0} hour,{1} minutes, {2} seconds;", h,m,s);
            Console.ReadKey();
        }
    }
}