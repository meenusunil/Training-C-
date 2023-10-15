using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Training__Day1
{
    internal class Day9_Inheritance_Vehicles
    {
        public string modelName;
        protected float price;
        private int year;

        protected void HyundaiModel()
        {
            if (modelName == "Creta")
            {
                Console.WriteLine("It is creta");
            }
            else if (modelName == "Venue")
            {
                Console.WriteLine("It is Venue");
            }
            else if (modelName == "i20")
            {
                Console.WriteLine("It is i20");
            }
            else
            {
                Console.WriteLine("It is a different car");
            }
            //return modelName;
        }

        public Day9_Inheritance_Vehicles()
        {
            modelName = "xxx";
            price = 1000;
            year = 2022;
        }

    }
}


