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
            int J,K;
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
            Console.WriteLine("K its data type.");
            Console.WriteLine("K = 0,this type Bool.");
            Console.WriteLine("K = 1,this type Char.");
            Console.WriteLine("K = 2,this type String.");
            Console.WriteLine("K = 3,this type Int.");
            Console.WriteLine("K = 4,this type Double.");

            for (int i = 0;i < J;i++){
                do
                {
                    Console.WriteLine("Enter K:");
                    K = Int32.Parse(Console.ReadLine());
                    if (K < 0 || K > 4)
                    {
                        Console.WriteLine("Error;");
                    }
                } while (K < 0 || K > 4);
                switch (K)
                {
                    case 0:
                        Console.WriteLine("Enter element:");
                        N = Convert.ToBoolean(Convert.ToInt32(Console.ReadLine()));
                        types.Add(N);
                        break;
                    case 1:
                        Console.WriteLine("Enter element:");
                        N = Char.Parse(Console.ReadLine());
                        types.Add(N);
                        break;
                    case 2:
                        Console.WriteLine("Enter element:");
                        N = (Console.ReadLine());
                        types.Add(N);
                        break;
                    case 3:
                        Console.WriteLine("Enter element:");
                        N = Int32.Parse(Console.ReadLine());
                        types.Add(N);
                        break;
                    case 4:
                        Console.WriteLine("Enter element:");
                        N = Double.Parse(Console.ReadLine());
                        types.Add(N);
                        break;

                }
               
            }

            
            for (int i = 0; i < types.Count; i++)
            {
                Console.WriteLine("Тип элемента {0} = {1}",types[i], types[i].GetType());
                
            }
            int SumInt, SumChar, SumBool, SumString, SumDouble;
            SumInt = 0;
            SumChar = 0;
            SumBool = 0;
            SumString = 0;
            SumDouble = 0;
            for (int i = 0; i < types.Count; i++)
            {
              if (types[i] is string) 
                {
                    SumString++;
                }
              else if (types[i] is int)
                {
                    SumInt++;
                }
              else if (types[i] is bool)
                {
                    SumBool++;
                }
              else if (types[i] is char)
                {
                    SumChar++;
                }
              else if (types[i] is double)
                {
                    SumDouble++;
                }
           }

            Console.WriteLine("Количество элементов типа String = {0}",SumString);
            Console.WriteLine("Количество элементов типа Int = {0}", SumInt);
            Console.WriteLine("Количество элементов типа Char = {0}", SumChar);
            Console.WriteLine("Количество элементов типа Bool = {0}", SumBool);
            Console.WriteLine("Количество элементов типа Double = {0}", SumDouble);

            Console.ReadKey();

        }
    }
}
