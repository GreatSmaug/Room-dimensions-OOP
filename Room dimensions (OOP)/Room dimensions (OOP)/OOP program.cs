using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Room_dimensions__OOP_
{
    class Program
    {
        static void Main()
        {

            // User input
            float l = 0; // Length
            float w = 0; // Width
            float h = 0; // Height
            Boolean isNum = false;

            while (isNum == false)
            {
                Console.Clear();
                Console.WriteLine("~ Input dimensions in metres ~");
                Console.Write("Length: ");
                string length = Console.ReadLine();
                Console.Write("Width: ");
                string width = Console.ReadLine();
                Console.Write("Height: ");
                string height = Console.ReadLine();

                // Make sure input is acceptable (numbers only)
                try
                {
                    l = float.Parse(length);
                    w = float.Parse(width);
                    h = float.Parse(height);
                    if ((l > 0) & (h > 0) & (h > 0)) // Checks if all values are positive
                    {
                        isNum = true;
                    }
                    else
                    {
                        // If numbers are not >0 (i.e. impossible length)
                        Console.WriteLine("Positive values only");
                        Console.ReadKey();
                    }
                }

                // If input is not acceptable
                catch
                {
                    Console.WriteLine("Please enter numerical values");
                    Console.WriteLine("[Press any key to continue]");
                    Console.ReadKey();
                };
            }
            // When user input is acceptable:
            Console.WriteLine("=======================");
            var room1 = new Room(l, w, h); // Give Room() the parameters from the user

            // Floor area
            Console.Write("Floor area is ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(room1.floorArea);
            Console.ResetColor();
            Console.WriteLine(" m²");

            // Wall area
            Console.Write("Total wall area is ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(room1.wallArea);
            Console.ResetColor();
            Console.WriteLine(" m²");
            Console.Write("Assuming 10m² per litre, amount of paint needed is ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write((room1.wallArea)*10);
            Console.ResetColor();
            Console.WriteLine(" litres");

            // Volume
            Console.Write("Room volume is ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(room1.volume);
            Console.ResetColor();
            Console.WriteLine(" m³");
            Console.ReadKey();
        }
    }
}

