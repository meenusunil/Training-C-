using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training__Day1
{
    internal class Day13_Exercise3
    {
        //Functions/Methods
    //a.Create a function to calculate the factorial of a given number.
 
    public double Factorial(int num)
        {
            double factorial = 1;
            int i =1;
            if(num > 0)
            {
                while (i <= num)
                {
                    factorial = i * factorial;
                    i++;
                }
            }
            else
                factorial = 0;

            return (factorial);
        }
        //b.Write a function that checks if a string is a palindrome.
    public bool Palindrome(string str)
        {
            bool b = false;
            int len = str.Length;
            str = str.ToLower();
            for(int i=0,j=len-1; i<=len-1 && j>=0;i++,j--)
            {
                if (str[i] == str[j])
                {
                    b = true;
                }
                else
                    b = false;
            }
            return b;
           
        }
    
    public static void Main(string[] args)
        {
            Console.WriteLine("Enter numbr to get factorial: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Day13_Exercise3 ex = new Day13_Exercise3();
            Console.WriteLine("Factorial of " + number + " is: " + ex.Factorial(number));

            Console.WriteLine("Enter a string: ");
            string str = Console.ReadLine();
            if (ex.Palindrome(str))
            {
                Console.WriteLine("It is a palindrome");
            }
            else
                Console.WriteLine("Not a palindrome");
            
        }

    }
}
