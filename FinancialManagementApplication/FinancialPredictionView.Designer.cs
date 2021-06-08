namespace FinancialManagementApplication
{
    partial class FinancialPredictionView
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
            this.prediction = new System.Windows.Forms.Button();
            this.futureDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.avgExpenseAmount = new System.Windows.Forms.Label();
            this.avgIncomeAmount = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.recurrentExpenseAmount = new System.Windows.Forms.Label();
            this.oneOfExpenseAmount = new System.Windows.Forms.Label();
            this.recurrentIncomeAmount = new System.Windows.Forms.Label();
            this.oneOfIncomeAmount = new System.Windows.Forms.Label();
            this.backToMenu = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.statusAmount = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.statusSummery = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // prediction
            // 
            this.prediction.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prediction.Location = new System.Drawing.Point(514, 88);
            this.prediction.Name = "prediction";
            this.prediction.Size = new System.Drawing.Size(260, 45);
            this.prediction.TabIndex = 1;
            this.prediction.Text = "Predict Status";
            this.prediction.UseVisualStyleBackColor = true;
            this.prediction.Click += new System.EventHandler(this.prediction_Click);
            // 
            // futureDate
            // 
            this.futureDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.futureDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.futureDate.Location = new System.Drawing.Point(230, 109);
            this.futureDate.MinDate = new System.DateTime(2021, 1, 6, 0, 0, 0, 0);
            this.futureDate.Name = "futureDate";
            this.futureDate.Size = new System.Drawing.Size(260, 24);
            this.futureDate.TabIndex = 99;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 118;
            this.label1.Text = "Incomes Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(401, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 119;
            this.label2.Text = "Expenses Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 120;
            this.label3.Text = "Amounts";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(634, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 121;
            this.label4.Text = "Amounts";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 17);
            this.label5.TabIndex = 122;
            this.label5.Text = "Total One-of Incomes :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 17);
            this.label6.TabIndex = 123;
            this.label6.Text = "Total Recurrent Incomes :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(401, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 17);
            this.label7.TabIndex = 124;
            this.label7.Text = "Total One-of Expenses :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(401, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 17);
            this.label8.TabIndex = 125;
            this.label8.Text = "Total Recurrent Expenses :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 17);
            this.label9.TabIndex = 126;
            this.label9.Text = "Predicted Avg. Income :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(396, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 17);
            this.label10.TabIndex = 127;
            this.label10.Text = "Predicted Avg. Expense :";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.avgExpenseAmount);
            this.panel1.Controls.Add(this.avgIncomeAmount);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(0, 159);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 58);
            this.panel1.TabIndex = 128;
            // 
            // avgExpenseAmount
            // 
            this.avgExpenseAmount.AutoSize = true;
            this.avgExpenseAmount.Location = new System.Drawing.Point(613, 20);
            this.avgExpenseAmount.Name = "avgExpenseAmount";
            this.avgExpenseAmount.Size = new System.Drawing.Size(0, 17);
            this.avgExpenseAmount.TabIndex = 134;
            // 
            // avgIncomeAmount
            // 
            this.avgIncomeAmount.AutoSize = true;
            this.avgIncomeAmount.Location = new System.Drawing.Point(225, 20);
            this.avgIncomeAmount.Name = "avgIncomeAmount";
            this.avgIncomeAmount.Size = new System.Drawing.Size(0, 17);
            this.avgIncomeAmount.TabIndex = 133;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.recurrentExpenseAmount);
            this.panel2.Controls.Add(this.oneOfExpenseAmount);
            this.panel2.Controls.Add(this.recurrentIncomeAmount);
            this.panel2.Controls.Add(this.oneOfIncomeAmount);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(20, 153);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(754, 219);
            this.panel2.TabIndex = 129;
            // 
            // recurrentExpenseAmount
            // 
            this.recurrentExpenseAmount.AutoSize = true;
            this.recurrentExpenseAmount.Location = new System.Drawing.Point(614, 111);
            this.recurrentExpenseAmount.Name = "recurrentExpenseAmount";
            this.recurrentExpenseAmount.Size = new System.Drawing.Size(0, 17);
            this.recurrentExpenseAmount.TabIndex = 132;
            // 
            // oneOfExpenseAmount
            // 
            this.oneOfExpenseAmount.AutoSize = true;
            this.oneOfExpenseAmount.Location = new System.Drawing.Point(614, 74);
            this.oneOfExpenseAmount.Name = "oneOfExpenseAmount";
            this.oneOfExpenseAmount.Size = new System.Drawing.Size(0, 17);
            this.oneOfExpenseAmount.TabIndex = 131;
            // 
            // recurrentIncomeAmount
            // 
            this.recurrentIncomeAmount.AutoSize = true;
            this.recurrentIncomeAmount.Location = new System.Drawing.Point(226, 111);
            this.recurrentIncomeAmount.Name = "recurrentIncomeAmount";
            this.recurrentIncomeAmount.Size = new System.Drawing.Size(0, 17);
            this.recurrentIncomeAmount.TabIndex = 130;
            // 
            // oneOfIncomeAmount
            // 
            this.oneOfIncomeAmount.AutoSize = true;
            this.oneOfIncomeAmount.Location = new System.Drawing.Point(226, 74);
            this.oneOfIncomeAmount.Name = "oneOfIncomeAmount";
            this.oneOfIncomeAmount.Size = new System.Drawing.Size(0, 17);
            this.oneOfIncomeAmount.TabIndex = 129;
            // 
            // backToMenu
            // 
            this.backToMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToMenu.Location = new System.Drawing.Point(12, 12);
            this.backToMenu.Name = "backToMenu";
            this.backToMenu.Size = new System.Drawing.Size(174, 38);
            this.backToMenu.TabIndex = 130;
            this.backToMenu.Text = "Back to Menu";
            this.backToMenu.UseVisualStyleBackColor = true;
            this.backToMenu.Click += new System.EventHandler(this.backToMenu_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.statusAmount);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Location = new System.Drawing.Point(20, 378);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(754, 58);
            this.panel3.TabIndex = 131;
            // 
            // statusAmount
            // 
            this.statusAmount.AutoSize = true;
            this.statusAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusAmount.Location = new System.Drawing.Point(532, 15);
            this.statusAmount.Name = "statusAmount";
            this.statusAmount.Size = new System.Drawing.Size(0, 20);
            this.statusAmount.TabIndex = 135;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(201, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(307, 24);
            this.label11.TabIndex = 128;
            this.label11.Text = "Predicted Financial Status Amount :";
            // 
            // statusSummery
            // 
            this.statusSummery.AutoSize = true;
            this.statusSummery.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusSummery.Location = new System.Drawing.Point(27, 455);
            this.statusSummery.Name = "statusSummery";
            this.statusSummery.Size = new System.Drawing.Size(0, 20);
            this.statusSummery.TabIndex = 136;
            // 
            // FinancialPredictionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 555);
            this.Controls.Add(this.statusSummery);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.backToMenu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.futureDate);
            this.Controls.Add(this.prediction);
            this.Name = "FinancialPredictionView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Financial Prediction";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button prediction;
        private System.Windows.Forms.DateTimePicker futureDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label avgExpenseAmount;
        private System.Windows.Forms.Label avgIncomeAmount;
        private System.Windows.Forms.Label recurrentExpenseAmount;
        private System.Windows.Forms.Label oneOfExpenseAmount;
        private System.Windows.Forms.Label recurrentIncomeAmount;
        private System.Windows.Forms.Label oneOfIncomeAmount;
        private System.Windows.Forms.Button backToMenu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label statusAmount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label statusSummery;
    }
}