using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training__Day1
{
    internal class Day11_ThreeNumbers: Day11_InterfaceSolution
    {
        public int num1, num2, num3, sum = 0, diff = 0;
        public int Add()
        {
            sum = num1 + num2 + num3;
            return (sum);
        }

        public int Subtract()
        {
            Console.WriteLine("Calling Add method from subtract method" + Add());
            diff = num1 - num2 - num3;
            return (diff);
        }
        
        public void display()
        {
            Console.WriteLine("Method implemented in derived class");
        }
        
        public static void Main(string[] args)
        {
            Day11_TwoNumbers twoNumbers = new Day11_TwoNumbers();
            Day11_ThreeNumbers threeNumbers = new Day11_ThreeNumbers();

            //Solution for 2 numbers
            Console.WriteLine("Enter 2 numbers to perform activity:");
            twoNumbers.num1 = Convert.ToInt32(Console.ReadLine());
            twoNumbers.num2 = Convert.ToInt32(Console.ReadLine());
            

            int sum = twoNumbers.Add();
            Console.WriteLine("Sum of 2 numbers: " + sum);

            int diff = twoNumbers.Subtract();
            Console.WriteLine("Difference of 2 numbers: " + diff);

            //Solution for 3 numbers
            Console.WriteLine("Enter 3 numbers to perform activity:");
            threeNumbers.num1 = Convert.ToInt32(Console.ReadLine());
            threeNumbers.num2 = Convert.ToInt32(Console.ReadLine());
            threeNumbers.num3 = Convert.ToInt32(Console.ReadLine()); ;

            int sum1 = threeNumbers.Add();
            Console.WriteLine("Sum of 3 numbers: " + sum1);

            int diff1 = threeNumbers.Subtract();
            Console.WriteLine("Difference of 3 numbers: " + diff1);

            threeNumbers.display();



        }
    }
}
