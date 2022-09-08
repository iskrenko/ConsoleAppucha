using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace time
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sust1 = int.Parse(Console.ReadLine());
            int sust2 = int.Parse(Console.ReadLine());
            int sust3 = int.Parse(Console.ReadLine());

            int seconds = sust1 + sust2 + sust3;
            int min = 0;

            if (seconds > 59)
            {
                min++;
                seconds = seconds - 60;

            }
            if (seconds > 59)
            {
                min++;
                seconds = seconds - 60;

            }
            if (seconds < 10)
                Console.WriteLine(min + ":" + "0" + seconds);
            else
                Console.WriteLine(min + ":" + seconds);
        }
    }
}
