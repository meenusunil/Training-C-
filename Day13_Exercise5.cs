using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Training__Day1
{
    internal class Day13_Exercise5
    {
        //Exception Handling
        //Write a program that demonstrates the use of try-catch blocks to handle exceptions.
        public int division(int a, int b)
        {
            int q=0;
            try
            {
                q = a / b;
                return q;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return q;
            }
            finally
            {
                Console.WriteLine("Finally ");
                //return q;
            }
            
        }

        //File I/O
        //a.Read data from a text file and display it on the console.
        public void fileHandling()
        {
            string path = @"C:\Users\mesunil\source\repos\Training- Day1\Training- Day1\Files\Day13.txt";
            //FileStream fs =  File.Create(path);
            if(File.Exists(path))
            {
                Console.WriteLine("File Available");
            }
            else
            {
                Console.WriteLine("File not available");
            }

            
            //File.Open(path, FileMode.Open);
            string str = "Welcome to file handling";
            //File.WriteAllText(path, str);
            //File.AppendAllText(path, " This is the appended text");
        Console.WriteLine(File.ReadAllText(path));

        }

        public static void Main(string[] args)
        {
            /*Console.WriteLine("Enter 2 numbers: ");
            int a =Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            
           Console.WriteLine("Q: " + ex.division(a, b));*/
            Day13_Exercise5 ex = new Day13_Exercise5();
            ex.fileHandling();
        }
    }

 


       
    }
