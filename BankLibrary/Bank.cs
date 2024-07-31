using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    public abstract  class Bank
    {
        private static int counter;

        public static int Counter
        {
            get { return counter; }
            set { counter = value; }
        }

        #region Fields & Proeprties

        private string accHolderName;

        public string AccHolderName
        {
            get { return accHolderName; }
            set { accHolderName = value; }
        }

        private double balance;

        //Mixed access modifier
        public double Balance
        {
            get { return balance; }
           protected  set { 
                if (value < 1000)
                {
                    throw new BalanceException("To open an account minimum amount is Rs. 1000");
                }
                balance = value; }
        }

        private int accNo;

        public int AccountNo
        {
            get { return accNo; }
            set { accNo = value; }
        }

        #endregion

        #region Methods

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        //public virtual void Withdraw(double amount)
        //{
        //    Balance -= amount;
        //}

        public abstract void Withdraw(double amount);

        public override string ToString()
        {
            return $"Account no = {AccountNo}  Account Holder Name = {AccHolderName}  Balance = {Balance}";
        }



        #endregion

        #region Constructor
        public Bank()
        {
            Counter++;
            AccountNo = Counter;
            Balance = 1000;
        }

        public Bank(string name, double amount) : this()
        {          
            AccHolderName = name;
            Balance = amount;
        }

        public Bank(double amount)
        {
            Balance= amount;
        }


        static   Bank()
        {
            Counter = 1000;   
        }
        #endregion
    }
}
