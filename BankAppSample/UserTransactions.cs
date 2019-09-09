using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BankAppSample
{
    //Transaction Class
    public class UserTransactions
    {
        //TransactionId is PrimaryKey.
        [Key]
        [Column(Order = 0)]
        public int TransactionId { get; set; }

        [Column(Order = 1)]
        public decimal DepositAmount { get; set; }

        [Column(Order = 2)]
        public decimal WithdrawAmount { get; set; }

        [Column(Order = 3)]
        public decimal AvailBal { get; set; }
        [Column(Order = 4)]
        public string AccountHolderName { get; set; }

        [Column(Order = 5)]
        public DateTime DateofTransaction { get; set; }

        [Column(Order =6)]
        public long AccountNumber { get; set; }

        //ForeignKey for RegistrationID.
        public virtual int RegistrationID { get; set; }

        [ForeignKey("RegistrationID")]
        public virtual UserRegistration RegistrationInfo { get; set; }

    }
}
