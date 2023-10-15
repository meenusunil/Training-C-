using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training__Day1
{
    //Create a class called "Rectangle" with two private fields: "length" and "width".
    //Implement two constructors, one with no parameters that sets both length and width to 0,
    //and another that accepts length and width as parameters and initializes the fields accordingly.
    //Add a method called "CalculateArea" to the Rectangle class that returns the
    //area of the rectangle(length* width). Implement method overloading to allow the CalculateArea
    //method to be called with no parameters, in which case it calculates the area of a square(length* length).
    internal class Day11_Ex_Rectangle
    {
        int length, width, area;

        Day11_Ex_Rectangle()
        {
            length = 0;
            width = 0;
            //Console.WriteLine("Non - parameterized const:" + length + "  " + width);
        }
        Day11_Ex_Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
            //Console.WriteLine("parameterized const:" + length + "  " +  width);
        }
        public double CalculateArea()
        {
            area = length * length;
            return area;
        }

        public double CalculateArea(int len, int wid)
        {
            area = len * wid;
            return area;
        }

        public static void Main(string[] args)
        {
            Day11_Ex_Rectangle rectangle = new Day11_Ex_Rectangle();
            
            Console.WriteLine("Enter length and width");
            int length, width;
            length = Convert.ToInt32(Console.ReadLine());
            width = Convert.ToInt32(Console.ReadLine());
            Day11_Ex_Rectangle rec = new Day11_Ex_Rectangle(length, width);

            Console.WriteLine("Area from non parameterized method: " + rec.CalculateArea());

            
            Console.WriteLine("Area from parameterized method: " + rectangle.CalculateArea(length,width));

        }


    }
}
