using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
namespace Training__Day1
{
    internal class Exercise_11Oct
    {/*
        Program 1 : Login page(user name and password are correct please show the message login successful. If it is wrong please show the message user name and password are wrong
        Program 2 : Write a program to find the count of children (age from 1to 14 ), Youth( 15 to 24 ) Adults( 25 to 50) Seniors 50 above.
        Program 3 : Find the interest?
Program 4 : Store 3 Country(India, china, Pakistan ) and check  that the user entered sentence contains country name
    */
        public string country1 = "India";
        public string country2 = "China";
        public string country3 = "Pakistan";

        public void CheckCountry(string sentence)
        {
            string str = " ";
            for(int i =0; i < sentence.Length;i++)
            {
                if (sentence[i] != ' ')
                {
                    str = sentence;
                    continue;
                    
                }
                if (str == country1 || str == country2 || str == country3)
                {
                    Console.WriteLine("Entered sentence contains the country specified");
                }
                else
                {
                    Console.WriteLine("Country not in the sentence");
                }


            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence which contains a country: ");
            string str = Console.ReadLine();
            Exercise_11Oct ex = new Exercise_11Oct();
            ex.CheckCountry(str);
        }

    }
}
