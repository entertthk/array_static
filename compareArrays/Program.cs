using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace compareArrays
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] fruits = new string[5] {"apple", "banana", "pear", "orange", "lemon"};
            string[] vegetable = new string[5] {"potato", "tomato", "carrot", "onion", "cucumber"};

            Console.WriteLine("Enter something:");
            string userAnswer = Console.ReadLine();

            int index = Array.IndexOf(fruits, userAnswer);
            int index2 = Array.IndexOf(vegetable, userAnswer);

            if (index != -1)
                {
                    Console.WriteLine("its fruit");
                }
            else if (index2 != -1)
            {
                Console.WriteLine("its vegetable");
            }

            else
            {
                Console.WriteLine("its else");
            }



            Console.ReadLine();
        }

        public void search(string[] array)
        {
            
        }
    }
}
