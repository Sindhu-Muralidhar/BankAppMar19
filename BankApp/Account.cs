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
        #region statics
        /// <summary>
        /// static means shared memory across all instances. Here 
        /// private is used so customers shouldnt see
        /// </summary>
        /// 
        private static int lastAccountNumber = 0;
        
    #endregion

    
        #region Properties
        /// <summary>
        /// Unique number asscociated with a customer for their account
        /// </summary>
        
        public int AccountNumber { get; set; }
        /// <summary> 
        /// Email address of the account holder
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// Available balance
        /// </summary>
        public decimal Balance { get; private set; }
        // private set makes sure setting can be done only by class.
        //in other words it can be set only by bank
        /// <summary>
        /// Type of account
        /// </summary>
        public string AccountType { get; set; }
        /// <summary>
        /// Date when the account was created 
        /// </summary>
        public DateTime CreatedDate { get; set; }

     
    #endregion

    #region constructor
    //constructor just allocates a memory but doesnt return any value
    //constructor should always be public or else it cant call new
    //constructor should have same name as class.
     
    public Account()
    {
        lastAccountNumber++;
        AccountNumber = lastAccountNumber;
    }
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

