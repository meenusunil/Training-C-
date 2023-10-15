using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace Training__Day1
{
    internal class Day8_29Sep23
    {
        public static string str1 = "This is a public static string"; //This will be printed with Day8_29Sep23 class
        public string str2 = "This is a public string";
        private string str3 = "This is a private string";
        protected string str4 = "This is a protected string";

        public int Add(int num1,  int num2) ////Can be accessed in outside classes
        {
            int sum = num1 + num2;
            return sum;
        }

        private int Subtract(int num1, int num2) //Can be accessed only within class Day8_29Sep23
        {
            int difference = num1 - num2;
            return difference;
        }

        protected int Multiplication(int num1, in int num2) //Can be accesseed in the inherited class
        {
            int multiplied = num1 * num2;
            return multiplied;
        }

        public Day8_29Sep23()
        {
            int num1 = 3;
            int num2 = 5;
            Console.WriteLine(num1 +num2);

        }
        /*
        static void Main(string[] args)
        {
            Day8_29Sep23 d1 = new Day8_29Sep23();
            Console.WriteLine("Enter 2 numbers: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Subtract: "+d1.Subtract(a, b));
            Console.WriteLine("String4: " + d1.str4);
            Console.WriteLine("String3: " + d1.str3);
        }
        */

    }
    
    /*
    class Calculator
    {
        static void Main(string[] args)
        {
            Day8_29Sep23 d = new Day8_29Sep23();
            Console.WriteLine("Enter 2 numbers: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sum: " + d.Add(a, b));
            //Console.WriteLine("Difference: " + d.Subtract(a, b)); // Cannot be accessed as it is private

            Console.WriteLine();
            Console.WriteLine(Day8_29Sep23.str1); //This is accessed using class name
            Console.WriteLine(d.str2); 
            //Console.WriteLine(d.str3); // This cannot be accessed as it is Private



        }
    }
    */
    class Multiplication : Day8_29Sep23  //Inherited class
    {
        static void Main(String[] args)
        {
            Multiplication m = new Multiplication();
            Console.WriteLine("Enter 2 numbers: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Multiplied: " + m.Multiplication(a,b));

            Console.WriteLine(Day8_29Sep23.str1);
            Console.WriteLine("String4: " + m.str4);
            
        }
    }
        
        
    
    
}
