using BankAppSample.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankAppSample
{
    public class Transaction
    {
        //public int CreateTransaction(string AccountNumber, string AccountHolderName, decimal DepositAmount, decimal WithdrawAmount, DateTime DateOfTransaction)
        //{
        //    return 0;
        //}
        public int CreateTransaction(string AccountNumber,TransactionType type, decimal amount, decimal charges, DateTime creationDate)
        {
            return 0;
        }
        public TransactionDetails GetTransactionDetails(string transactionId)
        {
            return new TransactionDetails();
        }
        public List<TransactionDetails> GetAllTransactions()
        {
            return new List<TransactionDetails>();
        }
        //public int UpdateTransactions(string AccountNumber,string transactionId, TransactionType type, decimal amount, decimal charges, DateTime modfieddate)
        //{
        //    return 0;
        //}
        //public int DeleteTransaction(string transactionId)
        //{

        //    return 0;
        //}
    }



    public class TransactionDetails
    {

    }
}