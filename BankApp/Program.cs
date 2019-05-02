using System;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var a1 = new Account();
            //"new" word allows us to create an instance.So basically a1 
            //is an instance of the class Account.
            a1.AccountNumber = 123456;
            a1.Balance = 1000;

        }
    }
}
