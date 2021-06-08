namespace FinancialManagementApplication
{
    partial class SignUpView
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
            this.signUp = new System.Windows.Forms.Button();
            this.signIn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.registerLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.registerFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.registerConfirmPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.registerPassword = new System.Windows.Forms.TextBox();
            this.registerEmail = new System.Windows.Forms.TextBox();
            this.registerValidation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // signUp
            // 
            this.signUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUp.Location = new System.Drawing.Point(117, 419);
            this.signUp.Name = "signUp";
            this.signUp.Size = new System.Drawing.Size(260, 44);
            this.signUp.TabIndex = 11;
            this.signUp.Text = "Register";
            this.signUp.UseVisualStyleBackColor = true;
            this.signUp.Click += new System.EventHandler(this.signUp_Click);
            // 
            // signIn
            // 
            this.signIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signIn.Location = new System.Drawing.Point(458, 418);
            this.signIn.Name = "signIn";
            this.signIn.Size = new System.Drawing.Size(260, 45);
            this.signIn.TabIndex = 8;
            this.signIn.Text = "Sign In";
            this.signIn.UseVisualStyleBackColor = true;
            this.signIn.Click += new System.EventHandler(this.signIn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(453, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 25);
            this.label5.TabIndex = 29;
            this.label5.Text = "Last Name";
            // 
            // registerLastName
            // 
            this.registerLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerLastName.Location = new System.Drawing.Point(458, 102);
            this.registerLastName.Name = "registerLastName";
            this.registerLastName.Size = new System.Drawing.Size(260, 38);
            this.registerLastName.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(112, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "First Name";
            // 
            // registerFirstName
            // 
            this.registerFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerFirstName.Location = new System.Drawing.Point(117, 102);
            this.registerFirstName.Name = "registerFirstName";
            this.registerFirstName.Size = new System.Drawing.Size(260, 38);
            this.registerFirstName.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Confirm Password";
            // 
            // registerConfirmPassword
            // 
            this.registerConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerConfirmPassword.Location = new System.Drawing.Point(117, 306);
            this.registerConfirmPassword.Name = "registerConfirmPassword";
            this.registerConfirmPassword.Size = new System.Drawing.Size(260, 38);
            this.registerConfirmPassword.TabIndex = 24;
            this.registerConfirmPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(453, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Email";
            // 
            // registerPassword
            // 
            this.registerPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerPassword.Location = new System.Drawing.Point(458, 204);
            this.registerPassword.Name = "registerPassword";
            this.registerPassword.Size = new System.Drawing.Size(260, 38);
            this.registerPassword.TabIndex = 21;
            this.registerPassword.UseSystemPasswordChar = true;
            // 
            // registerEmail
            // 
            this.registerEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerEmail.Location = new System.Drawing.Point(117, 204);
            this.registerEmail.Name = "registerEmail";
            this.registerEmail.Size = new System.Drawing.Size(260, 38);
            this.registerEmail.TabIndex = 20;
            // 
            // registerValidation
            // 
            this.registerValidation.AutoSize = true;
            this.registerValidation.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.registerValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerValidation.ForeColor = System.Drawing.Color.Crimson;
            this.registerValidation.Location = new System.Drawing.Point(113, 367);
            this.registerValidation.Name = "registerValidation";
            this.registerValidation.Size = new System.Drawing.Size(0, 24);
            this.registerValidation.TabIndex = 30;
            // 
            // SignUpView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 506);
            this.Controls.Add(this.registerValidation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.registerLastName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.registerFirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.registerConfirmPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registerPassword);
            this.Controls.Add(this.registerEmail);
            this.Controls.Add(this.signUp);
            this.Controls.Add(this.signIn);
            this.Name = "SignUpView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button signUp;
        private System.Windows.Forms.Button signIn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox registerLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox registerFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox registerConfirmPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox registerPassword;
        private System.Windows.Forms.TextBox registerEmail;
        private System.Windows.Forms.Label registerValidation;
    }
}