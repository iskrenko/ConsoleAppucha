using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figuri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fig = Console.ReadLine();

            if (fig == "square")
            {
                double strana = double.Parse(Console.ReadLine());
                Console.WriteLine(strana * strana);
            }
            if (fig == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine(b * a);
            }
            if (fig == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                Console.WriteLine((r*r)* Math.PI);
            }
            if (fig == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                Console.WriteLine((a * h) / 2);
            }
                
                
        
        
        }
    }
}
