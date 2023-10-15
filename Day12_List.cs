using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training__Day1
{
    internal class Day12_List
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(3);
            list.Add(6);
            list.Add(2);
            list.Add(1);
            list.Add(4);
            list.Add(6);
            list.Insert(0, 44);
            list.Insert(5, 9);

            for (int i=0; i<list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.WriteLine("-------------------------");

            // list.Remove(2);
            //list.RemoveAt(4);
            // list.RemoveAll(i => i ==6);
            //list.Sort();
            list.Reverse();
           // Console.WriteLine(list.Count);
            //Console.WriteLine(list.Capacity);
            Console.WriteLine("-------------------------");

            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
