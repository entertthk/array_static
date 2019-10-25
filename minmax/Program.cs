using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace minmax
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = new int[5] { 11, 12, -5, 9, 1 };

            int min = Int32.MaxValue;
            int max = Int32.MinValue;

            foreach (int number in numbers)
            {
                if(number < min)
                {
                    min = number;
                }

                if (number > max)
                {
                    max = number;
                }

            }

            Console.WriteLine($"Minimum value is {min}");

            

            

            Console.WriteLine($"Maximum value is {max}");

            Console.ReadLine();


        }
    }
}
