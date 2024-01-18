using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            if (rnd.NextDouble()== 0)
                Console.WriteLine("Absent");
            else
                Console.WriteLine("Present");
            Console.ReadLine();
        }
    }
}
