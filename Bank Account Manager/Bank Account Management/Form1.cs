using System;
using System.Windows.Forms;

namespace Bank_Account_Management
{
    public partial class Form1 : Form
   {
      private BankAccount _account;
        public Form1()
      {
        InitializeComponent();
        _account = new BankAccount("000302019", 1362.59m);  
         DisplayAccountInfo();
      }
      private void Form1_Load(object sender, EventArgs e)
        {
            
        }
       private void DisplayAccountInfo()
        {
          txtAccountNumber.Text = $" {_account.AccountNumber}";
          txtAmountBalance.Text = $" ${_account.GetAccountBalance():0.00}";
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
          decimal amount;
           if (!decimal.TryParse(txtTransactionAmount.Text, out amount))
            {
             MessageBox.Show("Please enter a valid amount.");
              return;
            }
          BankAccount.TransactionStatus status;
          if (rbtnDeposit.Checked)
            {
                status = _account.Deposit(amount);
            }
          else if (rbtnWithdrawal.Checked)
            {
            status = _account.Withdraw(amount);
            }
          else
            {
            MessageBox.Show("Please select a transaction type.");
            return;
            }

            // Handle transaction status
            switch (status)
            {
              case BankAccount.TransactionStatus.Ok:
                    txtTransactionStatus.Text = "Transaction successful.";
                 break;
              case BankAccount.TransactionStatus.Overdrawn:
                 txtTransactionStatus.Text = "Your account is overdrawn. Please make a deposit.";
                  break;
              case BankAccount.TransactionStatus.InsufficientFunds:
                    txtTransactionStatus.Text = "Your account has insufficient funds for this transaction.";
                   break;
                case BankAccount.TransactionStatus.DepositTooLarge:
                  txtTransactionStatus.Text = "The deposit amount is too large and cannot be submitted.";
                  break;
            }
            DisplayAccountInfo();
        }
        private void btnGetHistory_Click(object sender, EventArgs e)
        {
            lstAccountHistory.Items.Clear();
            // Add transaction history to the list box 
            foreach (var (balance, index) in _account.BalanceHistory.Select((balance, index) => (balance, index)))
            {
                lstAccountHistory.Items.Add($"${balance:0.00}");
            }
        }
        private void btnGetStatus_Click(object sender, EventArgs e)
        {
            BankAccount.TransactionStatus status = _account.GetAccountStatus();
            if (status == BankAccount.TransactionStatus.Ok)
            {
              MessageBox.Show("Your account is in good standing.");
            }
            else
            {
             MessageBox.Show("Your account is overdrawn. Please make a deposit.");
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
      // Close the application
            this.Close();  
        }
    }
}
