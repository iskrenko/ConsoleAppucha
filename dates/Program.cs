using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dates
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var date = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null); 
               
           
            DateTime newdate = date.AddDays(1000);
            Console.WriteLine(newdate.ToString("dd-MM-yyyy"));
        }

    }
}
