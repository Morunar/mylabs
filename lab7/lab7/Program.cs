using System;

namespace Lab7
{
    internal class Program
    {
        private static void ArrayReverse<L>(ref L[] array)
        {
            L[] reversArray = new L[array.Length];
            int k = 0;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                reversArray[k] = array[i];
                k++;
            }
            array = reversArray;
        }

        private static string StringReverse(string str)
        {
            string Str = "";
            char[] array = str.ToCharArray();
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Str += (array[i]);
            }
            return Str;
        }

        private static string NumberReverse(int number)
        {
            string Str = "";
            string numberStr = number.ToString();
            char[] array = numberStr.ToCharArray();
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Str += (array[i]);
            }
            return Str;
        }

        private static string NumberReverse(double number)

        {
            return NumberReverse(number);
        }


        private static string DoubleReverse(double number)
        {
            string numberStr = number.ToString();
            int Index = number.ToString().IndexOf(',');
            string firstPart = "";
            string secondPart = "";
            for (int i = Index - 1; i >= 0; i--)
            {
                firstPart += numberStr.Substring(i, 1);
            }
            for (int i = numberStr.Length - 1; i > Index; i--)
            {
                secondPart += numberStr.Substring(i, 1);
            }
            string finalStr = firstPart + secondPart;
            return finalStr;
        }

        private static string DoubleReverse(string numberStr)
        {
            int Index = numberStr.IndexOf(',');
            string firstPart = "";
            string secondPart = "";
            for (int i = Index - 1; i >= 0; i--)
            {
                firstPart += numberStr.Substring(i, 1);
            }
            for (int i = numberStr.Length - 1; i > Index; i--)
            {
                secondPart += numberStr.Substring(i, 1);
            }
            string finalStr = firstPart + secondPart;
            return finalStr;
        }

        private static string DevidedStrReverse(string str)
        {
            return DoubleReverse(str);
        }
        private static void Main(string[] args)
        {
            int number = 0;
            int[] arrayNumbers = { 2, 15, 5, 7, 13121, 98 };
            string[] arrayString = { "advice", "help", "mark", "loro" };
            object[] arrayObject = { "number", "array", 1323, 12f, "liz" };






            Console.Write("Input your number, which you want flip over: ");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Error.Input again pls: ");
                }
            }
            Console.WriteLine($"Your number: {NumberReverse(number)}");

            Console.Write("Input your string, which you want flip over: ");
            string str;
            str = Console.ReadLine();
            Console.WriteLine($"String reverse : {StringReverse(str)}");




            Console.Write("Input double number : ");
            double numberDouble = 0;
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out numberDouble))
                {
                    if (numberDouble.ToString().Contains(","))
                    {
                        Console.WriteLine("This is number but not tyoe of double, input again");
                    }
                    else
                    {
                        break;
                    }
                    break;
                }
                else
                {
                    Console.Write("Error.Input number type of double again:");
                }
            }

            Console.WriteLine($"Double number reverse : {DoubleReverse(numberDouble)}");

            Console.WriteLine("Input string with two parts wwith special character -\",\":");
            string hardStr = "";
            while (true)
            {
                hardStr = Console.ReadLine();
                if (hardStr.Contains(",") && hardStr.IndexOf(',') != 0 && hardStr.IndexOf(',') != hardStr.Length - 1)
                {
                    break;
                }
                else
                {
                    Console.Write("Error.Input again : ");
                }
            }
            Console.WriteLine($"Reverse string with two parts : {DevidedStrReverse(hardStr)}");


            Console.WriteLine("Work of array reverse function : ");
            ArrayReverse<int>(ref arrayNumbers);
            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                Console.Write(arrayNumbers[i] + " ");
            }
            Console.WriteLine();

            ArrayReverse<string>(ref arrayString);
            for (int i = 0; i < arrayString.Length; i++)
            {
                Console.Write(arrayString[i] + " ");
            }
            Console.WriteLine();

            ArrayReverse<object>(ref arrayObject);
            for (int i = 0; i < arrayObject.Length; i++)
            {
                Console.Write(arrayObject[i] + " ");
            }
            Console.ReadKey();
        }


    }
}