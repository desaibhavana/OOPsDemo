using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    public    class Savings : Bank, IInterest
    {
		private bool isSalaryAcc;

		public bool IsSalaryAccount
		{
			get { return isSalaryAcc; }
			set { isSalaryAcc = value; }
		}

        public Savings()
        {            
        }

        public Savings(string name, double amount, bool isSalaryAcc) : base(name, amount)
        {
            IsSalaryAccount = isSalaryAcc;
        }

        public override string ToString()
        {
            return base.ToString() + " Is Salary Account = " + IsSalaryAccount;
        }


        public override void Withdraw(double amount)
        {
            this.amount = amount;
            //if salary acc then 0 balance

            //if non salary acc then 1000 balance

            if (IsSalaryAccount == true)
            {
                if ((Balance - amount) >= 0)
                {
                    transactionType = "Withdraw";
                    // base.Withdraw(amount);
                    Balance -= amount;
                }
                else
                {
                    throw new BalanceException("Balance not enough");
                }
            }
            else  // if no salary account
            {
                if ((Balance - amount) >= 1000)
                {
                    transactionType = "Withdraw";
                    
                    Balance -= amount;
                }
                else
                {
                    throw new BalanceException("Balance not enough");
                }
            }
        }

        public double CalculateInterest()
        {
            double interestAmt = Balance * .1;
            Balance += interestAmt;
            return interestAmt;
        }
    }

    
}
