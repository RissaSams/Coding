using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coding
{
    class Hands_On
    {
        static void Main(string[] args)
        {

            //AverageAnswer();
            //MultiAnswer();
            
        }

        static void MultiAnswer()
        {
            Console.Write("Enter a #: ");
            string str = Console.ReadLine();
            int x;
            Int32.TryParse(str, out x);
            MultiplicationTable(x);

        }

        static void MultiplicationTable(int num)
        {
            Console.Write("    |");
            for (int i = 0; i <= num; i++)
            {
                Console.Write($"{i,4}");
            }
            Console.WriteLine();
            Console.Write("----+");
            for (int i = 0; i <= num; i++)
            {
                Console.Write($"----");
            }
            Console.WriteLine();            
            for (int i = 0; i <= num; i++)
            {
                Console.Write($"{i,3} |");
                for (int j = 0; j <= num; j++)
                {
                    Console.Write($"{i*j,4}");
                }
                Console.WriteLine();
            }
        }

        static void AverageAnswer()
        {
            
            int[] array1 = { 1, 4, 6, 1, 3, 9, 0 , -1, -6, 11};
            int[] array2 = { -9, -7 -7, -11, -7, -88, -5, -10 };
            double ave;
            
            ave = FindAverage(array1);
            Console.WriteLine("The avarge of the array is: " + ave);

            ave = FindAverage(array2);
            Console.WriteLine("The avarge of the array is: " + ave);
            

        }

        static double FindAverage(int[] arNums)
        {
            double average, total = 0; ;

            for (int i = 0; i < arNums.Length; i++)
            {
                total = arNums[i];
                Console.WriteLine("The value is: " + total);
            }
                        
            /*foreach (int num in arNums)
            {
                total += num;
            }
            */

            // average = arNums.Average();

            average = total / arNums.Length;
            return average;
        }
    }
}
