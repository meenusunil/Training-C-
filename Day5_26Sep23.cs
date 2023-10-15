using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training__Day1
{
    internal class Day5_26Sep23
    {
        static void Main(string[] args)
        {
            int[] marks; // declaring array
            marks = new int[5]; //Allocating memory for the array using 'new'
            marks[0] = 66;
            marks[1] = 99;
            //Console.WriteLine(marks[0]);
            string[] name1 = new string[5]; // Another way to declare and allocate memory

            int[] id = { 45, 46, 77, 56, 77 }; //Initializing array during declaration


            //Console.WriteLine(id[3]);
            /*
            //To print all values in an array.
            for(int i = 0; i < id.Length; i++)
            {
                Console.WriteLine(id[i]);
            }

            //Read array from user
            int[] numbers = new int[5];
            //Console.WriteLine("Enter the numbers: ");


            //MULTI DIMENSIONAL ARRAY
            int[,] multi = { { 1, 2, 3 }, { 4, 5, 6 } };
            int[,] multi1 = new int[2, 3];
            
            Console.WriteLine("Multi dimension: " + multi[1, 2]);
            //To get row count - getlength
            Console.WriteLine("No of rows: " + multi.GetLength(0));
            Console.WriteLine("No of columns: " + multi.GetLength(1));
            Console.WriteLine("lenght: " + multi.Length); //This will give total length.
            
            //To print all elements in multi dimension array

            for (int i = 0;i < multi.GetLength(0); i++)
            {
                for(int j = 0;j < multi.GetLength(1); j++)
                {
                    Console.Write(multi[i,j] + " ");

                }

                Console.WriteLine();
            }
            
            

            //EXERCISE 1 - a. Create 1 string array, give values and copy that to 2nd string array
            //            b. Create an int array, and copy the values reversed to new int array

            string[] name = { "Isha", "Ajith", "Manu", "Meenu", "Soumya" };
            int[] rollNumber = { 1, 2, 3, 4, 5 };
            string[] name2 = new string[5];
            int[] rollNumber2 = new int[5];

            for (int i = 0; i < name.Length; i++)
            {
                name2[i] = name[i];
            }
            Console.WriteLine("------Second array before reversing:----------");
            for (int i = 0; i < name2.Length; i++)
            {
                Console.WriteLine(name2[i]);
            }
            Console.WriteLine("----------Second array after reversing:--------");
            string[] revString = new string[6];
            for(int k=0,l=name2.Length-1; k<=revString.Length-1 && l>=0; k++, l--)
            {
                revString[k] = name2[l];
            }
            for(int k=0; k<= revString.Length-1; k++)
            {
                Console.WriteLine(revString[k]);
            }
            

            //Reversing numbers string
            int u, v;
            for (u = 0, v = rollNumber2.Length - 1; u <= rollNumber.Length-1 && v>= 0; u++,v--)
                {
                    rollNumber2[v] = rollNumber[u];
                  
            }
            Console.WriteLine("-----RollNumber------");
            for (u = 0; u < rollNumber.Length; u++)
            {
                Console.WriteLine(rollNumber[u]);
            }
            Console.WriteLine("-----RollNumber2------");
            for(v = 0; v < rollNumber2.Length;v++)
            {
                Console.WriteLine(rollNumber2[v]);
            }
            

            //EXERCISE 2 - Create a string array- initalize and add values and display it.
            //Get a word from user and check if it matches the one in the array

            //string[] fruits = new string[] { "Apple", "Banana", "Cherry", "Mango", "Blueberries" };
            string[] fruits = { "Apple", "Banana", "Cherry", "Mango", "Blueberries" };
            for (int i=0; i<fruits.Length; i++)
            {
                Console.WriteLine(fruits[i]);
            }
            Console.WriteLine("Enter a fruit:");
            string userFruit = Console.ReadLine();
            int output =0;
            for (int i=0;i<fruits.Length;i++)
            {
                if (fruits[i] == userFruit)
                {
                    output = 1;
                    //Console.WriteLine("It is available");
                   // break;
                }

            }
            if (output == 1)
            {
                Console.WriteLine("It is available");
            }
            else
            {
                Console.WriteLine("It is not available");

            }

            //FOREACH LOOP
            foreach(string fruit in fruits)
            {
                   Console.WriteLine(fruit);
            }
            int[] amount = { 33, 45, 67, 22, 11 };
            foreach(int number in amount)
            {
                Console.WriteLine(number);
            }
            */

            //ARRAY METHODS
            //Sort method
            Console.WriteLine();
            Console.WriteLine("Sorting Array: ");
            //int[] sortArray = { 4, 1, 5, 7, 2, 1, 0 };
            string[] sortArray = { "banana", "dragonfruit", "pineapple", "cherry", "apple" };
            Array.Sort(sortArray);
            for(int i = 0; i<sortArray.Length; i++)
            {
                Console.WriteLine(sortArray[i]);
            }
            /*

            //Max, Min and sum methods
            Console.WriteLine("Maximum value: " + sortArray.Max() + "  Minimum value: " + sortArray.Min() + "  Sum: " + sortArray.Sum());
            

            //Read array input from user-
            string[] weight = new string[5];
            Console.WriteLine("Enter 5 weights to store in an array");
            for(int i = 0; i < 5; i++)
            {
                weight[i] = Console.ReadLine();
            }
            Console.WriteLine("Sorted Weight array:");
            Array.Sort(weight);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(weight[i]);
            }

            //MULTI DIMENSIONAL ARRAYS

            int[,] multi = new int[2,2];

            multi[0, 0] = 1;
            multi[1, 0] = 2;
            multi[0, 1] = 3;
            multi[1, 1] = 4;
            for(int i=0;i < multi.GetLength(0); i++)
            {
                for(int j=0;j<multi.GetLength(1); j++)
                {
                    Console.Write(multi[i,j] + " ");
                }
                Console.WriteLine();
            }
            

            //Adding mutli-dimension arrays

            int[,] array1 = { { 1, 2, 3 }, { 4, 5, 6 } };
            int[,] array2 = { { 1, 2, 3 }, { 4, 5, 6 } };

            int[, ] sumArray = new int[2, 3];
            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for(int j=0; j<array1.GetLength(1);j++)
                {
                    sumArray[i, j] = array1[i, j] + array2[i, j];
                }
                    

            }
            for (int i = 0; i < sumArray.GetLength(0); i++)
            {
                for (int j = 0; j < sumArray.GetLength(1); j++)
                {
                    Console.Write(sumArray[i, j] + " ");
                }
                Console.WriteLine();
            }

            */

        }
    }
}
