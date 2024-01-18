using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uc6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hr=Convert.ToInt32(Console.ReadLine());
            int days=Convert.ToInt32(Console.ReadLine());
            int wage = 0;
            while(hr<=100 || days <= 20)
            {
                wage+=hr*days;
                hr++; days++;
            }
            Console.WriteLine(wage);
            Console.ReadLine();
        }
    }
}
