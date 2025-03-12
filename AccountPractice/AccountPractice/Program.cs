// See https://aka.ms/new-console-template for more information
using System.Security;

Console.WriteLine("Hello, World!");


public class BankAccount
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


    BankAccount SupunAccount = new BankAccount(0, "Supun", 1, "supun@ranaweera.ca", "587-340-8398", "T6W 0M8", "1111");
    BankAccount KamalAccount = new BankAccount(0, "Kamal", 2, "kamal@ranaweera.ca", "780-965-2012", "T6W 0M8", "1111");
}