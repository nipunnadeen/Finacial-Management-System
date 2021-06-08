namespace FinancialManagementApplication
{
    partial class FinancialReportView
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
            this.label1 = new System.Windows.Forms.Label();
            this.submitFindIncome = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.expenseEndDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.expenseStartDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.submitFindExpense = new System.Windows.Forms.Button();
            this.incomeTable = new System.Windows.Forms.DataGridView();
            this.IncomeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IncomeTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IncomeContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IncomeType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IncomeAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IncomeCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IncomeDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IncomeEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IncomeRemove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.expenseTable = new System.Windows.Forms.DataGridView();
            this.ExpenseId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpenseTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpenseContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpenseType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpenseAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpenseCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpenseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpenseEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ExpenseRemove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.backToMenu = new System.Windows.Forms.Button();
            this.incomeEndDate = new System.Windows.Forms.DateTimePicker();
            this.incomeStartDate = new System.Windows.Forms.DateTimePicker();
            this.incomeDateValidation = new System.Windows.Forms.Label();
            this.expenseDateValidation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.incomeTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 99;
            this.label1.Text = "Start Date";
            // 
            // submitFindIncome
            // 
            this.submitFindIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitFindIncome.Location = new System.Drawing.Point(850, 76);
            this.submitFindIncome.Name = "submitFindIncome";
            this.submitFindIncome.Size = new System.Drawing.Size(260, 44);
            this.submitFindIncome.TabIndex = 98;
            this.submitFindIncome.Text = "Filter Income";
            this.submitFindIncome.UseVisualStyleBackColor = true;
            this.submitFindIncome.Click += new System.EventHandler(this.submitFindIncome_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(537, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 101;
            this.label2.Text = "End Date";
            // 
            // expenseEndDate
            // 
            this.expenseEndDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseEndDate.Location = new System.Drawing.Point(551, 476);
            this.expenseEndDate.Name = "expenseEndDate";
            this.expenseEndDate.Size = new System.Drawing.Size(260, 24);
            this.expenseEndDate.TabIndex = 107;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(546, 435);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 106;
            this.label3.Text = "End Date";
            // 
            // expenseStartDate
            // 
            this.expenseStartDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseStartDate.Location = new System.Drawing.Point(240, 476);
            this.expenseStartDate.Name = "expenseStartDate";
            this.expenseStartDate.Size = new System.Drawing.Size(260, 24);
            this.expenseStartDate.TabIndex = 105;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(235, 435);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 104;
            this.label4.Text = "Start Date";
            // 
            // submitFindExpense
            // 
            this.submitFindExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitFindExpense.Location = new System.Drawing.Point(850, 455);
            this.submitFindExpense.Name = "submitFindExpense";
            this.submitFindExpense.Size = new System.Drawing.Size(260, 45);
            this.submitFindExpense.TabIndex = 103;
            this.submitFindExpense.Text = "Filter Expense";
            this.submitFindExpense.UseVisualStyleBackColor = true;
            this.submitFindExpense.Click += new System.EventHandler(this.submitFindExpense_Click);
            // 
            // incomeTable
            // 
            this.incomeTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.incomeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.incomeTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IncomeId,
            this.IncomeTitle,
            this.IncomeContact,
            this.IncomeType,
            this.IncomeAmount,
            this.IncomeCategory,
            this.IncomeDate,
            this.IncomeEdit,
            this.IncomeRemove});
            this.incomeTable.Location = new System.Drawing.Point(57, 154);
            this.incomeTable.Name = "incomeTable";
            this.incomeTable.RowHeadersWidth = 51;
            this.incomeTable.RowTemplate.Height = 24;
            this.incomeTable.Size = new System.Drawing.Size(1053, 271);
            this.incomeTable.TabIndex = 110;
            this.incomeTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.incomeTable_CellContentClick);
            // 
            // IncomeId
            // 
            this.IncomeId.HeaderText = "ID";
            this.IncomeId.MinimumWidth = 6;
            this.IncomeId.Name = "IncomeId";
            this.IncomeId.ReadOnly = true;
            this.IncomeId.Visible = false;
            // 
            // IncomeTitle
            // 
            this.IncomeTitle.HeaderText = "Title";
            this.IncomeTitle.MinimumWidth = 6;
            this.IncomeTitle.Name = "IncomeTitle";
            this.IncomeTitle.ReadOnly = true;
            // 
            // IncomeContact
            // 
            this.IncomeContact.HeaderText = "Contact";
            this.IncomeContact.MinimumWidth = 6;
            this.IncomeContact.Name = "IncomeContact";
            this.IncomeContact.ReadOnly = true;
            // 
            // IncomeType
            // 
            this.IncomeType.HeaderText = "Type";
            this.IncomeType.MinimumWidth = 6;
            this.IncomeType.Name = "IncomeType";
            this.IncomeType.ReadOnly = true;
            // 
            // IncomeAmount
            // 
            this.IncomeAmount.HeaderText = "Amount";
            this.IncomeAmount.MinimumWidth = 6;
            this.IncomeAmount.Name = "IncomeAmount";
            this.IncomeAmount.ReadOnly = true;
            // 
            // IncomeCategory
            // 
            this.IncomeCategory.HeaderText = "Category";
            this.IncomeCategory.MinimumWidth = 6;
            this.IncomeCategory.Name = "IncomeCategory";
            this.IncomeCategory.ReadOnly = true;
            // 
            // IncomeDate
            // 
            this.IncomeDate.HeaderText = "Date";
            this.IncomeDate.MinimumWidth = 6;
            this.IncomeDate.Name = "IncomeDate";
            this.IncomeDate.ReadOnly = true;
            // 
            // IncomeEdit
            // 
            this.IncomeEdit.HeaderText = "";
            this.IncomeEdit.MinimumWidth = 6;
            this.IncomeEdit.Name = "IncomeEdit";
            this.IncomeEdit.Text = "Edit";
            this.IncomeEdit.UseColumnTextForButtonValue = true;
            // 
            // IncomeRemove
            // 
            this.IncomeRemove.HeaderText = "";
            this.IncomeRemove.MinimumWidth = 6;
            this.IncomeRemove.Name = "IncomeRemove";
            this.IncomeRemove.Text = "Remove";
            this.IncomeRemove.UseColumnTextForButtonValue = true;
            // 
            // expenseTable
            // 
            this.expenseTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.expenseTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.expenseTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ExpenseId,
            this.ExpenseTitle,
            this.ExpenseContact,
            this.ExpenseType,
            this.ExpenseAmount,
            this.ExpenseCategory,
            this.ExpenseDate,
            this.ExpenseEdit,
            this.ExpenseRemove});
            this.expenseTable.Location = new System.Drawing.Point(57, 536);
            this.expenseTable.Name = "expenseTable";
            this.expenseTable.RowHeadersWidth = 51;
            this.expenseTable.RowTemplate.Height = 24;
            this.expenseTable.Size = new System.Drawing.Size(1053, 285);
            this.expenseTable.TabIndex = 111;
            this.expenseTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.expenseTable_CellContentClick);
            // 
            // ExpenseId
            // 
            this.ExpenseId.HeaderText = "ID";
            this.ExpenseId.MinimumWidth = 6;
            this.ExpenseId.Name = "ExpenseId";
            this.ExpenseId.ReadOnly = true;
            this.ExpenseId.Visible = false;
            // 
            // ExpenseTitle
            // 
            this.ExpenseTitle.HeaderText = "Title";
            this.ExpenseTitle.MinimumWidth = 6;
            this.ExpenseTitle.Name = "ExpenseTitle";
            this.ExpenseTitle.ReadOnly = true;
            // 
            // ExpenseContact
            // 
            this.ExpenseContact.HeaderText = "Contact";
            this.ExpenseContact.MinimumWidth = 6;
            this.ExpenseContact.Name = "ExpenseContact";
            this.ExpenseContact.ReadOnly = true;
            // 
            // ExpenseType
            // 
            this.ExpenseType.HeaderText = "Type";
            this.ExpenseType.MinimumWidth = 6;
            this.ExpenseType.Name = "ExpenseType";
            this.ExpenseType.ReadOnly = true;
            // 
            // ExpenseAmount
            // 
            this.ExpenseAmount.HeaderText = "Amount";
            this.ExpenseAmount.MinimumWidth = 6;
            this.ExpenseAmount.Name = "ExpenseAmount";
            this.ExpenseAmount.ReadOnly = true;
            // 
            // ExpenseCategory
            // 
            this.ExpenseCategory.HeaderText = "Category";
            this.ExpenseCategory.MinimumWidth = 6;
            this.ExpenseCategory.Name = "ExpenseCategory";
            this.ExpenseCategory.ReadOnly = true;
            // 
            // ExpenseDate
            // 
            this.ExpenseDate.HeaderText = "Date";
            this.ExpenseDate.MinimumWidth = 6;
            this.ExpenseDate.Name = "ExpenseDate";
            this.ExpenseDate.ReadOnly = true;
            // 
            // ExpenseEdit
            // 
            this.ExpenseEdit.HeaderText = "";
            this.ExpenseEdit.MinimumWidth = 6;
            this.ExpenseEdit.Name = "ExpenseEdit";
            this.ExpenseEdit.Text = "Edit";
            this.ExpenseEdit.UseColumnTextForButtonValue = true;
            // 
            // ExpenseRemove
            // 
            this.ExpenseRemove.HeaderText = "";
            this.ExpenseRemove.MinimumWidth = 6;
            this.ExpenseRemove.Name = "ExpenseRemove";
            this.ExpenseRemove.Text = "Remove";
            this.ExpenseRemove.UseColumnTextForButtonValue = true;
            // 
            // backToMenu
            // 
            this.backToMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToMenu.Location = new System.Drawing.Point(936, 11);
            this.backToMenu.Name = "backToMenu";
            this.backToMenu.Size = new System.Drawing.Size(174, 38);
            this.backToMenu.TabIndex = 112;
            this.backToMenu.Text = "Back to Menu";
            this.backToMenu.UseVisualStyleBackColor = true;
            this.backToMenu.Click += new System.EventHandler(this.backToMenu_Click);
            // 
            // incomeEndDate
            // 
            this.incomeEndDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeEndDate.Checked = false;
            this.incomeEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeEndDate.Location = new System.Drawing.Point(542, 96);
            this.incomeEndDate.Name = "incomeEndDate";
            this.incomeEndDate.Size = new System.Drawing.Size(260, 24);
            this.incomeEndDate.TabIndex = 113;
            // 
            // incomeStartDate
            // 
            this.incomeStartDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeStartDate.Checked = false;
            this.incomeStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeStartDate.Location = new System.Drawing.Point(229, 96);
            this.incomeStartDate.Name = "incomeStartDate";
            this.incomeStartDate.Size = new System.Drawing.Size(260, 24);
            this.incomeStartDate.TabIndex = 114;
            // 
            // incomeDateValidation
            // 
            this.incomeDateValidation.AutoSize = true;
            this.incomeDateValidation.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.incomeDateValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeDateValidation.ForeColor = System.Drawing.Color.Crimson;
            this.incomeDateValidation.Location = new System.Drawing.Point(543, 129);
            this.incomeDateValidation.Name = "incomeDateValidation";
            this.incomeDateValidation.Size = new System.Drawing.Size(0, 17);
            this.incomeDateValidation.TabIndex = 115;
            // 
            // expenseDateValidation
            // 
            this.expenseDateValidation.AutoSize = true;
            this.expenseDateValidation.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.expenseDateValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseDateValidation.ForeColor = System.Drawing.Color.Crimson;
            this.expenseDateValidation.Location = new System.Drawing.Point(551, 510);
            this.expenseDateValidation.Name = "expenseDateValidation";
            this.expenseDateValidation.Size = new System.Drawing.Size(0, 17);
            this.expenseDateValidation.TabIndex = 116;
            // 
            // FinancialReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 835);
            this.Controls.Add(this.expenseDateValidation);
            this.Controls.Add(this.incomeDateValidation);
            this.Controls.Add(this.incomeStartDate);
            this.Controls.Add(this.incomeEndDate);
            this.Controls.Add(this.backToMenu);
            this.Controls.Add(this.expenseTable);
            this.Controls.Add(this.incomeTable);
            this.Controls.Add(this.expenseEndDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.expenseStartDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.submitFindExpense);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submitFindIncome);
            this.Name = "FinancialReportView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Financial Report";
            this.Load += new System.EventHandler(this.FinancialReportView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.incomeTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submitFindIncome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker expenseEndDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker expenseStartDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button submitFindExpense;
        private System.Windows.Forms.DataGridView incomeTable;
        private System.Windows.Forms.DataGridView expenseTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn IncomeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn IncomeTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn IncomeContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn IncomeType;
        private System.Windows.Forms.DataGridViewTextBoxColumn IncomeAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn IncomeCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn IncomeDate;
        private System.Windows.Forms.DataGridViewButtonColumn IncomeEdit;
        private System.Windows.Forms.DataGridViewButtonColumn IncomeRemove;
        private System.Windows.Forms.Button backToMenu;
        private System.Windows.Forms.DateTimePicker incomeEndDate;
        private System.Windows.Forms.DateTimePicker incomeStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpenseId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpenseTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpenseContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpenseType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpenseAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpenseCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpenseDate;
        private System.Windows.Forms.DataGridViewButtonColumn ExpenseEdit;
        private System.Windows.Forms.DataGridViewButtonColumn ExpenseRemove;
        private System.Windows.Forms.Label incomeDateValidation;
        private System.Windows.Forms.Label expenseDateValidation;
    }
}