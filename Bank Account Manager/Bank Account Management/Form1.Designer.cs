namespace Bank_Account_Management
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblAccountNumber = new Label();
            lblTransactionType = new Label();
            lblTransactionAmount = new Label();
            lblTransactionStatus = new Label();
            lblAmountBalance = new Label();
            rbtnDeposit = new RadioButton();
            rbtnWithdrawal = new RadioButton();
            lblAccountHistory = new Label();
            txtAccountNumber = new TextBox();
            txtTransactionAmount = new TextBox();
            txtTransactionStatus = new TextBox();
            txtAmountBalance = new TextBox();
            btnSubmit = new Button();
            btnGetHistory = new Button();
            btnGetStatus = new Button();
            btnClose = new Button();
            lstAccountHistory = new ListBox();
            SuspendLayout();
            // 
            // lblAccountNumber
            // 
            lblAccountNumber.Location = new Point(12, 37);
            lblAccountNumber.Name = "lblAccountNumber";
            lblAccountNumber.Size = new Size(100, 23);
            lblAccountNumber.TabIndex = 16;
            lblAccountNumber.Text = "Account Number:";
            // 
            // lblTransactionType
            // 
            lblTransactionType.Location = new Point(27, 83);
            lblTransactionType.Name = "lblTransactionType";
            lblTransactionType.Size = new Size(100, 23);
            lblTransactionType.TabIndex = 15;
            lblTransactionType.Text = "Transaction Type:";
            // 
            // lblTransactionAmount
            // 
            lblTransactionAmount.Location = new Point(12, 213);
            lblTransactionAmount.Name = "lblTransactionAmount";
            lblTransactionAmount.Size = new Size(119, 23);
            lblTransactionAmount.TabIndex = 14;
            lblTransactionAmount.Text = "Transaction Amount:";
            // 
            // lblTransactionStatus
            // 
            lblTransactionStatus.Location = new Point(12, 345);
            lblTransactionStatus.Name = "lblTransactionStatus";
            lblTransactionStatus.Size = new Size(128, 23);
            lblTransactionStatus.TabIndex = 13;
            lblTransactionStatus.Text = "Transaction Status:";
            // 
            // lblAmountBalance
            // 
            lblAmountBalance.Location = new Point(328, 41);
            lblAmountBalance.Name = "lblAmountBalance";
            lblAmountBalance.Size = new Size(100, 23);
            lblAmountBalance.TabIndex = 12;
            lblAmountBalance.Text = "Amount Balance:";
            // 
            // rbtnDeposit
            // 
            rbtnDeposit.Location = new Point(27, 126);
            rbtnDeposit.Name = "rbtnDeposit";
            rbtnDeposit.Size = new Size(104, 24);
            rbtnDeposit.TabIndex = 11;
            rbtnDeposit.Text = "Deposit";
            // 
            // rbtnWithdrawal
            // 
            rbtnWithdrawal.Location = new Point(27, 162);
            rbtnWithdrawal.Name = "rbtnWithdrawal";
            rbtnWithdrawal.Size = new Size(104, 24);
            rbtnWithdrawal.TabIndex = 10;
            rbtnWithdrawal.Text = "Withdrawal";
            // 
            // lblAccountHistory
            // 
            lblAccountHistory.Location = new Point(633, 38);
            lblAccountHistory.Name = "lblAccountHistory";
            lblAccountHistory.Size = new Size(100, 23);
            lblAccountHistory.TabIndex = 9;
            lblAccountHistory.Text = "Account History:";
            // 
            // txtAccountNumber
            // 
            txtAccountNumber.Location = new Point(122, 38);
            txtAccountNumber.Name = "txtAccountNumber";
            txtAccountNumber.ReadOnly = true;
            txtAccountNumber.Size = new Size(174, 23);
            txtAccountNumber.TabIndex = 8;
            // 
            // txtTransactionAmount
            // 
            txtTransactionAmount.Location = new Point(160, 210);
            txtTransactionAmount.Name = "txtTransactionAmount";
            txtTransactionAmount.Size = new Size(100, 23);
            txtTransactionAmount.TabIndex = 7;
            // 
            // txtTransactionStatus
            // 
            txtTransactionStatus.Location = new Point(146, 342);
            txtTransactionStatus.Name = "txtTransactionStatus";
            txtTransactionStatus.ReadOnly = true;
            txtTransactionStatus.Size = new Size(349, 23);
            txtTransactionStatus.TabIndex = 6;
            // 
            // txtAmountBalance
            // 
            txtAmountBalance.Location = new Point(441, 38);
            txtAmountBalance.Name = "txtAmountBalance";
            txtAmountBalance.ReadOnly = true;
            txtAmountBalance.Size = new Size(119, 23);
            txtAmountBalance.TabIndex = 5;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(27, 263);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 3;
            btnSubmit.Text = "Submit";
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnGetHistory
            // 
            btnGetHistory.Location = new Point(27, 398);
            btnGetHistory.Name = "btnGetHistory";
            btnGetHistory.Size = new Size(75, 23);
            btnGetHistory.TabIndex = 2;
            btnGetHistory.Text = "Get History";
            btnGetHistory.Click += btnGetHistory_Click;
            // 
            // btnGetStatus
            // 
            btnGetStatus.Location = new Point(160, 398);
            btnGetStatus.Name = "btnGetStatus";
            btnGetStatus.Size = new Size(75, 23);
            btnGetStatus.TabIndex = 1;
            btnGetStatus.Text = "Get Status";
            btnGetStatus.Click += btnGetStatus_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(677, 398);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 0;
            btnClose.Text = "Close";
            btnClose.Click += btnClose_Click;
            // 
            // lstAccountHistory
            // 
            lstAccountHistory.FormattingEnabled = true;
            lstAccountHistory.ItemHeight = 15;
            lstAccountHistory.Location = new Point(569, 65);
            lstAccountHistory.Name = "lstAccountHistory";
            lstAccountHistory.Size = new Size(219, 289);
            lstAccountHistory.TabIndex = 4;
            // 
            // Form1
            // 
            ClientSize = new Size(800, 450);
            Controls.Add(btnClose);
            Controls.Add(btnGetStatus);
            Controls.Add(btnGetHistory);
            Controls.Add(btnSubmit);
            Controls.Add(lstAccountHistory);
            Controls.Add(txtAmountBalance);
            Controls.Add(txtTransactionStatus);
            Controls.Add(txtTransactionAmount);
            Controls.Add(txtAccountNumber);
            Controls.Add(lblAccountHistory);
            Controls.Add(rbtnWithdrawal);
            Controls.Add(rbtnDeposit);
            Controls.Add(lblAmountBalance);
            Controls.Add(lblTransactionStatus);
            Controls.Add(lblTransactionAmount);
            Controls.Add(lblTransactionType);
            Controls.Add(lblAccountNumber);
            Name = "Form1";
            Text = "Bank Account Manager";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblAccountNumber;
        private Label lblTransactionType;
        private Label lblTransactionAmount;
        private Label lblTransactionStatus;
        private Label lblAmountBalance;
        private RadioButton rbtnDeposit;
        private RadioButton rbtnWithdrawal;
        private Label lblAccountHistory;
        private TextBox txtAccountNumber;
        private TextBox txtTransactionAmount;
        private TextBox txtTransactionStatus;
        private TextBox txtAmountBalance;
        private Button btnSubmit;
        private Button btnGetHistory;
        private Button btnGetStatus;
        private Button btnClose;
        private ListBox lstAccountHistory;
    }
}

