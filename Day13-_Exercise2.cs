using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training__Day1
{
    internal class Day13__Exercise2
    {
        //Arrays
        //a.Declare and initialize an array of integers, and then find the sum of its elements.
        //b.Write a program to find the largest and smallest elements in an array.
        //= { 2, 3, 4, 5, 1, 3, 4, 66, 4, 8 };


        public int[] intArray =new int[20];
        public int f;
        public Day13__Exercise2()
        {
            //intArray = { 2, 3, 4, 5, 1, 3, 4, 66, 4, 8 };
            intArray[0] = 1; intArray[1] =2; intArray[2] =3;

            f = 110;
        }
        
        public void display()
        {
            int sum = 0;
            int len = intArray.Length;
            for (int i = 0;i< len -1; i++)
            {
                sum = sum + intArray[i];
            }
            Console.WriteLine(sum);

        }
        
        public int MaxArray(int[] array)
        {
            int max=0;
            max = array.Max();
            return max;
        }

        public int MinArray(int[] array)
        {
            int min = 0;
            min = array.Min();
            return min;
        }

        
        

        public static void Main(string[] args)
        {
            Day13__Exercise2 ex2 = new Day13__Exercise2();
            Console.WriteLine("F: " + ex2.f);
            for (int i = 0; i < ex2.intArray.Length; i++)
            {
                Console.WriteLine(ex2.intArray[i]);
            }
            Console.WriteLine("Sum of integers in array:");
            ex2.display();
            
            Console.WriteLine("Enter 10 numbers");
            int[] array1 = new int[10];
            for(int i=0;i<10;i++)
            {
                array1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Maximum value: " + ex2.MaxArray(array1));
            Console.WriteLine("Minimum value: " + ex2.MinArray(array1));
            
        }

    }
}
