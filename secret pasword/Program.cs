using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secret_pasword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string secret = "s3cr3t!P@ssw0rd";
            string guess = Console.ReadLine();

            if (guess == secret)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
