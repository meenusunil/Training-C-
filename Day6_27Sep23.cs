using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training__Day1
{
    internal class Day6_27Sep23
    {
       
        static void addition() //Static method with no return type
        {
            int sum = 19 + 1;
            Console.WriteLine("Addition: " + sum);
        }
        static int addition(int u, int v)
        {
            int sum = u + v;
            return sum;
        }
        static int subtract(int e, int f, string g) //Static method // These are dummy variables. x and y are called PARAMETERS
        {
            Console.WriteLine(g);
            int difference = e - f;
            return difference;
        }

        string multiplication (int h, int i) //Non static method
        {
            Console.WriteLine(h * i);
            string str = "Multiplication";
            return str;
        }

        int division(int j, int k) //Non static method
        {
           
            Console.WriteLine("Division:");
            return j / k;

        }

        static int subtract(string l, int m, int n) //Method Overloading
        {
            Console.WriteLine(l);
            return m - n;


        }
        static void Main(string[] args)
        {
            /*
            addition(); // and b are called ARGUMENTS
            

            int a = 12, b = 9;
            string str = "Subtraction";
            Console.WriteLine(subtract(a, b, str));

            Day6_27Sep23 obj = new Day6_27Sep23();//Creating new object for the class to call non static methods and variables
            int c=6, d=7;
            Console.WriteLine(obj.multiplication(c, d));

            int e = 10, f = 2;
            int div = obj.division(e, f);
            Console.WriteLine(div);

            Console.WriteLine("Method overloading: " + subtract(str, a, b)); //Method Overloading
            */

            //EXERCISE- Calling the functions in a switch statement

            Day6_27Sep23 obj = new Day6_27Sep23();
            Console.WriteLine("Enter numbers to do the operation: ");
            int num1, num2;
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the operator: ");
            char op = Convert.ToChar(Console.ReadLine());

            switch (op)
            {
                case '+':
                    Console.WriteLine("Switch - Addition: " + addition(num1, num2));
                    break;

                case '-':
                    {
                        string str2 = "Switch - Subtraction";
                        Console.WriteLine(subtract(num1, num2, str2));
                        break;
                    }

                case '*':
                    Console.WriteLine(obj.multiplication(num1, num2));
                    break;

                case '/':
                    Console.WriteLine(obj.division(num1, num2));
                    break;

                default:
                    Console.WriteLine("Invalid operator");
                    break;
            }

            firstMethod("Meenu");  //Optional Parameters
            firstMethod();    //Optional Parameters
            firstMethod("Sunil"); //Optional Parameters


        }
        
        static void firstMethod(string name = "Manu")
        {
            Console.WriteLine("Name: " + name);

        }
        
    }
}
