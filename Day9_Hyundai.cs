using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Training__Day1
{
    internal class Day9_Hyundai : Day9_Inheritance_Vehicles
    {
        public string kiaModels;
        public void kiaCars()
        {
            if (kiaModels == "Creta")
            {
                Console.WriteLine("It is same as Sonet");
            }
            else if (kiaModels == "Venue")
            {
                Console.WriteLine("It is same as Seltos");
            }
            else
            {
                Console.WriteLine("It is a different model");

            }
        }
        
        protected void HyundaiModel() //Method overriding -Polymorphism
        {
            Console.WriteLine("This is an example of method overriding");
        }
        
        public Day9_Hyundai()
        {
            price = 2000;
        }
        
        public static void Main(string[] args)
        {
            Day9_Hyundai h = new Day9_Hyundai();
            Console.WriteLine("Enter a model name:");
            h.modelName = Console.ReadLine();
            h.HyundaiModel();


            Console.WriteLine("Price:" + h.price);
           // Console.WriteLine("Year: " + h.year); //Cannot be accessed as it is private
        }
       
        
    }
}
