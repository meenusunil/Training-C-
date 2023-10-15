using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training__Day1
{
   
    //Write a program that divides two numbers entered by the user and handles exception if denominator is zero

    internal class Day11_Exception_Ex1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 numbers to divide: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            try
            {
                int q = num1 / num2;
                Console.WriteLine("Quotient: " + q);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Occured!!    "+ ex.Message);
            }
            finally
            {
                Console.WriteLine("Division completed");
            }

        }
    }
}
