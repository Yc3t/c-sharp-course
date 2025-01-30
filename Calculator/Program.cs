#pragma warning disable CA1416 // Disable platform compatibility warnings
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.

using System;
using System.Drawing;
using System.Drawing.Imaging;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Calculator App!");
        Console.WriteLine("---------------------");

        // Get input file
        Console.Write("Enter input image path: ");
        string in1 = Console.ReadLine();

        if (!File.Exists(in1))
        {
            Console.WriteLine("Error: Input file does not exist!");
            return;


        }

        Console.Write($"It exists!. Path: {in1}");

        // Get output format
        Console.WriteLine("\nAvailable formats:");
        Console.WriteLine("1. BMP\n2. JPG\n3. PNG\n4. GIF\n5. TIFF");
        Console.Write("\nSelect output format (1-5): ");

        int selection = Console.ReadLine();











    }
}
