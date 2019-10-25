using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace arrayStatic2
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] fruit = new string[5] {"apple", "banana", "pear", "orange", "lemon"};
            

            //get the elemnt index
            int index;
            index = Array.IndexOf(fruit, "orange");

            Console.WriteLine($"The index of your element is: {index}");

            Console.WriteLine($"Please search a fruit:");
            string search = Console.ReadLine();
            index = Array.IndexOf(fruit, search);


            if(index != -1)
            {
                Console.WriteLine($"Here is your: {search}");
            }
            else
            {
                Console.WriteLine($"Not found");
            }

            


            Console.ReadLine();
        }
        
    }

}
    

