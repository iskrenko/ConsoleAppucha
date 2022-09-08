using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chasove
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine()); 
            int m = int.Parse(Console.ReadLine());
            
            if ( m >59)
            {
                h++;
                m = m - 60;

            }
            if ((m+15) > 59)
            {
                m = m - 60;
                h++;
            }
            if (h > 23)
                h = 0;
          
           if ((m+15) <10)
            Console.WriteLine(h + ":" + "0" + (m+15));
           else
                Console.WriteLine(h + ":" +  (m + 15));
        }
    }
}
