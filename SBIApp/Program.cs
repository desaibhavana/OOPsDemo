
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankLibrary;

namespace SBIApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Bank Object
            //Bank bank = new Bank();
            // bank.AccHolderName = "bhavana";
            // // bank.Balance = 100000;


            // //1     traditional
            // //  Console.WriteLine(  "AccountHolderName = " + bank.AccHolderName + " Balance = " + bank.Balance);

            // //2     place holder
            // // Console.WriteLine( "Account holder name {0} Balance = {1}", bank.AccHolderName, bank.Balance);

            // //3     string interpolation
            // Console.WriteLine(  bank);


            // Console.WriteLine(  "-------------------");

            // Bank bank1 = new Bank("User1", 50000);
            // Console.WriteLine(bank1);

            // Console.WriteLine(  "\n");
            // bank1.Deposit(40000);
            // Console.WriteLine(bank1.ToString());

            // Console.WriteLine("\n");
            // bank1.Withdraw(20000);
            // Console.WriteLine(bank1);

            // Console.WriteLine("\n");

            // //calling ToString() method
            // Console.WriteLine(  bank1.ToString());

            // Console.WriteLine("--------------------");
            // Console.WriteLine(  "Total Bank Object = " + Bank.Counter);


            // DateTime dateTime = DateTime.Now;//current date & tine

            // DateTime dateTime1 = Convert.ToDateTime("25/7/2024");

            // DateTime date = DateTime.Today; //current date

            // Console.WriteLine(  dateTime);

            // Console.WriteLine(  dateTime1);
            // Console.WriteLine(  date.ToString("d"));

            // Console.WriteLine(  "\n----------------");

            //Bank b1 = new Bank();
            //Console.WriteLine(b1.ToString());  //Bank


            //Object obj = new Object();
            //Console.WriteLine(obj.ToString());  //Object

            //obj = new Bank();
            //Console.WriteLine(obj.ToString());   //bank


            //&&        ||      !
            // Console.ReadLine();


            ////Object of Savings class
            //Savings savings = new Savings();
            //Console.WriteLine(savings);

            //Console.WriteLine(  "\n-----------------");

            //Savings savings1 = new Savings("user1", 100000, true);
            //Console.WriteLine(savings1);
            //try
            //{
            //    savings1.Withdraw(200000);
            //}
            //catch (BalanceException ex)
            //{
            //    Console.WriteLine(  ex.Message);
            //}

            //Console.WriteLine(savings1);

            //Console.WriteLine("\n------------------");

            //Savings savings2=null;
            //try
            //{
            //   savings2 = new Savings("user2", 100, true);

            //    if (savings2 != null)
            //    {
            //        Console.WriteLine(savings2.ToString()); 
            //    }

            //}
            //catch (BalanceException ex)
            //{
            //    Console.WriteLine(  ex.Message);
            //}


            //Bank bank = new Bank();

            //Savings savings = new Savings("bhavana", 100000, true);
            //Console.WriteLine(savings);
            //Console.WriteLine(savings.CalculateInterest());
            //Console.WriteLine(savings);

            //Console.WriteLine(  Bank.Counter);
            #endregion

            Savings savings = new Savings("user1", 100000, true);

            savings.SMS += Savings_SMS;

            savings.Deposit(10000);

            savings.Withdraw(50000);

            Console.ReadLine();
        }

        private static void Savings_SMS(int accNo, string tranType, double amount, double balance)
        {
            Console.WriteLine(  $"AccNo = {accNo} \nType : {tranType} \nAmount = {amount} \nBalance = {balance}");
            Console.WriteLine("------------------------");
        }


        //static void ShowBankDetail(Savings savings) { }

        //static void ShowBankDetail(Current current) { }

        // static void ShowBankDetail(Bank bank) { }

    }
}
