using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lesson9
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = new int[100];
            double sum = 0;
            

            for(int i= 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1;
            }

            foreach(int num in numbers)
            {
                sum = sum + num;
            }

            Console.WriteLine(sum);
            

            double average = sum / numbers.Length;
            Console.WriteLine(average);

            Console.ReadLine();
        }
    }
}
