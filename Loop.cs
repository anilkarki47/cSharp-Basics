using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Learning
{
    internal class Loop
    {
        static void Main(string[] args)
        {
            //for loop
            int i = 0;

            for (i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }

            //while loop

            while (i <= 5) {
                Console.WriteLine(i);
                i++;

            }

            Console.ReadLine();
        }


    }
}
