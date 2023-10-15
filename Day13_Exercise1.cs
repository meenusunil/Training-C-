using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Reflection.Metadata.BlobBuilder;

namespace Training__Day1
{
    internal class Day13_Exercise1
    {
        
    //Loops
    //a.Write a program to display the first N natural numbers using a for loop.
    //b.Create a program that prints the Fibonacci sequence up to a given number N using a while loop.
    public void naturalNumbers(int n)
        {
            for(int i = 0; i <= n; i++)
            {
                Console.Write(i + " ");
            }
        }
    
    public void Fibonacci(int n)
        {
            int i =0, first =0, second=1,sum=0;
            Console.Write(first + " ");
            while(i<n-1)
            {
                Console.Write(second + " ");
                sum = first +second;
                first = second;
                second = sum;
                
                i++;
               
            }
        }

    public static void Main(string[] args)
        {
            Console.WriteLine("To print natural number- Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
           


            Day13_Exercise1 ex1 = new Day13_Exercise1();
            ex1.naturalNumbers(number);
            Console.WriteLine();
            Console.WriteLine("Enter a number to print Fibonacci series: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            ex1.Fibonacci(num2);


        }





    }
}
