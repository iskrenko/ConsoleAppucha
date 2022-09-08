using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rad_to_degree
{
    internal class Program
    {
       


        public static void Main()
        {
            var rad = double.Parse(Console.ReadLine());
            var degree = rad * (180 / Math.PI);
             var degreeees = Math.Round(degree);
            Console.WriteLine("degree = " + degreeees);



        }
    }
}
