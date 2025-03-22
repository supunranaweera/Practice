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

        public void PrintBalance()
        {
            Console.WriteLine($"Name: {_accountHolderName}");
            Console.WriteLine($"Balance {_balance}");
            DateTime.UtcNow.ToString() 
        }

        public void Deposit(float input)
        {
            balance = balance + input;
        }

        public void Withdraw(float input)
        {
            balance = balance - input;
        }
        public void Prompt()
        {
            while (true)
            {
                Console.WriteLine("Input the selection");
                Console.WriteLine("D - Deposit");
                Console.WriteLine("W - Withdraw");
                Console.WriteLine("P - Print balance");
                Console.WriteLine("X - Exit");
                Console.WriteLine("Your choice: ");
                string choice = Console.ReadKey();


                if (choice == "d")
                {
                    Conosle.WriteLine("Amount: ");
                    float amount = float.Parse(Console.ReadLine());
                    Deposit(amount);
                    PrintBalance()
                }


                else if (choice == "w")
                {
                    float amount = Console.ReadLine();
                    Withdraw(amount);
                    PrintBalance();
                }


                else if (choice == "p")
                {
                    PrintBalance();
                }

                else if (choice == "x")
                {
                    break;
                }

                else
                {
                    Console.WriteLine("Invalid input");
                }

            }

        }


    }
}
