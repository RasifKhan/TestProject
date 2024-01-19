using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i<10)
            {
                Console.WriteLine(i);
                i++;
            }


            Console.WriteLine("Another Loop");

            int y = 0;
            while (y < 10)
            {
                y++;
                Console.WriteLine(y);
              
            }
        }
    }
}
