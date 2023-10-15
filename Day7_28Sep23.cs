using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training__Day1
{
    
    class Day7_28Sep23
    {

        string name;
        public string model = "Venue"; //Public field
        void yellowFruit()
        {
            Console.WriteLine("Mango");
            //Console.WriteLine(redFruit);
        }

        string redFruit;

        public Day7_28Sep23()   //Cosntructor created
        {
            Console.WriteLine("Constructor calling methods and variables");
            
            yellowFruit();
            redFruit = "Strawberry";
            Console.WriteLine(redFruit);
        }
        Day7_28Sep23(string red, string yellow)  //Parametrized constructor
        {
            Console.WriteLine("Parameterized constructor:");
            //redFruit = red;
            Console.WriteLine(red);
            Console.WriteLine(yellow);

        }
        static void Main(string[] args)

        {
            Day7_28Sep23 obj3 = new Day7_28Sep23("Raspberry", "Banana");

            Day7_28Sep23 obj = new Day7_28Sep23(); //Object number 1
            Console.WriteLine("With first object:");
            
            obj.yellowFruit();
            obj.redFruit = "Apple";
            Console.WriteLine(obj.redFruit);

            Day7_28Sep23 obj2 = new Day7_28Sep23(); //Obj number 2
            Console.WriteLine("With second object:");
            obj2.yellowFruit();
            obj2.redFruit = "Cherry";
            Console.WriteLine(obj2.redFruit);

            

        }
       
    }
    /*
    class Sample
    {
        static void Main(string[] args)
        {
            Day7_28Sep23 carObj = new Day7_28Sep23();
            Console.WriteLine(carObj.model);
        }
        

    }

 
    */
    
}
