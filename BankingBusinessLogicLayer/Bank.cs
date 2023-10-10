using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingBusinessLogicLayer
{
    public class Bank
    {
        public enum ATM
        {
            Deposit,
            Withdraw,
            Check_Balance
        }
        public float DepositAmount { get; set; }
        public DateTime DepositDate { get; set; }
        public string BranchName { get; set; }
        public long AccountNo { get; set; }
        public DateTime WithdrawDate { get; set; }
        public float WithdrawAmount { get; set; }
        public float Balance { get; set; }
        public void Deposit(float amt, DateTime depositDate, string branchName, long accNo)
        {
            DepositAmount = amt;
            DepositDate = depositDate;
            BranchName = branchName;
            AccountNo = accNo;
            Console.WriteLine("Account No: " + AccountNo+ " Branch Name: " + BranchName+" Deposit Amount: " + DepositAmount + " Deposit Date: "+DepositDate);
        }
        public void Deposit(long accNo, float amt, DateTime depositDate, string branchName)
        {
            DepositAmount = amt;
            DepositDate = depositDate;
            BranchName = branchName;
            AccountNo = accNo;
            Console.WriteLine("Account No: " + AccountNo + " Branch Name: " + BranchName + " Deposit Amount: " + DepositAmount + " Deposit Date: " + DepositDate);
        }
        public void Deposit(long accNo, float amt, DateTime depositDate)
        {
            DepositAmount = amt;
            DepositDate = depositDate;
            AccountNo = accNo;
            Console.WriteLine("Account No: " + AccountNo + " Branch Name: " + BranchName + " Deposit Amount: " + DepositAmount + " Deposit Date: " + DepositDate);
        }
        public void Withdraw(float amt, DateTime withdrawDate, string branchName, long accNo)
        {
            WithdrawAmount = amt;
            WithdrawDate = withdrawDate;
            BranchName = branchName;
            AccountNo = accNo;
            Console.WriteLine("Account No: " + AccountNo + " Branch Name: " + BranchName + " Withdraw Amount: " + WithdrawAmount + " Withdraw Date: " + WithdrawDate);
        }
    }
}
