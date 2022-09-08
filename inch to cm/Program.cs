using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inch_to_cm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inches = ");
            var inch = double.Parse(Console.ReadLine());
            var cm = inch * 2.54;
            Console.Write("Centimeters = ");
            Console.WriteLine(cm);

        }
    }
}
