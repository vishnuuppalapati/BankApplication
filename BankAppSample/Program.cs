using BankAppSample.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace BankAppSample
{
    public class Program
    {
       public static Account account;
        public static Transaction transaction;
        public static void Main(string[] args)
        {
            //For Creating Account.....

            Console.WriteLine("@@@@@@ Bank Application @@@@@@\n");
            Main:
            Console.WriteLine("_____Home Page_____\n");
            Console.WriteLine("1.Registration Form\n");
            Console.WriteLine("2.Display All Accounts\n");
            Console.WriteLine("3.Login Page\n");
            Console.WriteLine("4.Update Account\n");
            Console.WriteLine("5.Delete Account\n");
            Console.WriteLine("6.Exit\n");
            Console.WriteLine("Enter Your Choice.\n");

            int number1 = int.Parse(Console.ReadLine());
            switch(number1)
            {
                case 1:    //For Creating Account.....
                    account = new Account();

                    Console.WriteLine("Enter FirstName:");
                    string Firstname = Console.ReadLine();
                    Console.WriteLine("Enter MiddleName:");
                    string Middlename = Console.ReadLine();
                    Console.WriteLine("Enter LastName:");
                    string Lastname = Console.ReadLine();

                    string Fullname = Firstname + " " + Middlename + " " + Lastname;
                    Console.WriteLine("Enter FatherName:");
                    string Fathername = Console.ReadLine();
                    Console.WriteLine("Enter MotherName:");
                    string Mothername = Console.ReadLine();
                    Console.WriteLine("Enter Date of Birth:");
                    Console.WriteLine("Enter Day:");
                    int Day = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Month:");
                    int Month = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Year:");
                    int Year = int.Parse(Console.ReadLine());
                    string Dateofbirth = Day + "/" + Month + "/" + Year;
                    Console.WriteLine("Enter Age:");
                    int Age = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter MobileNumber:");
                    string Mobilenumber = Console.ReadLine();
                    Console.WriteLine("Enter Permanent Address:");
                    string PermanentAddress = Console.ReadLine();
                    Console.WriteLine("Enter Balance:");
                    long Balance = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Username:");
                    string Username = Console.ReadLine();
                    Console.WriteLine("Enter password:");
                    string password = Console.ReadLine();

                    account.CreateAccount(Fullname, Fathername, Mothername, Dateofbirth, Age, Mobilenumber, PermanentAddress,
                        Balance, Username, password);
                    Console.WriteLine("Account Created Successfully.\n");
                    goto Main;

                case 2:           //For showing All Account numbers with Account holder name.....
                    account = new Account();
                    account.GetAllAccounts();

                    goto Main;
                case 3:                    //For Login Account.....

                    account = new Account();

                    Console.WriteLine("Enter Username:");
                    string Uname = Console.ReadLine();
                    Console.WriteLine("Enter password:");
                    string Pwd = Console.ReadLine();

                    account.Login(Uname, Pwd);
                    Console.WriteLine("SuccessFully LoggedIn To Your Account.\n");
                    HomePage:
                    Console.WriteLine("1.Account Details.\n");
                    Console.WriteLine("2.Transactions\n");
                    Console.WriteLine("3.Transaction Details\n");
                    Console.WriteLine("4.Get All Transactions\n");
                    Console.WriteLine("5.Logout.\n");
                    int number2 = int.Parse(Console.ReadLine());
                    switch(number2)
                    {
                        case 1:     //For Account Details.....
                            account = new Account();
                            Console.WriteLine("Enter AccountNumber.");
                            long Accountnumber = long.Parse(Console.ReadLine());
                            account.GetAccountDetails(Accountnumber);
                            goto HomePage;
                            
                        case 2:
                            //To Create Transaction 
                            transaction = new Transaction();
   
                            Console.WriteLine("Select  transaction type");
                            Console.WriteLine("Enter AccountNumber.");
                            long acountnumber = long.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Transaction type: 0 -Deposit **** 1-Withdrawl ");
                            int transactionType = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Amount");
                            int amount = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter charges:");
                            decimal charges = decimal.Parse(Console.ReadLine());
                            if (TransactionType.Withdrawl ==(TransactionType)transactionType)
                            {
                                transaction.CreateTransaction(acountnumber, Enums.TransactionType.Withdrawl, amount, charges);
                            }
                            else if(TransactionType.Deposit == (TransactionType)transactionType)
                            {
                                transaction.CreateTransaction(acountnumber, Enums.TransactionType.Deposit, amount, charges);
                            }
                            
                            break;
                        case 3:
                            //To Get Single Transaction Details
                            Console.WriteLine("Enter TransactionId");
                            transaction = new Transaction();
                            int TransactionId = int.Parse(Console.ReadLine());
                            transaction.GetTransactionDetails(TransactionId);
                            break;
                        case 4:
                            //To Get MUltiple Transactions Details 
                            Console.WriteLine("Enter AccountNumber");
                            transaction = new Transaction();
                            long AccountNumber = int.Parse(Console.ReadLine());
                            transaction.GetTransactions(AccountNumber);
                            break;
                        case 5:  
                            //For Logout.....
                            Console.WriteLine("Successfully Logout..\n");
                            goto Main;
                           
                    }
                    goto Main;

                case 4:        //For Updating Account.....
                    account = new Account();
                    Console.WriteLine("Enter Account Number.");
                    long accountnumber = long.Parse(Console.ReadLine());
                    account.UpdateAccount(accountnumber);
                    Console.WriteLine("\n Sucessfully Updated..\n");
                    goto Main;

                case 5:        //For Delete Account.....
                    account = new Account();
                    Console.WriteLine("Enter AccountNumber.");
                    long Acountnumber = long.Parse(Console.ReadLine());
                    account.DeleteAccount(Acountnumber);
                    Console.WriteLine("Successfully Deleted Account...\n");
                    goto Main;

                case 6:       //For Closing the Application.....

                    break;
            }
            

        }


    }
}
