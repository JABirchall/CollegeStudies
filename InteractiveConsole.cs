using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Interactive Console";
            Console.WriteLine("Please enter your five movies one by one;");

            String[] Movies = new String[6]; // Start a new array of String type
            for(int i = 1; i <= 5; i++) Movies[i] = Console.ReadLine(); // Loop 5 times accepting User input

            Console.Clear(); // Clear the Console.

            Console.WriteLine("Your five choices was.");
            for(int i = 1; i <= 5; i++) Console.WriteLine(i + ". " + Movies[i]); // Loop 5 times printing what the user has put in.
            Console.ReadLine();
        }
    }
}
