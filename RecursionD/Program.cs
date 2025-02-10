using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionD
{
    internal class Program
    {
        static int counter = 0;
        static void PrintList(int num)
        {
            counter++;
            num = num - 1;
            if (num > 1)
            {
                Console.WriteLine(counter);
                PrintList(num);
            }
            Console.WriteLine(num);
        }
        static int[] items = new int[] { 0, 2, 5, 8, 11, 15, 19, 21, 28, 33 };
        static void ProcA(int number, int entry)
        {
            Console.WriteLine("entry -" + entry);
            if (number != items[entry])
            {
                ProcA(number, entry + 1);
            }
            else
            {
                Console.WriteLine("output " + entry);
            }
        }
       
        static void Main(string[] args)
        {
            //int abc = 4;
            //PrintList(abc);
            //Console.WriteLine("finished");
            ProcA(66, 1);
            Console.ReadLine();
        }
    }
}
