using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training__Day1
{
    internal class Day12_ArrayList
    {
        
        //Write a program that creates an ArrayList and adds 5 different integers to it.
        //Then, display the contents of the ArrayList on the console.
       /*
        public void displayArrayList()
        {
            ArrayList disp = new ArrayList();
            disp.Add(1);
            disp.Add(4);    
            disp.Add(13);
            disp.Add(7);
            disp.Add(8);
            
            Console.WriteLine("Contents in disp array:");
            for (int i = 0;i<disp.Count;i++)
            {
                Console.WriteLine(disp[i]);
            }
            Console.WriteLine("----------");
            foreach (int i in disp)

            {

                Console.WriteLine(i);

            }

        }
        //Write a program that creates an ArrayList and adds 5 strings to it.
        //Then, remove the second element from the ArrayList and display the updated contents.

        public void removeList() 
        { 
            ArrayList remList = new ArrayList();
            Console.WriteLine("Enter 5 integers:");
            for(int i = 0; i<5;i++)
            {
                int v;
                v = Convert.ToInt32(Console.ReadLine());
                remList.Add(v);
            }

            //Console.WriteLine("Contents in remList array:");
            //for (int i = 0; i < remList.Count; i++)
            //{
            //    Console.WriteLine(remList[i]);
            //}
            remList.RemoveAt(1);
            Console.WriteLine("Updates remList array:");
            for (int i = 0; i < remList.Count; i++)
            {
                Console.WriteLine(remList[i]);
            }

        }

        //Write a program that creates an ArrayList and adds 10 random numbers to it.
        //Then, calculate and display the sum of all the numbers in the ArrayList.
        public int sumArrayList()
        {
            ArrayList sumList  = new ArrayList();
            int sum = 0;
            Console.WriteLine("Entre 10 integers");
            for(int i=0; i<10;i++)
            {
                int s = Convert.ToInt32(Console.ReadLine());
                sumList.Add(s);
            }
            
            for(int i=0; i<10; i++)
            {
                int t = Convert.ToInt32(sumList[i]);
                sum = sum + t;   
            }
            return(sum);
        }
        */

        //Write a program that creates an ArrayList and adds 5 objects of different types (e.g., int, string, bool) to it.
        //Then, iterate over the ArrayList and display the type of each object.
        public void arrayListType()
        {
            ArrayList typeList = new ArrayList();
            typeList.Add(1);
            typeList.Add(4354352342523525252);
            typeList.Add(0.00342324232);
            typeList.Add("Meenu");
            typeList.Add(true);    
            //Console.WriteLine("Enter 5 different type elements:");
            //for(int i=0; i<5; i++)
            //{
            //    string s = Console.ReadLine();
            //    typeList.Add(s);
            //}

            for (int i=0; i<5;i++)
            {
                
                Console.WriteLine("Type of element in index "+i+" is: " + typeList[i].GetType());
                //Console.WriteLine("Type of element 1 is " + typeof(typeList[i]));
            }
            foreach(int i in typeList)
            {
                Console.WriteLine(typeList[i]);
            }
        }

        public static void Main(string[] args)
        {
            Day12_ArrayList al = new Day12_ArrayList();
           // al.displayArrayList();
            //al.removeList();
            //Console.WriteLine("Sum: " + al.sumArrayList());
            al.arrayListType();
        }
    }
}
