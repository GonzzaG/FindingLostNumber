using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Program
    {
        // Program that finds the missing number in an array of numbers

        static int number1 = 4;
        static int[] array1 = new int[] { 4, 1, 0, 2 };

        static int number2 = 10;
        static int[] array2 = new int[] { 10, 3, 5, 2, 1, 0, 7, 9, 6, 8};

        static int number3 = 6;
        static int[] array3 = new int[] { 2, 5, 6, 0, 3, 4 };
        

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the program to find de missing number. \n" +
                "Press a key to start");
            Console.ReadKey();

            Console.WriteLine(FindLostNumber(array1, number1));
            Console.WriteLine(FindLostNumber(array2, number2));
            Console.WriteLine(FindLostNumber(array3, number3));

            Console.ReadKey();

        }


        private static string FindLostNumber(int[] array, int numbers)
        {
            int expectedNumber = FindExpectedNumber(numbers);
            int realAccumulator = FindRealNumber(array); 

            //calculate de diference between 2 accumulators
            int missingNumber = expectedNumber - realAccumulator;  

            return "The missing number is the number " + missingNumber + "\n";


        }

        private static int FindRealNumber(int[] array)
        {
            //calculate the real number of the array
            int realNumber = 0;

            for(int i = 0 ; i < array.Length ; i++)
            {
                realNumber += array[i];
            }

            return realNumber;
        }

        private static int FindExpectedNumber(int numbers)
        {
            // calculate the espectated number for this array
            int expectedNumber = 0;
            
            for(int i = 0;i < numbers; i++)
            {
                expectedNumber += i + 1;
            }

            return expectedNumber;
        }

    }
}
