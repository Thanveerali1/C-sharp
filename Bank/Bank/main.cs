using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            Interest account = new Interest1(1000);
            account.AddInterest(2, 5); 
            Console.WriteLine("Final Balance: " + account.GetBalance());
        }
    }
}
