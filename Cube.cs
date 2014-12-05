using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Colourful Cube";

            Log("Please enter the width of he cube: ");	// Ask for the 'Width'
            Container.Width = readInt();				// Ask for the 'Width'

            Log("Please enter the height of he cube: "); // Ask for the 'Height'
            Container.Height = readInt();				 // Ask for the 'Height'

            for (int i = 1; i <= Container.Height; i++) // Loop over the Height
            {
                for (int j = 1; j <= Container.Width; j++) // Loop over the Width.
                {

                    if (Container.Width < 16) Console.ForegroundColor = (ConsoleColor)j; // Check if the width is Less then the enumeratable CosoleColor's 
                    if (j == Container.Width) logL("*"); // Print an astrik with a new line if we have reached the end
                    else Log("*"); // Print and astrik.
                    int tempJ = j;
                }
            }
            Read(); // End and wait.
        }

        Random


        /*
			Basic methods for faster Development.
        */

        static void logL(string text) { Console.WriteLine(text); }
        static void Log(string text) { Console.Write(text); }
        static string Read() { return Console.ReadLine(); }
        static int readInt() { return Convert.ToInt32(Read()); }
        static double readDouble() { return Convert.ToDouble(Read()); }
    }

    class Container // Variable startage class.
    {
        static public int Width { get; set; }
        static public int Height { get; set; }

    }
}
