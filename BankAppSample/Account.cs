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
        public  void CreateAccount(string Fullname, string Fathername, string Mothername, string DateofBirth, int age, string Mobilenumber, string Permanentaddress,decimal Balance, string Username, string password)
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

                userRegistration.FullName = Fullname;
                userRegistration.FatherName = Fathername;
                userRegistration.MotherName = Mothername;
                userRegistration.Dateofbirth = DateofBirth;
                userRegistration.Age = age;
                userRegistration.MobileNumber = Mobilenumber;
                userRegistration.PermanentAddress = Permanentaddress;
                userRegistration.Balance = Balance;
                userRegistration.UserName = Username;
                userRegistration.Password = password;
                using (var context = new BankContext())
                {
                    context.UserRegistrations.Add(userRegistration);
                    context.SaveChanges();
                }
           
            //return 0;
        }

        public int Login(string Username,string password)
        {
            using(var logincontext=new BankContext())
            {
                var userlogin = logincontext.UserRegistrations.Where(s => s.UserName == Username && s.Password == password).FirstOrDefault();
            }
            return 0;
        }
        public AccountDetails GetAccountDetails(long Accountnumber )
        {
            using(var detailsContext=new BankContext())
            {
                var Accountdetails = detailsContext.UserRegistrations.Where(x => x.AccountNumber == Accountnumber).FirstOrDefault();
                IEnumerable<Tuple<long, string>> authors = new[] {Tuple.Create(Accountdetails.AccountNumber,
                                            Accountdetails.FullName)};

                //For Creating Table Format..
                Console.WriteLine(authors.ToStringTable(
                  new[] { "Account Number", "AccountHolderName" },
                  a => a.Item1, a => a.Item2));

            }
            return new AccountDetails();
        }
        public List<AccountDetails> GetAllAccounts()
        {
            using(var AccountsContext=new BankContext())
            {
                var Allaccounts = AccountsContext.UserRegistrations.ToList();
                foreach(var Accounts in Allaccounts)
                {
                    IEnumerable<Tuple<int,long,string>> authors = new[] {Tuple.Create(Accounts.RegistrationID,Accounts.AccountNumber,Accounts.FullName)};

                    Console.WriteLine(authors.ToStringTable(new[] { "RegistrationID", "AccountNumber", "FullName" },
                        a=>a.Item1, a => a.Item2, a=>a.Item3));
                }
            }
            return new List<AccountDetails>();
        }
        public int  UpdateAccount(long Accountnumber, string Fullname, string Fathername, string Mothername, string Mobilenumber, string DateofBirth, int age, string Permanentaddress, string Username, string password)
        {
            using (var AccountContext = new BankContext())
            {
                var Updateaccount = AccountContext.UserRegistrations.Where(s => s.AccountNumber == Accountnumber).FirstOrDefault();
                Updateaccount.FullName = Fullname;
                Updateaccount.FatherName = Fathername;
                Updateaccount.MotherName = Mothername;
                Updateaccount.MobileNumber = Mobilenumber;
                Updateaccount.Dateofbirth = DateofBirth;
                Updateaccount.Age = age;
                Updateaccount.PermanentAddress = Permanentaddress;
                Updateaccount.UserName = Username;
                Updateaccount.Password = password;
                AccountContext.UserRegistrations.Update(Updateaccount);
                AccountContext.SaveChanges();
            }
                return 0;
        }
        public void DeleteAccount(long Accountnumber)
        {
            using (var DeleteContext = new BankContext())
            {
                var account = DeleteContext.UserRegistrations.FirstOrDefault(a => a.AccountNumber == Accountnumber);
                if(account != null)
                {
                    DeleteContext.UserRegistrations.Remove(account);
                }
            }
                //return 0;
        }
    }
    public class AccountDetails
    {

    }

    
} 
