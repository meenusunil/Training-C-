using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training__Day1
{
    abstract class Abstraction_Names
    {
        public string qual = "BTech";
        //public abstract int age;//Fields cannot be abstract
        public abstract void Names();
        public abstract int salary();

        public void qualification()
        {
            switch(qual)
            {
                case "BTech": Console.WriteLine("BTech graduate");
                    break;
                case "MCA":
                    Console.WriteLine("MCA");
                    break;
                case "MBBS":
                    Console.WriteLine("Doctor");
                    break;
                default: Console.WriteLine("No qualification");
                        break;
            }
        }
        /* 
        static void Main(string[] args) //Can we have main method for a
        {
            //Abstraction_Names abNames = new Abstraction_Names(); //This will throw error - no objects should be created fro abstract class
            Abstraction_Perm perm = new Abstraction_Perm();
            perm.Names();
            perm.salary();
            perm.qualification();
        }
        */

    }
}
