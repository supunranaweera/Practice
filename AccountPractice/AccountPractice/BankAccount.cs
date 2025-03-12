using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPractice
{
    internal class BankAccount
    {


            private float _balance;
            private string _accountHolderName;
            private int _accountNumber;
            private string _emailAddress;
            private string _phoneNumber;
            private string _postalCode;
            private string _password;


            public BankAccount(float balance, string accountHolderName, int accountNumber, string emailAddress, string phoneNumber, string postalCode, string password)
            {
                _balance = balance;
                _accountHolderName = accountHolderName;
                _accountNumber = accountNumber;
                _emailAddress = emailAddress;
                _phoneNumber = phoneNumber;
                _postalCode = postalCode;
                _password = password;
            }
    }
}
