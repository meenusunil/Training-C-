using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace Training__Day1
{
    internal class Exercise_04Oct23
    {
        public int sum = 0;
        public int sumDigits(int num)
        {
            int remaindar;
            while(num > 0)
            {
                remaindar = num % 10;
                num = num / 10;
                sum = sum + remaindar;
                               
            }
            return (sum);
        }

        public void cube(int num)
        {
            int i = 0;
            double cube;
            while(i <= num)
            {
                cube = i * i * i;
                cube = Math.Pow(i, 3);
                Console.WriteLine("Number is " + i + " and cube is: " + cube);
                i++;
            }
        }

        public void updateString(string str)
        {
            for(int i=0;i<str.Length; i++)
            {
                Console.Write(str[i] + " ");
            }
        }

            
        public static void Main(string[] args)
        {
            //To display the sum of digits in a number
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Exercise_04Oct23 ex = new Exercise_04Oct23();
            Console.WriteLine("Sum of digits: " + ex.sumDigits(number));

            //Write a C# Sharp program to display the cube of an integer up to given number.
            Console.WriteLine("Enter the number to which cube should be displayed:");
            int lastNumber = Convert.ToInt32(Console.ReadLine());
            ex.cube(lastNumber);

            //Write a C# Sharp program to separate individual characters from a string.
            Console.WriteLine("Enter a string: ");
            string str = Console.ReadLine();
            ex.updateString(str);



        }
    }
}
