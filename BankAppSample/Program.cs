using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace BankAppSample
{
    public class Program
    {
       public static Account account;
        public static void Main(string[] args)
        {
            //For Creating Account.....

            Console.WriteLine("@@@@@@ Bank Application @@@@@@\n");
        
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
                    break;
                case 2:           //For showing All Account numbers with Account holder name.....
                    account = new Account();
                    account.GetAllAccounts();

                    break;
                case 3:                    //For Login Account.....

                    account = new Account();

                    Console.WriteLine("Enter Username:");
                    string Uname = Console.ReadLine();
                    Console.WriteLine("Enter password:");
                    string Pwd = Console.ReadLine();

                    account.Login(Uname, Pwd);
                    Console.WriteLine("SuccessFully LoggedIn To Your Account.\n");
                    Console.WriteLine("1. Account Details.\n");
                    Console.WriteLine("2.Logout.\n");
                    int number2 = int.Parse(Console.ReadLine());
                    switch(number2)
                    {
                        case 1:     //For Account Details.....
                            account = new Account();
                            Console.WriteLine("Enter AccountNumber.");
                            long Accountnumber = long.Parse(Console.ReadLine());
                            account.GetAccountDetails(Accountnumber);
                            break;
                        case 2:    //For Logout.....
                            Console.WriteLine("Successfully Logout..");
                            break;
                    }


                    break;
                case 4:        //For Updating Account.....
                    account = new Account();
                    Console.WriteLine("Enter Account Number:");
                    long accountnumber = long.Parse(Console.ReadLine());
                    Console.WriteLine("Enter FirstName:");
                    string Frstname = Console.ReadLine();
                    Console.WriteLine("Enter MiddleName:");
                    string Midlename = Console.ReadLine();
                    Console.WriteLine("Enter LastName:");
                    string Latname = Console.ReadLine();

                    string Fulname = Frstname + " " + Midlename + " " + Latname;
                    Console.WriteLine("Enter FatherName:");
                    string Fathrname = Console.ReadLine();
                    Console.WriteLine("Enter MotherName:");
                    string Mothrname = Console.ReadLine();
                    Console.WriteLine("Enter Date of Birth:");
                    Console.WriteLine("Enter Day:");
                    int day = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Month:");
                    int month = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Year:");
                    int year = int.Parse(Console.ReadLine());
                    string DateofBirth = day + "/" + month + "/" + year;
                    Console.WriteLine("Enter Age:");
                    int age = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter MobileNumber:");
                    string mobilenumber = Console.ReadLine();
                    Console.WriteLine("Enter Permanent Address:");
                    string Permanentaddress = Console.ReadLine();
                    Console.WriteLine("Enter Balance:");
                    long balance = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Username:");
                    string username = Console.ReadLine();
                    Console.WriteLine("Enter password:");
                    string Password = Console.ReadLine();
                    account.UpdateAccount(accountnumber, Fulname, Fathrname, Mothrname, mobilenumber, DateofBirth, age, Permanentaddress, username, Password);
                    break;

                case 5:        //For Delete Account.....
                    account = new Account();
                    Console.WriteLine("Enter AccountNumber.");
                    long Acountnumber = long.Parse(Console.ReadLine());
                    account.DeleteAccount(Acountnumber);
                    Console.WriteLine("Successfully Deleted Account...");
                    break;
            }
            


            




            //account.CreateAccount(Fullname:Fullname,Fathername:Fathername,Mothername:Mothername,DateofBirth:Dateofbirth,age:Age,Mobilenumber:Mobilenumber,Permanentaddress:PermanentAddress,
            //    Balance:Balance,Username:Username,password:password);

            //    //string usr = "Sandeep";
            //    //DateTime aDate = DateTime.Now;
            //    //Items items = new Items();
            //    //Console.WriteLine("Enter Full name:");
            //    //items.FullName = Console.ReadLine();
            //    //account.CreateAccount(items.FullName, "Sandy", "Sandy", aDate.ToString("10/10/2015"), 32, 1234567, "Hyd", 10000, usr, "1122");
            //    //Console.WriteLine("Successfully registration completed with the User name:", usr);

            //    Console.WriteLine("@@@@@@ Bank Application @@@@@@\n");
            //Main:
            //    Console.WriteLine("_____Home Page_____\n");
            //    Console.WriteLine("1.Registration Form\n");
            //    Console.WriteLine("2.Login Page\n");
            //    Console.WriteLine("3.Account Holder Details\n");
            //    Console.WriteLine("4.Exit\n");
            //    Console.WriteLine("Enter your Choice..");
            //    int number1 = int.Parse(Console.ReadLine());
            //    if (number1 > 0 && number1 <= 4)
            //    {
            //        goto Switchcase1;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Enter Valid Choice..\n");
            //        goto Main;
            //    }
            //Switchcase1:
            //    switch (number1)
            //    {
            //        case 1:
            //            {
            //                Program program = new Program();
            //                program.RegistrationMethod();
            //                goto Main;
            //            }
            //        case 2:
            //            {

            //                Program program = new Program();
            //                program.LoginMethod();

            //                goto Main;
            //            }
            //        case 3:
            //            {
            //                Program program = new Program();
            //                program.LoginMethod();
            //                goto Main;
            //            }
            //        case 4:
            //            {
            //                break;
            //            }
            //    }

            //}
            //For Registration, Creating the object for entities of User Registration.
            //public void RegistrationMethod()
            //{
            //    Console.WriteLine("Please enter Registration details..");
            //    account = new Account();
            //    UserRegistration UserRegistrations = new UserRegistration();
            //    Console.WriteLine("Please enter FullName");
            //    string FName = Console.ReadLine();
            //    UserRegistrations.FullName = FName;
            //    account.CreateAccount(Fullname=F)

            //    Console.WriteLine("Please enter FatherName");
            //    string FatherName = Console.ReadLine();
            //    UserRegistrations.FatherName = FatherName;

            //    Console.WriteLine("Please enter MotherName");
            //    string MName = Console.ReadLine();
            //    UserRegistrations.MotherName = MName;

            //    //Console.WriteLine("Please enter Dateofbirth(Ex:15 / 05 / 2005)");
            //    //string DOB = Convert.ToDateTime(Console.ReadLine());
            //    //UserRegistrations.Dateofbirth = DOB;

            //    Console.WriteLine("Please enter Age");
            //    int age = int.Parse(Console.ReadLine());
            //    UserRegistrations.Age = age;

            //    Console.WriteLine("Please enter MobileNumber");
            //    long Phone = long.Parse(Console.ReadLine());
            //    UserRegistrations.MobileNumber = Phone;

            //    Console.WriteLine("Please enter PermanemtAddress");
            //    string Addr = Console.ReadLine();
            //    UserRegistrations.PermanentAddress = Addr;

            //    //Console.WriteLine("Please enter ResidentialAddress");
            //    //string Raddr = Console.ReadLine();
            //    //UserRegistrations.ResidentialAddress = Raddr;

            //    Console.WriteLine("Please enter UserName");
            //    string UName = Console.ReadLine();
            //    UserRegistrations.UserName = UName;

            //    Console.WriteLine("Please enter Password");
            //    string pwd = Console.ReadLine();
            //    UserRegistrations.Password = pwd;

            //    //Random R = new Random();
            //    //var accnumber = ((long)R.Next(0, 100000) * (long)R.Next(0, 100000)).ToString().PadLeft(10, '0');
            //    //UserRegistrations.AccountNumber = accnumber;

            //    using (var context = new BankContext())
            //    {
            //        context.UserRegistrations.Add(UserRegistrations);
            //        context.SaveChanges();
            //        Console.WriteLine("User Registration Successfully Completed!");
            //    }

            //    //Passing Values from User Registration Table by using UserRegistration Id to Account holder details table, 
            //    //using (var context = new BankContext())
            //    //{
            //    //    var user = context.UserRegistrations.Where(x => x.UserName == UserRegistrations.UserName).FirstOrDefault();
            //    //    if (user != null)
            //    //    {
            //    //        AccountHolderDetails accountHolderDetails = new AccountHolderDetails();
            //    //        accountHolderDetails.AcHolderName = user.UserName;
            //    //        accountHolderDetails.AvailBalance = 000;
            //    //        //accountHolderDetails.RegistrationId = user.RegistrationId;                   
            //    //        accountHolderDetails.AccountNumber = user.AccountNumber;
            //    //        context.AccountHolderDetails.Add(accountHolderDetails);
            //    //        context.SaveChanges();
            //    //    }

            //    //    Console.WriteLine("Account Number Successfully Generated..");
            //    //}



            //}
            ////For Login by using our credentials.
            //public void LoginMethod()
            //{
            ////For Asking the User Name.
            //ReenterUname:
            //    Console.WriteLine("Enter username:");
            //    string username = Console.ReadLine();
            //    using (var context = new BankContext())
            //    {
            //        var userinfo = context.UserRegistrations.Where(s => s.UserName == username).ToList();
            //        if (userinfo.Count == 0)
            //        {
            //            Console.WriteLine("Invalid user name.. Please register or Enter valid User Name");
            //            goto ReenterUname;
            //        }
            //        else
            //        {
            //        //For asking the Password.
            //        ReenterPwd:
            //            Console.WriteLine("Enter password:");
            //            string pwd = Console.ReadLine();
            //            if (pwd != userinfo[0].Password)
            //            {
            //                Console.WriteLine("Incorrect password");
            //                goto ReenterPwd;
            //            }
            //            else
            //            {
            //                //For Account Holder Details.
            //                Console.WriteLine("Successfully Login To Your Account.\n");
            //            AHD:
            //                Console.WriteLine("1.User Details\n");
            //                Console.WriteLine("2.User Transactions\n");
            //                Console.WriteLine("3.Logout\n");
            //                Console.WriteLine("Enter Your Choice..");
            //                int number2 = int.Parse(Console.ReadLine());
            //                if (number2 > 0 && number2 <= 3)
            //                {
            //                    goto Switchcase2;
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Enter Valid Choice..\n");
            //                    goto AHD;
            //                }
            //            Switchcase2:
            //                switch (number2)
            //                {
            //                    case 1:
            //                        {
            //                            //Getting the Account Holder Details by using Linq Query Based on user Login Credentials..
            //                            //using (var ctext = new BankContext())
            //                            //{
            //                            //    var acholderinfo = ctext.AccountHolderDetails.Where(a => a.AcHolderName == username).FirstOrDefault();

            //                            //    //Printing the Account Holder Details in Table Format using Account Holder Login Credintials..
            //                            //    IEnumerable<Tuple<string, string, decimal, int>> authors = new[] {Tuple.Create(acholderinfo.AcHolderName,acholderinfo.AccountNumber,
            //                            //                    acholderinfo.AvailBalance,acholderinfo.RegistrationId)};

            //                            //    //For Creating Table Format..
            //                            //    Console.WriteLine(authors.ToStringTable(
            //                            //      new[] { "Account Holder Name", "Account Number", "AvailableBalance", "RegistrationId" },
            //                            //      a => a.Item1, a => a.Item2, a => a.Item3, a => a.Item4));

            //                            //    //Console.WriteLine("Account Holder Name: {0}", acholderinfo.AcHolderName);
            //                            //    //Console.WriteLine("Account Number:      {0}", acholderinfo.AccountNumber);
            //                            //    //Console.WriteLine("Available Balance:   {0}", acholderinfo.AvailBalance);
            //                            //    //Console.WriteLine("RegistrationId:      {0}", acholderinfo.RegistrationId);
            //                            //}
            //                            goto AHD;

            //                        }
            //                    case 2:                                                                                                                         
            //                        {
            //                            Console.WriteLine("Successfully Entered Into Transactions...\n");

            //                            //Getting the Account Holder Details and inserting the data what we required in User Transactions..
            //                            //using (var cntext = new BankContext())
            //                            //{
            //                            //    var transatinfo = cntext.AccountHolderDetails.Where(a => a.AcHolderName == username).FirstOrDefault();
            //                            //    UserTransactions userTransaction = new UserTransactions();

            //                            //   // userTransaction.AccountNumber = transatinfo.AccountNumber;
            //                            //    userTransaction.AvailBal = transatinfo.AvailBalance;
            //                            //    userTransaction.AccountHolderName = transatinfo.AcHolderName;
            //                            ////userTransaction.DateofTransaction = DateTime.UtcNow;
            //                            //depositwithdraw:
            //                            //    Console.WriteLine("1.Deposit");
            //                            //    Console.WriteLine("2.Withdraw");
            //                            //    Console.WriteLine("3.Transaction Details");
            //                            //    Console.WriteLine("4.Back\n");
            //                            //    Console.WriteLine("Enter User Choice.");
            //                            //    int number3 = int.Parse(Console.ReadLine());

            //                            //    if (number3 > 0 && number3 <= 4)
            //                            //    {
            //                            //        goto Switchcase3;
            //                            //    }
            //                            //    else
            //                            //    {
            //                            //        Console.WriteLine("Enter Valid Choice..\n");
            //                            //        goto depositwithdraw;
            //                            //    }
            //                            //    Switchcase3:
            //                            //    switch (number3)
            //                            //    {
            //                            //        case 1:
            //                            //            {
            //                            //                //Asking the Amount to Deposit in your Account..
            //                            //                Console.WriteLine("Enter Deposit Amount:");
            //                            //                decimal depositamt = decimal.Parse(Console.ReadLine());
            //                            //                //Adding the Entered Amount in Deposit column in Transaction Database..
            //                            //                userTransaction.DepositAmount = depositamt;
            //                            //                decimal AvailBalance = userTransaction.AvailBal + depositamt;
            //                            //                //Updating the Balance in User Transactions..
            //                            //                userTransaction.AvailBal = AvailBalance;
            //                            //                //Updating the Balance in Account Holder Details..
            //                            //                transatinfo.AvailBalance = AvailBalance;

            //                            //                userTransaction.DateofTransaction = DateTime.Now;
            //                            //                cntext.UserTransaction.Add(userTransaction);
            //                            //                cntext.SaveChanges();
            //                            //                Console.WriteLine("\nMoney Deposited Successfully..\n");
            //                            //                goto AHD;

            //                            //            }
            //                            //        case 2:
            //                            //            {
            //                            //                //Asking the Amount to Withdraw from your Account..
            //                            //                Console.WriteLine("Enter Withdraw Amount:");
            //                            //                decimal withdrawamt = decimal.Parse(Console.ReadLine());
            //                            //                //Adding the Entered Amount in Withdraw column in Transaction Database..
            //                            //                userTransaction.WithdrawAmount = withdrawamt;
            //                            //                decimal AvailBalance = userTransaction.AvailBal - withdrawamt;
            //                            //                //Updating the Balance in User Transactions..
            //                            //                userTransaction.AvailBal = AvailBalance;
            //                            //                //Updating the Balance in Account Holder Details..
            //                            //                transatinfo.AvailBalance = AvailBalance;

            //                            //                userTransaction.DateofTransaction = DateTime.Now;
            //                            //                cntext.UserTransaction.Add(userTransaction);
            //                            //                cntext.SaveChanges();
            //                            //                Console.WriteLine("\nWithdrawl Money Successfully..\n");
            //                            //                goto AHD;
            //                            //            }
            //                            //        case 3:
            //                            //            {

            //                            //                //Getting Last Transaction info from Transaction Db Related to Login Details..
            //                            //                var accInfo = cntext.UserRegistrations.Where(x => x.UserName == username).FirstOrDefault();
            //                            //                var transactioninfo = cntext.UserTransaction.Where(a => a.AccountHolderName == username /*&& a.AccountNumber == accInfo.AccountNumber*/).ToList();
            //                            //                //transactioninfo=cntext.UserTransaction.Where(a=>a.AccountHolderName==username).Where(f=>f.TransactionId== )

            //                            //                foreach (var Info in transactioninfo)
            //                            //                {
            //                            //                    //Printing the Last Transaction Details in Table Format using Account Holder Login Credintials..
            //                            //                    IEnumerable<Tuple<string,  decimal, decimal, DateTime, decimal>> authors = new[] {Tuple.Create(Info.AccountHolderName,
            //                            //                    /*Info.AccountNumber,*/Info.DepositAmount,Info.WithdrawAmount,
            //                            //                    Info.DateofTransaction,Info.AvailBal)};

            //                            //                    //For Creating Table Format..
            //                            //                    Console.WriteLine(authors.ToStringTable(
            //                            //                      new[] { "Account Holder Name", "Account Number", "DepositAmount", "WithdrawAmount", "DateofTransaction", "AvailableBalance" },
            //                            //                      a => a.Item1, a => a.Item2, a => a.Item3, a => a.Item4, a => a.Item5));
            //                            //                }

            //                            //                //Console.ReadLine();

            //                            //                //Console.WriteLine("Account Holder Name  :   {0}", transactioninfo.AccountHolderName);
            //                            //                //Console.WriteLine("Account Number       :   {0}", transactioninfo.AccountNumber);
            //                            //                //Console.WriteLine("DepositAmount        :   {0}", transactioninfo.DepositAmount);
            //                            //                //Console.WriteLine("WithdrawAmount       :   {0}", transactioninfo.WithdrawAmount);
            //                            //                //Console.WriteLine("DateofTransaction    :   {0}", transactioninfo.DateofTransaction);
            //                            //                //Console.WriteLine("AvailableBalance     :   {0}\n", transactioninfo.AvailBal);
            //                            //                goto AHD;

            //                            //            }
            //                            //        case 4:
            //                            //            {
            //                            //                break;
            //                            //            }
            //                            //    }


            //                            //}
            //                            goto AHD;
            //                        }
            //                    case 3:
            //                        {
            //                            Console.WriteLine("Successfully Logged Out Your Account.\n");
            //                            break;
            //                        }
            //                }
            //            }

            //        }
            //    }

        }


    }
}
