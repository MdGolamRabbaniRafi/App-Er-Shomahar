using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] p = new int[3];
            p[0] = 1;
            p[2] = 3;
            p[4] = 9;
            foreach(int n in p)
            {
                Console.Write(n);
            }
        }
    }
}
