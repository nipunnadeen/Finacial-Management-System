namespace FinancialManagementApplication
{
    partial class AddExpenseView
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.submitAddExpense = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addExpenseCategory = new System.Windows.Forms.ComboBox();
            this.addExpenseDate = new System.Windows.Forms.DateTimePicker();
            this.expenseValidation = new System.Windows.Forms.Label();
            this.addExpenseName = new System.Windows.Forms.TextBox();
            this.addExpenseContact = new System.Windows.Forms.ComboBox();
            this.addExpenseType = new System.Windows.Forms.ComboBox();
            this.cancelAddExpense = new System.Windows.Forms.Button();
            this.addExpenseAmount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(461, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 25);
            this.label5.TabIndex = 51;
            this.label5.Text = "Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(120, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 25);
            this.label4.TabIndex = 49;
            this.label4.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(461, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 47;
            this.label3.Text = "Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(461, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 25);
            this.label1.TabIndex = 46;
            this.label1.Text = "Date";
            // 
            // submitAddExpense
            // 
            this.submitAddExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitAddExpense.Location = new System.Drawing.Point(125, 447);
            this.submitAddExpense.Name = "submitAddExpense";
            this.submitAddExpense.Size = new System.Drawing.Size(260, 44);
            this.submitAddExpense.TabIndex = 45;
            this.submitAddExpense.Text = "Submit";
            this.submitAddExpense.UseVisualStyleBackColor = true;
            this.submitAddExpense.Click += new System.EventHandler(this.submitAddExpense_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 25);
            this.label2.TabIndex = 52;
            this.label2.Text = "Choose the Contact";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(120, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(245, 25);
            this.label6.TabIndex = 54;
            this.label6.Text = "Choose the Expense Type";
            // 
            // addExpenseCategory
            // 
            this.addExpenseCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.addExpenseCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addExpenseCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addExpenseCategory.FormattingEnabled = true;
            this.addExpenseCategory.Location = new System.Drawing.Point(466, 222);
            this.addExpenseCategory.Name = "addExpenseCategory";
            this.addExpenseCategory.Size = new System.Drawing.Size(260, 37);
            this.addExpenseCategory.TabIndex = 97;
            // 
            // addExpenseDate
            // 
            this.addExpenseDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addExpenseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addExpenseDate.Location = new System.Drawing.Point(466, 337);
            this.addExpenseDate.Name = "addExpenseDate";
            this.addExpenseDate.Size = new System.Drawing.Size(260, 24);
            this.addExpenseDate.TabIndex = 99;
            // 
            // expenseValidation
            // 
            this.expenseValidation.AutoSize = true;
            this.expenseValidation.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.expenseValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseValidation.ForeColor = System.Drawing.Color.Crimson;
            this.expenseValidation.Location = new System.Drawing.Point(132, 401);
            this.expenseValidation.Name = "expenseValidation";
            this.expenseValidation.Size = new System.Drawing.Size(0, 24);
            this.expenseValidation.TabIndex = 102;
            // 
            // addExpenseName
            // 
            this.addExpenseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addExpenseName.Location = new System.Drawing.Point(125, 123);
            this.addExpenseName.Name = "addExpenseName";
            this.addExpenseName.Size = new System.Drawing.Size(260, 38);
            this.addExpenseName.TabIndex = 103;
            // 
            // addExpenseContact
            // 
            this.addExpenseContact.BackColor = System.Drawing.SystemColors.HighlightText;
            this.addExpenseContact.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addExpenseContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addExpenseContact.FormattingEnabled = true;
            this.addExpenseContact.Location = new System.Drawing.Point(125, 222);
            this.addExpenseContact.Name = "addExpenseContact";
            this.addExpenseContact.Size = new System.Drawing.Size(260, 37);
            this.addExpenseContact.TabIndex = 104;
            // 
            // addExpenseType
            // 
            this.addExpenseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addExpenseType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addExpenseType.FormattingEnabled = true;
            this.addExpenseType.Location = new System.Drawing.Point(125, 337);
            this.addExpenseType.Name = "addExpenseType";
            this.addExpenseType.Size = new System.Drawing.Size(260, 37);
            this.addExpenseType.TabIndex = 105;
            // 
            // cancelAddExpense
            // 
            this.cancelAddExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelAddExpense.Location = new System.Drawing.Point(466, 447);
            this.cancelAddExpense.Name = "cancelAddExpense";
            this.cancelAddExpense.Size = new System.Drawing.Size(260, 44);
            this.cancelAddExpense.TabIndex = 107;
            this.cancelAddExpense.Text = "Cancel";
            this.cancelAddExpense.UseVisualStyleBackColor = true;
            this.cancelAddExpense.Click += new System.EventHandler(this.cancelAddExpense_Click);
            // 
            // addExpenseAmount
            // 
            this.addExpenseAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addExpenseAmount.Location = new System.Drawing.Point(466, 123);
            this.addExpenseAmount.Name = "addExpenseAmount";
            this.addExpenseAmount.Size = new System.Drawing.Size(260, 38);
            this.addExpenseAmount.TabIndex = 108;
            // 
            // AddExpenseView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 529);
            this.Controls.Add(this.addExpenseAmount);
            this.Controls.Add(this.cancelAddExpense);
            this.Controls.Add(this.addExpenseType);
            this.Controls.Add(this.addExpenseContact);
            this.Controls.Add(this.addExpenseName);
            this.Controls.Add(this.expenseValidation);
            this.Controls.Add(this.addExpenseDate);
            this.Controls.Add(this.addExpenseCategory);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submitAddExpense);
            this.Name = "AddExpenseView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddExpense";
            this.Load += new System.EventHandler(this.AddExpenseView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submitAddExpense;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox addExpenseCategory;
        private System.Windows.Forms.DateTimePicker addExpenseDate;
        private System.Windows.Forms.Label expenseValidation;
        private System.Windows.Forms.TextBox addExpenseName;
        private System.Windows.Forms.ComboBox addExpenseContact;
        private System.Windows.Forms.ComboBox addExpenseType;
        private System.Windows.Forms.Button cancelAddExpense;
        private System.Windows.Forms.TextBox addExpenseAmount;
    }
}