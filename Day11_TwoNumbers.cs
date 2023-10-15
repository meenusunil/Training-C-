using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training__Day1
{
    internal class Day11_TwoNumbers: Day11_InterfaceSolution
    {
        public int num1, num2, sum = 0, diff = 0;
        public int Add()
        {
            sum = num1 + num2;
            return (sum);
        }

        public int Subtract()
        {
            diff = num1 - num2;
            return (diff);
        }

    }
}
