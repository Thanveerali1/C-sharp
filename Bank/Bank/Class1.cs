using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Interest:BankAccount
    {   public Interest(int time,int rate)
        { 
            int interest = (GetBalance() * time * rate) / 100;
            deposit(interest);
            System.Console.WriteLine("Interest added: " + interest);
        }
    }
}
