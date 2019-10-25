using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace arrayStaticMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] colors = new string[5];

            for (int i = 0; i < colors.Length; i++)
            {
                Console.WriteLine("Enter a color:");
                colors[i] = Console.ReadLine();
            }


            //sort an array
            Array.Sort(colors);
            Console.WriteLine("\n");
            PrintArray(colors);
            Console.WriteLine("\n");

            //reverse an array
            Array.Reverse(colors);
            Console.WriteLine("Array reversed:");
            PrintArray(colors);


            Console.ReadLine();

        }

        public static void PrintArray(string[] array)
        {
  
            foreach (string item in array)
            {
                Console.WriteLine(item);
            }
        }

    }
}
