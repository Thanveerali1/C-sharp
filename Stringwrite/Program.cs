using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        using (StringWriter sw = new StringWriter())
        {
            sw.WriteLine("Hello, World!");
            sw.WriteLine("This is a StringWriter example.");
            Console.WriteLine("StringWriter contents:");
            Console.WriteLine(sw.ToString());
        }
    }
}