using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs6
{
    class Program
    {
        static void Main()
        {
            object N;
            int J;
            List<object> types = new List<object>() {1,2,4,"lal","hello",true,1.2,'A'} ;


            do
            {
                Console.WriteLine("Enter J(the number of items you want to enter)");
                J = Int32.Parse(Console.ReadLine());
                if (J <= 0)
                {
                    Console.WriteLine("Error;");
                }

            } while (J <= 0);
           
            for (int i = 0;i < J;i++){
               N = (Console.ReadLine());
               types.Add(N);
            }

            
            for (int i = 0; i < types.Count; i++)
            {
                Console.WriteLine("Тип элемента {0} = {1}",types[i], types[i].GetType());
                
            }




            Console.ReadKey();

        }
    }
}
