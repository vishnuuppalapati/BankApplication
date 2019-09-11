using BankAppSample.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankAppSample
{
    public class Transaction
    {
        ////public int CreateTransaction(string AccountNumber, string AccountHolderName, decimal DepositAmount, decimal WithdrawAmount, DateTime DateOfTransaction)
        ////{
        ////    return 0;
        ////}
        //public int CreateTransaction(string AccountNumber,TransactionType type, decimal amount, decimal charges, DateTime creationDate)
        //{
        //    return 0;
        //}
        //public TransactionDetails GetTransactionDetails(string transactionId)
        //{
        //    return new TransactionDetails();
        //}
        //public List<TransactionDetails> GetAllTransactions()
        //{
        //    return new List<TransactionDetails>();
        //}
        ////public int UpdateTransactions(string AccountNumber,string transactionId, TransactionType type, decimal amount, decimal charges, DateTime modfieddate)
        ////{
        ////    return 0;
        ////}
        ////public int DeleteTransaction(string transactionId)
        ////{

        ////    return 0;
        ////}
        /////public int CreateTransaction(string AccountNumber, int TransactionId, decimal DepositAmount, decimal WithdrawAmount,DateTime DateofTransaction)
        //{
        //    UserTransactions userTransaction = new UserTransactions();

        //    return 0;
        //}
        public int CreateTransaction(long AccountNumber, TransactionType Type, decimal Amount, decimal Charges = 10)
        {           
            if (Type==TransactionType.Deposit)
            {
                Console.WriteLine("Enter Deposit Amount");
                using (var Context = new BankContext())
                {
                    var Transaction = Context.UserRegistrations.Where(a => a.AccountNumber == AccountNumber).FirstOrDefault();
                    UserTransactions userTransaction = new UserTransactions();
                    userTransaction.AccountNumber = Transaction.AccountNumber;
                    decimal Depositamount = decimal.Parse(Console.ReadLine());
                    userTransaction.DepositAmount = Depositamount+Charges;
                    decimal AvailBalance = Transaction.Balance + Depositamount;
                    userTransaction.AvailBal = AvailBalance;
                    userTransaction.DateofTransaction = DateTime.Now;
                    Context.SaveChanges();
                }
            }
           else if(Type==TransactionType.Withdrawl)              
            {
                Console.WriteLine("Enter Withdrawl Amount");
                using (var Context = new BankContext())
                {
                    var Transaction = Context.UserRegistrations.Where(a => a.AccountNumber == AccountNumber).FirstOrDefault();
                    UserTransactions userTransaction = new UserTransactions();
                    userTransaction.AccountNumber = Transaction.AccountNumber;
                    UserRegistration userRegistration = new UserRegistration();
                    if (userRegistration.Balance >= Amount)
                    {
                        userTransaction.WithdrawAmount = Amount + Charges;
                        decimal AvailBalance = Transaction.Balance - Amount;
                        userTransaction.AvailBal = AvailBalance;
                        userRegistration.Balance = AvailBalance;
                        userTransaction.DateofTransaction = DateTime.Now;
                        Context.SaveChanges();
                        Console.WriteLine("Withdrawn successfully");
                    }
                    else
                    {
                        Console.WriteLine("InSufficient Funds Available");
                    }    
                }
            }
            return 0;
        }
        public TransactionDetails GetTransactionDetails(int TransactionId)
        {
            using (var Detailscontext = new BankContext())
            {
                var TransactionDetails = Detailscontext.UserTransaction.Where(s => s.TransactionId == TransactionId).FirstOrDefault();
                IEnumerable<Tuple<long, decimal, DateTime>> authors = new[] { Tuple.Create(TransactionDetails.AccountNumber, TransactionDetails.AvailBal, TransactionDetails.DateofTransaction) };

                //For Creating Table Format..
                Console.WriteLine(authors.ToStringTable(
                  new[] { "Account Number", "Amount",  "DateofTransaction" },
                  a => a.Item1, a => a.Item2, a => a.Item3));
            }
            return new TransactionDetails();
        }
        public List<TransactionDetails> GetTransactions(long AccountNumber)
        {
            using (var ALLDetailscontext = new BankContext())

            {
                //var AllTransactions = ALLDetailscontext.UserRegistrations.Where(x => x.AccountNumber == AccountNumber).FirstOrDefault();
                var Transactions = ALLDetailscontext.UserTransaction.Where(x => x.AccountNumber == AccountNumber).ToList();
                foreach (var alldetails in Transactions)
                {
                    var TransactionDetails = ALLDetailscontext.UserTransaction.Where(s => s.AccountNumber == AccountNumber).ToList();
                    IEnumerable<Tuple<long, decimal, DateTime>> authors = new[] { Tuple.Create(alldetails.AccountNumber, alldetails.AvailBal,
                        alldetails.DateofTransaction) };

                    //For Creating Table Format..
                    Console.WriteLine(authors.ToStringTable(
                      new[] { "Account Number", "Amount", "DateofTransaction" },
                      a => a.Item1, a => a.Item2, a => a.Item3));
                }
            }
            return new List<TransactionDetails>();
        }
        //public int DeleteTransaction(int TransactionId)
        //{
        //    using (var Deletecontext = new BankContext())
        //    {
        //        var DeleteTransaction = Deletecontext.userTransactions.Where(s => s.TransactionId == TransactionId).FirstOrDefault();
        //        if (DeleteTransaction != null)
        //        {
        //            Deletecontext.userTransactions.Remove(DeleteTransaction);
        //        }
        //    }
        //    return 0;
        //}
        //public int UpdateTransaction(long AccountNumber, int TransactionId, TransactionType Type, decimal Amount, decimal Charges=10)
        //{
        //    switch(Type)
        //    {
        //        case TransactionType.WithDraw:
        //            break;
        //        case TransactionType.Deposit:
        //            break;
        //    }
        //    return 0;
        //}
    }



    public class TransactionDetails
    {

    }
}