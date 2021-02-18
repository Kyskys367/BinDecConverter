using System;
using System.Collections.Generic;
using System.Linq;

namespace dec_to_bin_reverse
{
    class Program
    {
        static int binLength;
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter an option:");
                Console.WriteLine("1.Bin to Dec");
                Console.WriteLine("2.Dec to Bin");
                string choice = Console.ReadLine();
                string number;

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Enter a number:");
                        number = Console.ReadLine();
                        binLength = number.Length;
                        Console.WriteLine(BinToDec(number, binLength));
                        break;
                    case "2":
                        Console.WriteLine("Enter a number:");
                        number = Console.ReadLine();
                        Console.WriteLine(DecToBin(Convert.ToInt32(number)));

                        break;
                    default:
                        Console.WriteLine("Choose correct oprion!!!(1 or 2)");
                        break;
                }
            }
        }
        private static double BinToDec(string num, int length)
        {
            double[] array;
            double result = 0;
            List<double> list = new List<double>();
            for (int i = 0; i < length; i++)
            {
                if ((Convert.ToInt32(num.ElementAt(i))) == 49)
                {
                    list.Add(1);
                }
                else if ((Convert.ToInt32(num.ElementAt(i))) == 48)
                {
                    list.Add(0);
                }
            }
            list.Reverse();
            array = list.ToArray();
            for (int j = 0; j < length; j++)
            {
                result += array[j] * Math.Pow(2, j);
            }
            return result;
        }

        private static string DecToBin(int num)
        {
            string result = "";
            int i = 0;
            int[] array;
            List<int> list = new List<int>();
            do
            {
                list.Add(num % 2);
                num /= 2;
                i++;
            } while (num != 1);
            list.Add(1);
            list.Reverse();
            array = list.ToArray();
            for (int j = 0; j < array.Length; j++)
            {
                result += array[j].ToString();
            }
            
            return result;
        }
    }
}
