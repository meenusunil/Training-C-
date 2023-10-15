using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training__Day1
{
    internal class Day4_25Sep23
    {
        static void Main(string[] args)
        {
            /*
            int i = 1, j = 10;
            //WHILE LOOP
            while (i < 7)
            {
                Console.WriteLine(i);
                i++;
            }
            //DO WHILE LOOP
            do
            {
                Console.WriteLine(j);
                j--;
            }
            while (j > 0); 

            //FOR LOOP
            for (int k =0; k <= 10; k+=2)
            {
                Console.WriteLine(k);
            }
            
            for (int x = 3, y = 1; x+y <10; x+=2, y+=1)
            {
                Console.WriteLine(x);
            }
            int u =0;
            for(;u < 10;)
            {
                Console.WriteLine(u);
                u += 1;
            }
            

            //Nested Loop

            for (int i = 0; i < 10;  i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(j + " ");
                    if (j == 6)
                    {
                        break;
                    }
                }

                if (i == 7)
                    continue;
                Console.WriteLine();
            }
            
            //Exercise - Print the alphabets in the sentence
            Console.WriteLine("Enter a sentence: ");
            string input  = Console.ReadLine();
            int inputLength = input.Length, i =0,j =0;
            Console.WriteLine("Length: " + inputLength);
            //Console.WriteLine(input[0]);
            
            while (i < inputLength)
            {
                Console.WriteLine("While loop: "+ input[i]);
                i++;
            }

            do
            {
                Console.WriteLine("Do while loop: " + input[j]);
                j++;
            }
            while (j < inputLength);

            for(int k = 0; k< inputLength;k++ )
            {
                Console.WriteLine("For Loop: " + input[k]);

            }
            
            

            //CONTINUE
            int l = 0;
            //Console.WriteLine("Contine : ");
            while (l <= 5)
            {
                
                if (l == 3)
                {
                    l++;
                    continue;
                }
                Console.WriteLine(l);
                l++;   
                
            }
            //Break
            int m = 0;
            while (m < 10)
            {
                Console.WriteLine(m);
                m++;
                if (m == 4)
                {
                    break;
                }
            }
            */
            
            Console.WriteLine("Reverse the string");
            Console.WriteLine("Enter a sentence: ");
            string str = Console.ReadLine();
            int strLength = str.Length;
            string revString;
            char revChar;
             // To copy the string to new string 
            for (int i = strLength-1;i>=0; i--)
            {
                for(int j =0;j<=i; j++)
                {
                    //revString[j] = str[i]; //Tried to write the charactres to another string, but didnt work, and used character with write
                    //Console.WriteLine(revString[j]);
                    revChar = str[i];
                    Console.Write(revChar); 
                    break;
                }
               // Console.WriteLine(str[i]);
            }
            Console.WriteLine();

            //To reverse without copying to new string
            
            Console.WriteLine("Enter a sentence: ");
            string str3 = Console.ReadLine();
            int strLength3 = str3.Length;
            Console.WriteLine();
            for (int u = strLength3-1;u>=0;u--)
            {
                Console.Write(str3[u]);
            }


            //To break and print words in a sentence
            Console.WriteLine();
            Console.WriteLine("Enter a sentence: ");
            string str4 = Console.ReadLine();
            int strLength4 = str4.Length;
            Console.WriteLine();
            for (int i = 0;i< strLength4; i++)
            {
                //Console.WriteLine(str4[i]);
                
                if (str4[i] != ' ')
                {
                    char str5 = str4[i];
                    Console.Write(str5);
                    continue;
                }
                Console.WriteLine();
                    

            }

            /*
            

            //Additional scenarios
            //To print summ of all numbers from 1 to 20

            int sum = 0;
            for (int t = 0;t <= 20; t++)
            {
                sum = sum + t;
            }
            Console.WriteLine(sum);

            //print sum of all odd numbers
            int oddSum = 0;
            for (int t = 0; t <= 20; t++)
            {
                if(t%2 != 0)
                {
                    oddSum = oddSum + t;
                }
            }
            Console.WriteLine(oddSum);

            */
        }
    }
}
