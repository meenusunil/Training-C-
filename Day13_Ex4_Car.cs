using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Training__Day1
{
    internal class Day13_Ex4_Car
    {
        //Object-Oriented Programming(OOP)
        //a.Define a class representing a simple car with properties and methods.
        //b.Implement inheritance by creating a base class and a derived class.
        private string color;

    public Day13_Ex4_Car()
    {
        color = "Green";
    }
    public string Color
        {
            get { return color; }
            set {  color = value; }
         
        }
    public int Year(string model)
        {
            int year;
            switch(model)
            {
                case "A": 
                    year = 2000;
                    break;
                case "B":
                    year = 2010;
                    break;
                case "C":
                    year = 2023;
                    break;
                case "D":
                    year = 1999;
                    break;
                default:
                    year = 0;
                    Console.WriteLine("No matching year found");
                    break;
            }
            return year;
        }
    public string DriveMode(string model)
        {
            string driveMode;
            switch(model)
            {
                case "A":
                    driveMode = "Automatic";
                    break;
                case "B":
                    driveMode = "Manual";
                    break;
                case "C":
                    driveMode = "Automatic";
                    break;
                case "D":
                    driveMode = "Manual";
                    break;
                default:
                    driveMode = "Unknown";
                    Console.WriteLine("Incorrect Model");
                    break;
            }
            return driveMode;
        }

    }

    class Ford : Day13_Ex4_Car
    {
        public static void Main(string[] args)
        {
            Ford ford = new Ford();

            ford.Color = "Denim Blue";
            Console.WriteLine("Enter model to get the year: ");
            string model = Console.ReadLine();
            Console.WriteLine("Year: " + ford.Year(model));
            Console.WriteLine("Mode: " + ford.DriveMode(model));

            Console.WriteLine("Color of the car: " + ford.Color);
        }
    }
}
