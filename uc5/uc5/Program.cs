using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uc5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter days in month");
            int n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wage of the month is:" + n * 20);
        }
    }
}
