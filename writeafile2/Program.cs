using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "example2.txt";
        string content = "Hello, World!\nThis is written using File.WriteAllText.";
        File.WriteAllText(filePath, content);
        Console.WriteLine("File written using File.WriteAllText.");
    }
}