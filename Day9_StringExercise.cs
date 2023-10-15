using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training__Day1
{
    //Ex- Write a program to create a function to input a string and count the number of spaces within the string
    internal class Day9_StringExercise
    {
        public static void Main(string[] args)
        {
            string inputString;
            Console.WriteLine("Enter a string:");
            inputString = Console.ReadLine();
            int strLength = inputString.Length;
            int c = 0;

            for (int i = 0; i <strLength; i++)
            {
                if (inputString[i] == ' ')
                {
                    c++;
                }

            }
            Console.WriteLine("No. of spaces within the string: " + c);
        }
    }
}
