using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Xml.XPath;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Sandbox Project.");

        Bank myaccount = new Bank(0);

        // deposit money
        myaccount.Deposit(200);
        System.Console.WriteLine($"The new deposited money is: {myaccount.GetBalance()}");

        // withdraw money

        myaccount.Withdraw(50);
        System.Console.WriteLine($"Your current balance is: {myaccount.GetBalance()}");


        // withdrwa more than available
        myaccount.Withdraw(5000);
        System.Console.WriteLine($"Your current balance is {myaccount.GetBalance()}");

        myaccount._balance(500);



    }

    class Bank
    {

        private double _balance;
        public Bank(double balance)
        {
            _balance = balance;
        }

        public void Deposit(double _deposit)
        {
            if (_deposit > 0)
            {
                _balance = _balance + _deposit;
            }

            else
            {
                System.Console.WriteLine($"You cannot deposit an amount less than 0");
            }
        }

        public void Withdraw(double _withdraw)
        {
            if (_withdraw > 0 && _withdraw <= _balance)
            {
                _balance -= _withdraw;
            }

            else
            {
                System.Console.WriteLine("Invalid withdraw");
            }
        }

        public double GetBalance()
        {
            return _balance;
        }
    }
}