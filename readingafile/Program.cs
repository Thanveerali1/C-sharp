using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "example1.txt"; // or "example2.txt"
        if (File.Exists(filePath))
        {
            string content = File.ReadAllText(filePath);
            Console.WriteLine("File contents:");
            Console.WriteLine(content);
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}