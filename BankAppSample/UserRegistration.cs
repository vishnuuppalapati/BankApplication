using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BankAppSample
{
    //User Registration Class
    public class UserRegistration
    {
        //AccountNumber is Primarykey.
        [Key]
        [Column("RegistrationID", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RegistrationID { get; set; }

        [Column("AccountNumber", Order = 1)]
        public long AccountNumber { get; set; }

        [Column("FullName", Order = 2)]
        [Required]
        [StringLength(35)]
        public string FullName { get; set; }

        [Column("FatherName", Order = 3)]
        [Required]
        [StringLength(35)]
        public string FatherName { get; set; }

        [Column("MotherName", Order = 4)]
        [Required]
        [StringLength(35)]
        public string MotherName { get; set; }

        [Column("Dateofbirth", Order = 5)]
        [Required]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public string Dateofbirth { get; set; }

        [Column("Age", Order = 6)]
        [Required]
        [MaxLength(4)]
        public int Age { get; set; }

        [Column("MobileNumber", Order = 7)]
        [Required]
        [MinLength(10), MaxLength(10)]

        public string MobileNumber { get; set; }

        [Column("PermanemtAddress", Order = 8)]
        [Required]
        [StringLength(150)]
        public string PermanentAddress { get; set; }
        [Column("Balance", Order = 9)]
        public decimal Balance { get; set; }

        [Column("UserName", Order = 10)]
        [Required]
        [MinLength(4), MaxLength(20)]
        public string UserName { get; set; }


        [Column("Password", Order = 11)]
        [Required]
        [MinLength(4), MaxLength(16)]
        public string Password { get; set; }

        
    }
}
