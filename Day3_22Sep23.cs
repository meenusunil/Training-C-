using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Training__Day1
{
    internal class Day3_22Sep23
    {
        static void Main(string[] args)
        {
            string str1 = "Welcome to day3";
            char ch = 'A';
            // str1 = char.ToString(ch);
            //Ternary Operator-
            int f = 5, g = 5;
            string output = f > g ? "f is big" : g > f ? "g is big" : "both are equal";
            Console.WriteLine(output); 
            //conditional statements
   
            
            //SWITCH
            Console.WriteLine("enter a character: ");
            string str = Console.ReadLine();
            char character = Convert.ToChar(str);
            //Giving separate conditions in switch statement
            switch (character)
            {
                case 'a':
                    Console.WriteLine("It is a vowel");
                    break;
                case 'e':
                    Console.WriteLine("It is a vowel");
                    break;
                case 'i':
                    Console.WriteLine("It is a vowel");
                    break;
                case 'o':
                    Console.WriteLine("It is a vowel");
                    break;
                case 'u':
                    Console.WriteLine("It is a vowel");
                    break;
                default:
                    Console.WriteLine("It is a consonant");
                    break;

            }

            //Putting all conditions together in switch statement
            switch (character)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("It is a vowel");
                    break;
                default: Console.WriteLine("It is a consonant");
                    break;

            }
            //If else statements using logical operators
            if (character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u')
            {
                Console.WriteLine("It is a vowel");
            }
            else
                Console.WriteLine("It is a consonant");

            //If else statement
            Console.WriteLine("Enter a number:");
            string str2  = Console.ReadLine();
            int input = Convert.ToInt32 (str2);
            if (input%2 == 0) 
            {
                Console.WriteLine("It is an even number");
            }
            else
            {
                Console.WriteLine("It is an odd number");
            }
           
            //Calcualtor using switch statement.
            Console.WriteLine("Calculator ");
            Console.WriteLine("Enter an operator: ");
            string operatorString = Console.ReadLine();
            char mathOperrator = Convert.ToChar (operatorString);
            Console.WriteLine("Enter a 2 numbers: ");
            int a = Convert.ToInt32 (Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            switch (mathOperrator)
            {
                case '+':
                    int sum = a + b;
                    Console.WriteLine("Add: " + sum);
                    break;
                case '-':
                    int subtract = a - b;
                    Console.WriteLine("Subtraction: " + subtract);
                    break;
                case '/':
                    float divide = a / b;
                    Console.WriteLine("Division: " + divide);
                    break;
                case '%':
                    int remainder = a % b;
                    Console.WriteLine("Remainder: " + remainder);
                    break;
                default: Console.WriteLine("Invalid operator");
                    break;

            }

            



        }

    }
}
