using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace currency_calc_slojno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter value: ");
            var value = double.Parse(Console.ReadLine());
            Console.Write("Enter currency (USD, EUR, GBP): ");
            var input = Console.ReadLine();
            Console.Write("Enter currency to convert to (USD, EUR, GBP): ");
            var output = Console.ReadLine();

            var bgntobgn = value * 1.0;
            var bgntoUSD = value / 1.79549;
            var bgntoEUR = value / 1.95583;
            var bgntoGBP = value / 2.53405;

            var usdtoBGN = value * 1.79549;
            var usdtoEUR = (value / 1.95583) * 1.79549;
            var usdtoGBP = (value / 2.53405) * 1.79549;

            var eurtoUSD = ( value / 1.79549) * 1.95583;
            var eurtogbp = (value / 2.53405) * 1.95583;
            var eurotoBGN = value * 1.95583;

            var gbptoLeva = value * 2.53405;
            var gbptoEUR = (value * 2.53405) / 1.95583;
            var gbptoUSD = (value / 2.53405) / 1.79549;
            if (input == "BGN")
            {
                if (output == "USD")
                    Console.WriteLine(Math.Round(bgntoUSD, 2));
                if (output == "EUR")
                    Console.WriteLine(Math.Round(bgntoEUR, 2));
                if (output == "GBP")
                    Console.WriteLine(Math.Round(bgntoGBP, 2));
                if (output == "BGN")
                    Console.WriteLine(value * 1);
            }


            if (input == "USD")
            {
                if (output == "BGN")
                    Console.WriteLine(Math.Round(usdtoBGN,2));
                if (output == "EUR")
                    Console.WriteLine(Math.Round(usdtoEUR,2));
                if (output == "GBP")
                    Console.WriteLine(Math.Round(usdtoGBP, 2));
                if (output == "USD")
                    Console.WriteLine(value * 1);


            }
            if (input == "EUR")
            {
                if (output == "USD")
                    Console.WriteLine(Math.Round(eurtoUSD, 2));
                if (output == "BGN")
                    Console.WriteLine(Math.Round(eurotoBGN, 2));
                if (output == "GBP")
                    Console.WriteLine(Math.Round(eurtogbp, 2));
                if (output == "EUR")
                    Console.WriteLine(value * 1);
            }
            if (input == "GBP")
            {
                if (output == "BGN")
                    Console.WriteLine(Math.Round(gbptoLeva, 2));
                if (output == "EUR")
                    Console.WriteLine(Math.Round(gbptoEUR, 2));
                if (output == "USD")
                    Console.WriteLine(Math.Round(gbptoUSD, 2));
                if (output == "GBP")
                    Console.WriteLine(value * 1);


            }
        }
    }
}
