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
            Console.WriteLine("4.Delete Account\n");
            Console.WriteLine("5.Exit\n");
            Console.WriteLine("Enter Your Choice.\n");

            int number1 = int.Parse(Console.ReadLine());
            
            switch(number1)
            {
                case 1:    //For Creating Account.....
                    account = new Account();

                    Console.WriteLine("Enter FirstName:");
                    string firstname = Console.ReadLine();
                    Console.WriteLine("Enter MiddleName:");
                    string middlename = Console.ReadLine();
                    Console.WriteLine("Enter LastName:");
                    string lastname = Console.ReadLine();

                    string fullname = firstname + " " + middlename + " " + lastname;
                    Console.WriteLine("Enter FatherName:");
                    string fathername = Console.ReadLine();
                    Console.WriteLine("Enter MotherName:");
                    string mothername = Console.ReadLine();
                    Console.WriteLine("Enter Date of Birth:");
                    Console.WriteLine("Enter Day:");
                    int day = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Month:");
                    int month = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Year:");
                    int year = int.Parse(Console.ReadLine());
                    string dateofbirth = day + "/" + month + "/" + year;
                    Console.WriteLine("Enter Age:");
                    int age = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter MobileNumber:");
                    string mobilenumber = Console.ReadLine();
                    Console.WriteLine("Enter Permanent Address:");
                    string permanentaddress = Console.ReadLine();
                    Console.WriteLine("Enter Balance:");
                    long balance = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Username:");
                    string username = Console.ReadLine();
                    Console.WriteLine("Enter password:");
                    string password = Console.ReadLine();

                    account.CreateAccount(fullname, fathername, mothername, dateofbirth, age, mobilenumber, permanentaddress,
                        balance, username, password);
                    Console.WriteLine("Account Created Successfully.\n");
                    goto Main;

                case 2:           //For showing All Account numbers with Account holder name.....
                    account = new Account();
                    account.GetAllAccounts();

                    goto Main;
                case 3:                    //For Login Account.....
                    LoginPage:
                    account = new Account();
                    Console.WriteLine("Enter Username:");
                    string loginusername = Console.ReadLine();
                    Console.WriteLine("Enter password:");
                    string loginpassword = Console.ReadLine();
                    var res = account.Login(loginusername, loginpassword);
                    if(res == 0)
                    {

                        Console.WriteLine("SuccessFully LoggedIn To Your Account.\n");
                    HomePage:
                        Console.WriteLine("1.Account Details.\n");
                        Console.WriteLine("2.Update Account.");
                        Console.WriteLine("3.Transactions\n");
                        Console.WriteLine("4.Logout.\n");
                        Console.WriteLine("Enter Your Choice.\n");
                        int number2 = int.Parse(Console.ReadLine());
                        switch (number2)
                        {
                            case 1:     //For Account Details.....
                                account = new Account();
                                Console.WriteLine("Enter AccountNumber.");
                                long accountnumberfordetails = long.Parse(Console.ReadLine());
                                account.GetAccountDetails(accountnumberfordetails);
                                goto HomePage;
                            case 2:        //For Updating Account.....
                                account = new Account();

                                Console.WriteLine("Enter Account Number For Update Account.");
                                long accountnumberforupdate = long.Parse(Console.ReadLine());
                                account.UpdateAccount(accountnumberforupdate);
                                Console.WriteLine("\n Sucessfully Updated..\n");
                                goto HomePage;
                            case 3:
                                transaction = new Transaction();
                                Console.WriteLine("Select  transaction type");
                                Console.WriteLine("Enter AccountNumber.");
                                long acountnumber = long.Parse(Console.ReadLine());
                                Console.WriteLine("Enter Username:");
                                decimal deposit = decimal.Parse(Console.ReadLine());
                                Console.WriteLine("Enter password:");
                                decimal withdrawl = decimal.Parse(Console.ReadLine());
                                Console.WriteLine("Enter Username:");
                                decimal amount = decimal.Parse(Console.ReadLine());
                                Console.WriteLine("Enter password:");
                                decimal charges = decimal.Parse(Console.ReadLine());
                                //if(Enums.TransactionType==Deposit)
                                //transaction.CreateTransaction(acountnumber,Enums.TransactionType.Deposit, Enums.TransactionType.Withdrawl, amount, charges);
                                break;
                            case 4:    //For Logout.....
                                Console.WriteLine("Successfully Logout..\n");
                                goto Main;
                        }                        
                    }
                    else
                    {
                        Console.WriteLine("Invalid username or password, please try again");
                        goto LoginPage;
                    }
                    goto Main;

                case 4:        //For Delete Account.....
                    account = new Account();
                    Console.WriteLine("Enter AccountNumber For Delete Account.");
                    long acountnumberfordelete = long.Parse(Console.ReadLine());
                    account.DeleteAccount(acountnumberfordelete);
                    Console.WriteLine("Successfully Deleted Account...\n");
                    goto Main;

                case 5:       //For Closing the Application.....

                    break;
            }
            

        }


    }

}
