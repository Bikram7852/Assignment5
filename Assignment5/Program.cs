using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingBusinessLogicLayer;
using static BankingBusinessLogicLayer.Bank;

namespace Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            //bank.Balance = 0;
            while (true)
            {
               
                Console.WriteLine("Enter Your Choice");
                Console.WriteLine("0. Deposit");
                Console.WriteLine("1. Withdraw");
                Console.WriteLine("2. Check Balance");
                ATM atm = (ATM) Convert.ToInt32(Console.ReadLine());
                if (atm == ATM.Deposit)
                {
                    Console.WriteLine("Enter Deposit Amount");
                    bank.DepositAmount = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("Enter Deposit Date");
                    bank.DepositDate = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("Enter Branch Name");
                    bank.BranchName = Console.ReadLine();
                    Console.WriteLine("Enter AccontNo");
                    bank.AccountNo = Convert.ToInt64(Console.ReadLine());
                    bank.Deposit(bank.AccountNo,bank.DepositAmount,bank.DepositDate,bank.BranchName);
                    bank.Balance = bank.DepositAmount;
                }
                else if (atm == ATM.Withdraw) 
                {
                    Console.WriteLine("Enter Withdraw Amount");
                    bank.WithdrawAmount = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("Enter Withdraw Date");
                    bank.WithdrawDate = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("Enter Branch Name");
                    bank.BranchName = Console.ReadLine();
                    Console.WriteLine("Enter AccontNo");
                    bank.AccountNo = Convert.ToInt64(Console.ReadLine());
                    if (bank.Balance > bank.WithdrawAmount)
                    {
                        bank.Withdraw(bank.WithdrawAmount, bank.WithdrawDate, bank.BranchName, bank.AccountNo);
                        bank.Balance = (bank.Balance - bank.WithdrawAmount);
                    }
                    else
                    {
                        Console.WriteLine("You have insufficient balance.");
                    }
                }
                else if (atm == ATM.Check_Balance)
                {
                    Console.WriteLine("You have Rs" + bank.Balance);
                }
                else { Console.WriteLine("You Entered Wrong Choice!"); }
            }
            
            
        }
    }
}
