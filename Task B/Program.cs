using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initializes an array of 10 Student objects.
            Student[] Students = new Student[10];

            // Adds individual students with their names and ages.
            Students[0] = new Student("Zakir");
            Students[0].Age = 20;
            Students[1] = new Student("Qasim");
            Students[1].Age = 24;
            Students[2] = new Student("Tanvir");
            Students[2].Age = 21;
            Students[3] = new Student("Hamza");
            Students[3].Age = 22;
            Students[4] = new Student("Hugo");
            Students[4].Age = 20;
            Students[5] = new Student("Bob");
            Students[5].Age = 53;
            Students[6] = new Student("MnLykArham");
            Students[6].Age = 19;
            Students[7] = new Student("Dave");
            Students[7].Age = 45;
            Students[8] = new Student("Cheo");
            Students[8].Age = 63;
            Students[9] = new Student("Top G");
            Students[9].Age = 100;

            // Displays the unsorted list of students by name and age.
            Console.WriteLine("UnSorted Student Names:");
            for (int i = 0; i < Students.Length; i++)
            {
                Console.Write(Students[i].Name + ", ");
                Console.WriteLine(Students[i].Age);
            }
            Console.WriteLine("\n");

            // Sorts the array of students by name using selection sort.
            selectSortGen(Students);

            // Displays the sorted list of students by name and age.
            Console.WriteLine("Sorted Student Names:");
            for (int i = 0; i < Students.Length; i++)
            {
                Console.Write(Students[i].Name + ", ");
                Console.WriteLine(Students[i].Age);
            }

            // Initializes an array of integers.
            int[] intarray = { 192, 21, 2, 5, 234, 4, 65, 7, 43, 89, 123 };

            // Displays the unsorted list of integers.
            Console.WriteLine("\n");
            Console.WriteLine("UnSorted Array of Integers:");
            for (int i = 0; i < intarray.Length; i++)
            {
                Console.WriteLine(intarray[i]);
            }

            // Sorts the array of integers using selection sort.
            selectSortGen(intarray);

            // Displays the sorted list of integers.
            Console.WriteLine("\n");
            Console.WriteLine("Sorted Array of Integers:");
            for (int i = 0; i < intarray.Length; i++)
            {
                Console.WriteLine(intarray[i]);
            }

            // Waits for a key press before closing the console.
            Console.ReadKey();
        }

        // Implements a generic selection sort algorithm for an array of any type T.
        static public void selectSortGen<T>(T[] a) where T : IComparable
        {
            // Iterates through each element in the array.
            for (int i = 0; i < a.Length - 1; i++)
            {
                // Assumes the current element is the smallest.
                int smallest = i;

                // Compares the current element with the rest of the array to find the smallest.
                for (int j = i + 1; j < a.Length; j++)
                {
                    // Updates the smallest element if a smaller one is found.
                    if (a[j].CompareTo(a[smallest]) < 0)
                        smallest = j;
                }

                // Swaps the smallest element found with the current element.
                swap(ref a[i], ref a[smallest]);
            }
        }

        // Swaps two elements of the array.
        static void swap<T>(ref T x, ref T y) where T : IComparable
        {
            // Stores the value of x in a temporary variable.
            T temp = x;

            // Assigns the value of y to x.
            x = y;

            // Assigns the value of the temporary variable to y.
            y = temp;
        }
    }
}
