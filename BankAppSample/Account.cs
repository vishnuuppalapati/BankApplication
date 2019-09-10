using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankAppSample
{
    public class Account
    {
        
        //public enum Accountt { CreateAccount=1 , Login , GetAccountDetails , GetAllAccounts , UpdateAccount , DeleteAccount}
        private const long AccountBaseNumber = 50000000;
        public  void CreateAccount(string fullname, string fathername, string mothername, string dateofbirth, int age, string mobilenumber, string permanentaddress,decimal balance, string username, string password)
        {
            UserRegistration userRegistration = new UserRegistration();
            using (var accountnumber = new BankContext())
            {
                var account = accountnumber.UserRegistrations.LastOrDefault();
                if (account == null)
                {
                    userRegistration.AccountNumber = AccountBaseNumber;
                }
                else
                {
                    userRegistration.AccountNumber = account.AccountNumber+1;
                }

            }

                userRegistration.FullName = fullname;
                userRegistration.FatherName = fathername;
                userRegistration.MotherName = mothername;
                userRegistration.Dateofbirth = dateofbirth;
                userRegistration.Age = age;
                userRegistration.MobileNumber = mobilenumber;
                userRegistration.PermanentAddress = permanentaddress;
                userRegistration.Balance = balance;
                userRegistration.UserName = username;
                userRegistration.Password = password;
                using (var context = new BankContext())
                {
                    context.UserRegistrations.Add(userRegistration);
                    context.SaveChanges();
                }
           
            //return 0;
        }

        public int Login(string username,string password)
        {
            using(var logincontext=new BankContext())
            {
                var userlogin = logincontext.UserRegistrations.Where(s => s.UserName == username && s.Password == password).FirstOrDefault();
                if(userlogin!=null)
                {
                    Utills.IsAuthenticated = true;
                    return 0;
                }
                else
                {
                    Utills.IsAuthenticated = false;
                    return 1;
                }

            }
            //return 1;
        }
        public AccountDetails GetAccountDetails(long accountnumber )
        {
            using(var detailsContext=new BankContext())
            {
                var Accountdetails = detailsContext.UserRegistrations.Where(x => x.AccountNumber == accountnumber).FirstOrDefault();
                if(Accountdetails!=null)
                {
                    IEnumerable<Tuple<long, string>> authors = new[] {Tuple.Create(Accountdetails.AccountNumber,
                                            Accountdetails.FullName)};

                    //For Creating Table Format..
                    Console.WriteLine(authors.ToStringTable(
                      new[] { "Account Number", "AccountHolderName" },
                      a => a.Item1, a => a.Item2));
                }
            }
            return new AccountDetails();
        }
        public List<AccountDetails> GetAllAccounts()
        {
            using(var AccountsContext=new BankContext())
            {
                var Allaccounts = AccountsContext.UserRegistrations.ToList();
                if (Allaccounts != null)
                {
                    foreach (var Accounts in Allaccounts)
                    {
                        IEnumerable<Tuple<int, long, string>> authors = new[] { Tuple.Create(Accounts.RegistrationID, Accounts.AccountNumber, Accounts.FullName) };

                        Console.WriteLine(authors.ToStringTable(new[] { "RegistrationID", "AccountNumber", "FullName" },
                            a => a.Item1, a => a.Item2, a => a.Item3));
                    }
                }
            }
            return new List<AccountDetails>();
        }
        public int  UpdateAccount(long accountnumber)
        {
            using (var AccountContext = new BankContext())
            {
                var Updateaccount = AccountContext.UserRegistrations.Where(s => s.AccountNumber == accountnumber).FirstOrDefault();
                if (Updateaccount != null)
                {
                    Console.WriteLine("Enter NewUserName");
                    var newusername = Console.ReadLine();
                    if (newusername != Updateaccount.UserName && newusername != "")
                    {
                        Updateaccount.UserName = newusername;
                    }
                    else if (newusername == "")
                    {
                        Updateaccount.UserName = Updateaccount.UserName;
                    }

                    Console.WriteLine("Enter NewPassword");
                    var newpassword = Console.ReadLine();
                    if (newpassword != Updateaccount.Password && newpassword != "")
                    {
                        Updateaccount.Password = newpassword;
                    }
                    else if (newpassword == "")
                    {
                        Updateaccount.Password = Updateaccount.Password;
                    }
                    Console.WriteLine("Enter NewMobileNumber");
                    var newmobilenumber = Console.ReadLine();
                    if (newmobilenumber != Updateaccount.MobileNumber && newmobilenumber != "")
                    {
                        Updateaccount.Password = newmobilenumber;
                    }
                    else if (newmobilenumber == "")
                    {
                        Updateaccount.MobileNumber = Updateaccount.MobileNumber;
                    }

                }

                AccountContext.UserRegistrations.Update(Updateaccount);
                AccountContext.SaveChanges();
            }
                return 0;
        }
        public int DeleteAccount(long accountnumber)
        {
            using (var DeleteContext = new BankContext())
            {
                var account = DeleteContext.UserRegistrations.FirstOrDefault(a => a.AccountNumber == accountnumber);
                if(account != null)
                {
                    DeleteContext.UserRegistrations.Remove(account);
                    DeleteContext.SaveChanges();
                }
            }
                return 0;
        }
    }
    public class AccountDetails
    {

    }
    

    
} 
