using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Training__Day1
{
    internal class Day13_FileHandling
    {
        public static void Main(string[] args)
        {
            string str = "Welcome to File handling module";
            File.WriteAllText("Day12.txt", str);

            string readStr = File.ReadAllText("Day12.txt");
            Console.WriteLine(readStr);

            string appStr = "This is day13";
            File.AppendAllText("Day12.txt", appStr);
            Console.WriteLine("After appending");

            string readStr1 = File.ReadAllText("Day12.txt");
            Console.WriteLine(readStr1);

            Console.WriteLine(File.Exists("Day12.txt"));


        }
    }
}
