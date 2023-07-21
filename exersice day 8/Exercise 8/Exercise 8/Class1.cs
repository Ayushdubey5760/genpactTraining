using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_8
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());

            int[] array = new int[size];
            Console.WriteLine("Enter {size} elements: ");

            for (int i=0; i<size; i++)
            {
                Console.WriteLine("Element {i+1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(array, delegate (int a, int b)
            {
                return a.CompareTo(b);
            });
            Console.WriteLine("Sorted Array:");
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }

            Console.ReadLine();
        }
    }
}
