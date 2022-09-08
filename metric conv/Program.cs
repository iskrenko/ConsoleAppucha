using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace metric_conv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());

            var vh = Console.ReadLine().ToLower();
           
            var iz = Console.ReadLine().ToLower();

            if (vh == "km")
            
                num = num / 0.001;
            
            if (vh == "mm")
                num = num / 1000;
            if (vh == "cm")
                num = num / 100;
            if (vh == "mi")
                num = num / 0.000621371192;
            if (vh == "in")
                num = num / 39.3700787;
            if (vh == "km")
                num = num / 0.001;
            if (vh == "ft")
                num = num / 3.2808399;
            if (vh == "yd")
                num = num / 1.0936133;
            if (vh == "km")
            
                num = num * 0.001;
            
            if (iz == "mm")
                num = num * 1000;
            if (iz == "cm")
                num = num * 100;
            if (iz == "mi")
                num = num * 0.000621371192;
            if (iz == "in")
                num = num * 39.3700787;
            if (iz == "km")
                num = num * 0.001;
            if (iz == "ft")
                num = num * 3.2808399;
            if (iz == "yd")
                num = num * 1.0936133;
            Console.WriteLine(num);

        }
    }
}
