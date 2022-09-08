using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace celsiusfarenhait
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var C = double.Parse(Console.ReadLine());
            var Far = (C * 9 / 5) +32;
            Console.WriteLine(Far);
        }
    }
}
