using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training__Day1
{
    //Exercise to create a class Addition with method Add that adds 2 numbers. Create another 2 classes 
    //with name AddFloat and AddInt which inherits the addition class and uses the method to add 2 numbers
    internal class Day9_AddInt: Day9_Addition
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 integers: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            int num2 = Convert.ToInt32(Console.ReadLine());

            Day9_AddInt sumInt = new Day9_AddInt();
            sumInt.sum = sumInt.Add(num1, num2);

            Console.WriteLine("Sum of 2 int numbers: " + sumInt.sum);

        }
    }
}
