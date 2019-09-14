using BankAppSample.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankAppSample
{
    public class Transaction
    {
     
        
        public int CreateTransaction(long AccountNumber, TransactionType Type, decimal Amount, decimal Charges = 10)
        {
            UserTransactions userTransaction = new UserTransactions();
            UserRegistration userRegistration = new UserRegistration();
            //For Deposit.....
            if (Type==TransactionType.Deposit)
            {
                using (var Context = new BankContext())
                {
                    var accountDetails = Context.UserRegistrations.Where(a => a.AccountNumber == AccountNumber).FirstOrDefault();
                    userTransaction.AccountNumber = accountDetails.AccountNumber;
                    userTransaction.RegistrationID = accountDetails.RegistrationID;
                    userTransaction.AccountHolderName = accountDetails.FullName;
                    userTransaction.AvailBal = accountDetails.Balance;
                    userTransaction.DepositAmount = Amount+Charges;
                    decimal AvailBalance = userTransaction.AvailBal + userTransaction.DepositAmount;
                    userTransaction.AvailBal = AvailBalance;
                    accountDetails.Balance = userTransaction.AvailBal;
                    userTransaction.DateofTransaction = DateTime.Now;
                    Context.UserTransaction.Add(userTransaction);
                    Context.SaveChanges();
                    Console.WriteLine("Deposit successfully");
                }
                    
            }
           else if(Type==TransactionType.Withdrawl)              
            {
                //For Withdrawl.....
                using (var Context = new BankContext())
                {
                    var accountDetails = Context.UserRegistrations.Where(a => a.AccountNumber == AccountNumber).FirstOrDefault();
                    userTransaction.AccountNumber = accountDetails.AccountNumber;
                    userTransaction.RegistrationID = accountDetails.RegistrationID;
                    userTransaction.AccountHolderName = accountDetails.FullName;
                    if (accountDetails.Balance > 0 && accountDetails.Balance>Amount)
                    {
                        userTransaction.AvailBal = accountDetails.Balance;
                        userTransaction.WithdrawAmount = Amount + Charges;
                        decimal AvailBalance = userTransaction.AvailBal - userTransaction.WithdrawAmount;
                        userTransaction.AvailBal = AvailBalance;
                        accountDetails.Balance = userTransaction.AvailBal;
                        userTransaction.DateofTransaction = DateTime.Now;
                        Context.UserTransaction.Add(userTransaction);
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