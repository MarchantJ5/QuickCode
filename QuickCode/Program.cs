using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruityArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = new string[3];

            DisplayGetFruits(fruits);
            DisplayFruits(fruits);
        }

        static void DisplayGetFruits(string[] fruits)
        {
            for (int index = 0; index < fruits.Length; index++)
            {
                Console.WriteLine($"Fruit {index + 1}:");
                fruits[index] = Console.ReadLine();

            }
        }
        static void DisplayFruits(string[] fruits)
        {
            // work please
            // for (int index = 0; index < fruits.Length; index++)
            // {
            //     Console.WriteLine();
            //     Console.WriteLine($"Fruit {index+1} {fruits[index]}.");
            // }
            // Console.ReadKey();

            foreach (string fruit in fruits)
            {
                Console.WriteLine($"Fruit: {fruit}");
            }
        }
    }
}
