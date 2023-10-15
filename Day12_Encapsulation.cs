using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Training__Day1
{
    internal class Day12_Encapsulation
    {
        private string password;
        private int pin;

        public string Password
        {
            get { return password; }
            set { password = value; }
            
        }

        public int Pin
        {
            get { return pin; }
            set { pin = value; }
        }

    }

    class user
    {
        public static void Main(string[] Args)
        {
            Day12_Encapsulation encap = new Day12_Encapsulation();
            encap.Password = "xxx";
            encap.Pin = 1323;
            Console.WriteLine(encap.Password);
            Console.WriteLine(encap.Pin);

        }
    }


    
}

