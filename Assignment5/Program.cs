using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingBusinessLogicLayer;

namespace Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            bank.AccountNo = 37570696888;
            bank.BranchName = "Kolkata";
            bank.DepositAmount = 10000;
            bank.DepositDate = new DateTime(2022,05,10);
            bank.WithdrawAmount = 1000;
            bank.WithdrawDate = new DateTime(2023,06,12);
            bank.Deposit(bank.DepositAmount, bank.DepositDate, bank.BranchName, bank.AccountNo);
            bank.Withdraw(bank.WithdrawAmount,bank.WithdrawDate,bank.BranchName, bank.AccountNo);
            Console.ReadLine();
        }
    }
}
