using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training__Day1
{
    internal class Day2_21Sep23
    {
        static void Main(string[] args)
        {
            const int a = 5; //Declaring a constant variable
            Console.WriteLine("Declaring a constant variable");
            Console.WriteLine(a);
            string firstName = "Meenu", surName = " Sunil";
            Console.WriteLine("Welcome " + firstName); //concatenating strings
            Console.WriteLine(firstName + surName);

            //TypeCasting
            int c = 5;
            long d = c; // Implicit
            Console.WriteLine(d);

            long e = 999999442344352344;
            int f = (int)e; //Explicit
            Console.WriteLine("Type Casting");
            Console.WriteLine(f);
            Console.WriteLine(e);
            Console.WriteLine("");

            //To get input from user
            Console.WriteLine("enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Input from user: " + name);

            //Arithmetic Operator
            Console.WriteLine("Arithmetic Operator");
            int o = 6;
            o++;
            Console.WriteLine("Increment operator - "+ o);
            o--;
            Console.WriteLine("Decrement operator - " + o);

            //Assignment Operator
            Console.WriteLine("Assignment Operator");
            int x = 5, y = 7;
            x += y;
            Console.WriteLine(x);
            Console.WriteLine(y);

            //Comparison Operators
            Console.WriteLine("Comparison Operators");
            Console.WriteLine(x < y);

            //Logical Operators
            int q = 3, p = 5;
            Console.WriteLine("Logical Operators");
            Console.WriteLine(q == p && q < p);


            //String functions
            Console.WriteLine("String Functions");
            //To get length of string - text.length
            Console.WriteLine("Length of str1 is :" + name.Length);
            
            //To convert to upper or lower case - text.toUpper() toLower()
            string str4 = "lower";
            string strUpper = str4.ToUpper();
            Console.WriteLine("Upper case: " + strUpper);
            string str3 = "HELLO";
            string strLower = str3.ToLower();
            Console.WriteLine("Lower case: " + strLower);

            //To concatenate - str1 +str2 or 
            //string.Concat(str1, str2)
            string concateString = string.Concat(str4, str3);
            Console.WriteLine(concateString);

            //Interpolation
            string str1 = "Today is the ", str2 = "second day of training";
            string interpolatedString = $"Interpolated string - {str1} {str2}";
            Console.WriteLine(interpolatedString);


            //String Index
            Console.WriteLine("Index of y is " + str1.IndexOf("y"));
            Console.WriteLine("Character in the index number 4 is " + str1[4]);
            
            //Substring
            Console.WriteLine("Substring is: " + str2.Substring(4));
           

        }
    }
}
