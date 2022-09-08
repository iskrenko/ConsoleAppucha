using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bonus_T
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bonusT = int.Parse(Console.ReadLine());
            double BonusScore = 0.0;

            if (bonusT > 1000)
            { 
                BonusScore = bonusT * 0.10;
            }
            else if (bonusT > 100 && bonusT < 1000)
            {
                BonusScore = bonusT * 0.20;
            }
           
               
            
            if (bonusT % 10 == 5)
                BonusScore += 2;
            if (bonusT < 100)
                BonusScore += 5;
            if (bonusT % 2 == 0)
                BonusScore += 1;
           

            Console.WriteLine(BonusScore);

            Console.WriteLine(bonusT + BonusScore);
        }
    }
}
