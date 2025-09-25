using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "example1.txt";
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine("Hello, World!");
            writer.WriteLine("This is written using StreamWriter.");
        }
        Console.WriteLine("File written using StreamWriter.");
    }
}