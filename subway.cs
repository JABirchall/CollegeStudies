using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subway
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Subway: EAT FRESH!";

            double[,] prices = new double[,]  {{0.95, 1.10, 0.95, 1.35, 1.40, 1.95}, { 1.65, 2.05, 0.0, 0.0, 0.0, 0.0}, {0.40, 0.65, 0.75, 0.80, 0.0, 0.0} }; // initilize a array storing all the prices for the order latert on in the programm.

            Console.WriteLine("Please enter the sandwich size number\n[1] 12\" £1.65\n[2] 6\" £2.05");
            Console.Write("Option: ");
            int sizeSelection = Convert.ToInt32(Console.ReadLine());

            while (sizeSelection != 1 && sizeSelection != 2)
            {
                Console.Write("Option: ");
                sizeSelection =  Convert.ToInt32( Console.ReadLine() );
            }
            Console.Clear();

            Console.WriteLine("Please enter the bread type\n[1] Plain (£0.40)\n[2] Wheat (£0.65)\n[3] Italian (£0.75)\n[4] Cheese & herbs (£0.80)");
            Console.Write("Option: ");

            int breadSelection = Convert.ToInt32(Console.ReadLine());

            while (breadSelection < 1 || breadSelection > 4)
            {
                Console.Write("Option: ");
                breadSelection = Convert.ToInt32(Console.ReadLine());
            }
            Console.Clear();

            Console.WriteLine("Please enter the filling tyoe\n[1] Cheese & Tomato (£0.95)\n[2] Italian Bacon & Peperoni (£1.10)\n[3] Tuna & mano (£0.95)\n[4] Turkey and Ham (£1.35)\n[5] Chicken and teriyaki (£1.40)\n[6] Steak & cheese (£1.95)");
            Console.Write("Option: ");

            int fillingSelection = Convert.ToInt32(Console.ReadLine());

            while (fillingSelection < 1 || fillingSelection > 6)
            {
                Console.Write("Option: ");
                fillingSelection = Convert.ToInt32(Console.ReadLine());
            }
            Console.Clear();

            Console.WriteLine("Calculating order... Please wait.");

            double total = (prices[1, sizeSelection] + prices[2, breadSelection] + prices[0, fillingSelection]);
            Console.WriteLine("Total expected: " + total + "\nEating in: " + ( total + ( (total / 100) *5 ) ));
            Console.ReadLine();
        }
    }
}
