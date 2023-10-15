using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training__Day1
{
    //Exercise to create a class Addition with method Add that adds 2 numbers. Create another 2 classes 
    //with name AddFloat and AddInt which inherits the addition class and uses the method to add 2 numbers
    internal class Day9_Addition
    {
        public float sum;

        public float Add(float num1, float num2)
        {
            sum = num1 + num2;
            return sum;

        }
    }
}
