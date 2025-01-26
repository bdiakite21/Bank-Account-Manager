using System;
using System.Collections.Generic;

public class BankAccount
{
  private decimal _accountBalance;
    private List<decimal> _balanceHistory;

  public string AccountNumber { get; private set; }
   public List<decimal> BalanceHistory
    {
     get { return _balanceHistory; }
      private set { _balanceHistory = value; }
    }

   // Enum for transaction status
    public enum TransactionStatus
    {
        Ok,
        Overdrawn,
        InsufficientFunds,
        DepositTooLarge
    }

    // Constructor
    public BankAccount(string accountNumber, decimal initialBalance)
    {
        AccountNumber = accountNumber;
        _accountBalance = initialBalance;
        // Initialize history with initial balance
        _balanceHistory = new List<decimal> { _accountBalance }; 
    }

    // Deposit method
    public TransactionStatus Deposit(decimal amount)
    {
        if (amount > 10000.00m)
        {
         return TransactionStatus.DepositTooLarge; 
        }

        _accountBalance += amount;
        _balanceHistory.Insert(0, _accountBalance); 
        return TransactionStatus.Ok;
    }

      // Withdraw method
    public TransactionStatus Withdraw(decimal amount)
    {
      if (_accountBalance - amount >= -100.00m)
        {
          _accountBalance -= amount;
           if (_accountBalance < 0)
          {
                _accountBalance -= 35.75m; 
          }
          _balanceHistory.Insert(0, _accountBalance);
          return _accountBalance < 0 ? TransactionStatus.Overdrawn : TransactionStatus.Ok;
        }
        else
        {
          return TransactionStatus.InsufficientFunds;
        }
    }

    // Get account balance
    public decimal GetAccountBalance()
    {
      return _accountBalance;
    }

    // Get account status 
    public TransactionStatus GetAccountStatus()
    {
        return _accountBalance < 0 ? TransactionStatus.Overdrawn : TransactionStatus.Ok;
    }
}
