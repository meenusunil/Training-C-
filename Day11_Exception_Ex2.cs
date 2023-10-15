using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training__Day1
{
    //Write a program that asks user to enter a number and handles the exception, if the user enters a non-numeric value
    internal class Day11_Exception_Ex2
    {
        public static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Enter a number:");
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("User input received");
            }
              
        }
    }
}
