using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konferentna_zala
{
    internal class Program
    {
        static void Main(string[] args)
        {


            var I = double.Parse(Console.ReadLine());
            var lcm = I * 100;
            if (lcm <= 3)
            {
                return;

            }
            
            var w = double.Parse(Console.ReadLine());
            var wcm = w * 100;
            if(wcm <= 100)
            {
                return;
            }
            if(wcm >= lcm)
            {
                return;
            }

            double redove = (int)Math.Truncate((lcm - 100) / 120);
            double koloni = (int)Math.Truncate(wcm / 70);
            double broi = ((redove * koloni) - 3);
            var otg = Math.Round(broi);
            Console.WriteLine(otg);
           




        }
    }
}
