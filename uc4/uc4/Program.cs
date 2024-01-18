using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uc4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int rn=rnd.Next(0,3);
            
            switch(rn)
            {
                case 0:Console.WriteLine("Absent");
                    break;
                case 1:Console.WriteLine("Present full time wage is: " + 12 * 20);
                    break;
                case 2:Console.WriteLine("Present part time wage is: " + 8 * 20);
                    break;
                default:Console.WriteLine("Invalid");
                    break;
            }
            Console.ReadLine();
        }
    }
}
