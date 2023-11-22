using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_17_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount bank = new BankAccount(543216745378, "Priyanka", 0);
            Console.WriteLine("Account Details");
            Console.WriteLine("Account Number: " + bank.Account);
            Console.WriteLine("Account Holder Name: " + bank.Name);
            Console.WriteLine("Account Balance: " + bank.Bal);
            Console.WriteLine();
            Console.WriteLine("Details After First Deposit");
            Console.WriteLine("Account Details");
            Console.WriteLine("Account Number: " + bank.Account);
            Console.WriteLine("Account Holder Name: " + bank.Name);
            bank.Deposit(50000);
            Console.WriteLine();
            Console.WriteLine("Details after First Withdrawal");
            Console.WriteLine("Account Details");
            Console.WriteLine("Account Number: " + bank.Account);
            Console.WriteLine("Account Holder Name: " + bank.Name);
            bank.Withdraw(3000);
            //bank.Deposit(9000);
            //bank.Deposit(9000);
            Console.ReadKey();
        }
    }
}
        
    

