using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLATask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "DVLA Calculator";

            Console.Write("How many years have you been driving? ");
            Byte Years = Convert.ToByte(Console.ReadLine());
            Console.Clear();

            Console.Write("How many points do you have on your license? ");
            Byte Points = Convert.ToByte(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("----------------------LICENSE STATUS-------------------------");
            if (Years <= 2 && Points >= 6) Console.WriteLine("You are Disqualified for exceeding 6 points in 2 years");
            else if (Years > 2 && Points >= 12) Console.WriteLine("You are disqualified for exceeding 12 points");
            else if (Years > 2 && Points < 12) Console.WriteLine("You are NOT Disqulaified");
            else if (Years <= 2 && Points < 6) Console.WriteLine("You are Not Disqulaified");
            Console.WriteLine("-------------------------------------------------------------");
            Console.ReadLine();
        }
    }
}
