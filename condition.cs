using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Learning
{
    internal class condition
    {

        static void Main(string[] args)

        {
            int a = 10, b = 20;

            if (a > b)
            {
                Console.WriteLine("A is greater then B.");
            }else
            {
                Console.WriteLine("B is greater then A.");
            }

            Console.ReadKey();
        }
    }
}
