using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training__Day1
{
    class Abstraction_Contract : Abstraction_Names
    {
        public string contractName;
        public int contractSalary = 10000;
        public override void Names()
        {
            Console.WriteLine("Enter name: ");
            contractName = Console.ReadLine();
            Console.WriteLine(contractName + "- Contract");
        }

        public override int salary()
        {
            
            Console.WriteLine("Salary is: " + contractSalary);
            return(contractSalary);
        }


        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Employee type: ");
            string empType;
            Abstraction_Contract contract = new Abstraction_Contract();
            Abstraction_Perm perm = new Abstraction_Perm();
            empType = Console.ReadLine();
            Console.WriteLine("Enter qualification:");
            string qualification = Console.ReadLine();

            
            if (empType == "Permanent")
            {
                perm.Names();
                int permSalary = perm.salary();
                Console.WriteLine("Perm salary - " + permSalary);
                perm.qual = qualification;
                perm.qualification();

            }

            else if (empType == "Contract")
            {
                contract.Names();
                contract.salary();
                contract.qual = qualification;
                contract.qualification();
            }
            else
            {
                Console.WriteLine("Invalid Type");
            }
        }
    }
}
