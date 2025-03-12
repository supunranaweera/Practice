// See https://aka.ms/new-console-template for more information
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
}