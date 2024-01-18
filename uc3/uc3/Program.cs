using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uc3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int rn = rnd.Next(0, 3);
        
            if(rn == 0)
            {
                Console.WriteLine("Wage is 0");
            }
            else if(rn == 1)
            {
                Console.WriteLine("Wage is " + 8 * 20);

            }
            else
            {
                Console.WriteLine("Wage is " + 8 * 10);
            }
            Console.ReadLine();
        }
    }
}
