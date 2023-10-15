using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Training__Day1
{
   
    class Class2
    {
        string model1;
        string model2;
        string model3;
        Class2()
        {
            model1 = "Venue";
            model2 = "Creta";
            model3 = "i20";
        }
        void Car1(string model4 = "BMW")
        {
            Console.WriteLine(model4);
        }
        void Cars(string model)
        {
            if (model == "Creta") 
            {
                Console.WriteLine("It is creta");
            }
            else if(model == "Venue")
            {
                Console.WriteLine("It is Venue");
            }
            else if(model == "i20")
            {
                Console.WriteLine("It is i20");
            }
            else
            {
                Console.WriteLine("It is a different car");
            }
        }

        static void Main(string[] args)

        {           
            Class2 c = new Class2();
            Console.WriteLine(c.model1 + " " + c.model2 + " " + c.model3);
            c.Cars(c.model1);
            c.Cars("Kia");

            c.Car1();
            c.Car1("Audi");

            Console.WriteLine("Enter a model: ");
            c.Cars(Console.ReadLine());
        }

    }


}




