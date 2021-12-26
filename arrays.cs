using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 9, 4, 5, 6, 9, 2 };
            // Dispalys value of first element of array
            int y = array.First();
            {
                Console.WriteLine($"Value of first element in array is {y}");
            }

            // Displays in console value of last element of array
            int i = array.Last();
            {
                Console.WriteLine($"Value of last element in array is {i}");
            }
            // Displays value of Max element in array


            int p = array.Max();
            {
                Console.WriteLine($"Value of maximum element in array is {p}");
            }
            // Displays sum of all elements in array

            int x = array.Sum();
            {
                Console.WriteLine($"Sum of all elements in array is {x}");
            }
        }
    }
}





