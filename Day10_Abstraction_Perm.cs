using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training__Day1
{
    class Abstraction_Perm: Abstraction_Names
    {
        public string permName;
        public int permSalary = 30000;
        public override void Names()
        {
            Console.WriteLine("Enter name: ");
            permName = Console.ReadLine();
            Console.WriteLine(permName + " - Permanent");
        }
        
        public override int salary()
        {
            //Console.WriteLine("Salary is: " + permSalary);

        }
        
        
    }
}
