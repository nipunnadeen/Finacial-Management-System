namespace FinancialManagementApplication
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.expense = new System.Windows.Forms.Button();
            this.income = new System.Windows.Forms.Button();
            this.financialStatus = new System.Windows.Forms.Button();
            this.financialReport = new System.Windows.Forms.Button();
            this.account = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.contact = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // expense
            // 
            this.expense.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expense.Location = new System.Drawing.Point(259, 263);
            this.expense.Name = "expense";
            this.expense.Size = new System.Drawing.Size(260, 44);
            this.expense.TabIndex = 24;
            this.expense.Text = "Add Expense";
            this.expense.UseVisualStyleBackColor = true;
            this.expense.Click += new System.EventHandler(this.expense_Click);
            // 
            // income
            // 
            this.income.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income.Location = new System.Drawing.Point(259, 197);
            this.income.Name = "income";
            this.income.Size = new System.Drawing.Size(260, 44);
            this.income.TabIndex = 25;
            this.income.Text = "Add Income";
            this.income.UseVisualStyleBackColor = true;
            this.income.Click += new System.EventHandler(this.income_Click);
            // 
            // financialStatus
            // 
            this.financialStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.financialStatus.Location = new System.Drawing.Point(259, 327);
            this.financialStatus.Name = "financialStatus";
            this.financialStatus.Size = new System.Drawing.Size(260, 44);
            this.financialStatus.TabIndex = 26;
            this.financialStatus.Text = "Financial Status";
            this.financialStatus.UseVisualStyleBackColor = true;
            this.financialStatus.Click += new System.EventHandler(this.financialStatus_Click);
            // 
            // financialReport
            // 
            this.financialReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.financialReport.Location = new System.Drawing.Point(259, 392);
            this.financialReport.Name = "financialReport";
            this.financialReport.Size = new System.Drawing.Size(260, 44);
            this.financialReport.TabIndex = 27;
            this.financialReport.Text = "Financial Report";
            this.financialReport.UseVisualStyleBackColor = true;
            this.financialReport.Click += new System.EventHandler(this.financialReport_Click);
            // 
            // account
            // 
            this.account.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.account.Location = new System.Drawing.Point(259, 456);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(260, 44);
            this.account.TabIndex = 29;
            this.account.Text = "Account";
            this.account.UseVisualStyleBackColor = true;
            this.account.Click += new System.EventHandler(this.account_Click);
            // 
            // logout
            // 
            this.logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.Location = new System.Drawing.Point(640, 27);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(125, 44);
            this.logout.TabIndex = 30;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // contact
            // 
            this.contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact.Location = new System.Drawing.Point(259, 126);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(260, 44);
            this.contact.TabIndex = 31;
            this.contact.Text = "Contact";
            this.contact.UseVisualStyleBackColor = true;
            this.contact.Click += new System.EventHandler(this.contact_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 590);
            this.Controls.Add(this.contact);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.account);
            this.Controls.Add(this.financialReport);
            this.Controls.Add(this.financialStatus);
            this.Controls.Add(this.income);
            this.Controls.Add(this.expense);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button expense;
        private System.Windows.Forms.Button income;
        private System.Windows.Forms.Button financialStatus;
        private System.Windows.Forms.Button financialReport;
        private System.Windows.Forms.Button account;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button contact;
    }
}