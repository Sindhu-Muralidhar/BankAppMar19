using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    /// <summary>
    /// Account that represents bank account.
    /// here you can withdraw or deposit money
    /// </summary>
    class Account

    {
        #region Properties
        /// <summary>
        /// Unique number asscociatd with a customer for their account
        /// </summary>
        public int AccountNumber { get; set; }
        /// <summary>
        /// Email address of the account holder
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// Available balance
        /// </summary>
        public decimal Balance { get; set; }
        /// <summary>
        /// Type of account
        /// </summary>
        public string AccountType { get; set; }
        /// <summary>
        /// Date when the account was created 
        /// </summary>
        public DateTime CreatedDate { get; set; }
        #endregion

        #region Methods 
        /// <summary>
        /// 
        /// </summary>
        /// <param name="amount">Amount to be deposited </param>

    public void Deposit(decimal amount)
        {
            //Balance = Balance + amount
            Balance += amount;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="amount">amount to be withdrawn</param>
        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        }
        #endregion
    }
}
