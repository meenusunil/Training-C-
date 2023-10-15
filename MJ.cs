using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training__Day1
{
        class Parent
        {
            public void Pname()
            {
                Console.WriteLine("This is an Inheritance parent class");
            }
            public static int flat(int x)
            {



                Console.WriteLine("Enter the flat number: ");
                return x;
            }



            public static void Main(string[] args)
            {
                string a = Console.ReadLine();
                int fl = Convert.ToInt32(a);
                flat(fl);
                Parent par = new Parent();
                par.Pname();
                string[] Fmember = { "Nitheesh", "Venu", "Goutham", "Naveen", "Naveen S" };
                foreach (string f in Fmember)
                {

                    Console.WriteLine(f);
                }




            }
        }
   
}
