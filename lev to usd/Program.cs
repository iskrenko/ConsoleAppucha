using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lev_to_usd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var usd = double.Parse(Console.ReadLine());
            var lev = usd * 1.79549;
            var levround = Math.Round(lev, 2);
            Console.WriteLine(levround + " BGN");

        }
    }
}
