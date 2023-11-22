using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_17_1
{
    public class BankAccount
    {
        readonly long AccountNumber;
        string AccountHolderName;
        double Balance;

        public BankAccount(long AccountNumber, string AccountHolderName, double Balance)
        {
            this.AccountNumber = AccountNumber;
            this.AccountHolderName = AccountHolderName;
            this.Balance = Balance;
        }
        public long Account { get { return AccountNumber; } }
        public string Name { get { return AccountHolderName; } }
        public double Bal { get { return Balance; } }

        public void Deposit(int depositedamount)
        {
            Console.WriteLine($"Deposited Amount: " + depositedamount);
            Balance = Balance + depositedamount;
            Console.WriteLine("Balance after Deposit: " + Balance);
        }

        public void Withdraw(int withdrawamount)
        {
            Console.WriteLine("Withrawal Amount: " + withdrawamount);
            Balance = Balance - withdrawamount;
            Console.WriteLine("Balance after Withdrawal: " + Balance);
        }
    }
}