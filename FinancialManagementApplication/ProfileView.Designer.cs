namespace FinancialManagementApplication
{
    partial class ProfileView
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
            this.submitUpdateUser = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.updateLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.updateFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.updateConfirmPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.updatePassword = new System.Windows.Forms.TextBox();
            this.updateEmail = new System.Windows.Forms.TextBox();
            this.updateProfileValidation = new System.Windows.Forms.Label();
            this.updatePasswordValidation = new System.Windows.Forms.Label();
            this.submitUpdatePassword = new System.Windows.Forms.Button();
            this.backToMenu = new System.Windows.Forms.Button();
            this.submitUpdateProfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // submitUpdateUser
            // 
            this.submitUpdateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitUpdateUser.Location = new System.Drawing.Point(518, 291);
            this.submitUpdateUser.Name = "submitUpdateUser";
            this.submitUpdateUser.Size = new System.Drawing.Size(260, 44);
            this.submitUpdateUser.TabIndex = 23;
            this.submitUpdateUser.Text = "Update Email";
            this.submitUpdateUser.UseVisualStyleBackColor = true;
            this.submitUpdateUser.Click += new System.EventHandler(this.updateSubmit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(151, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 25);
            this.label5.TabIndex = 115;
            this.label5.Text = "Last Name";
            // 
            // updateLastName
            // 
            this.updateLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateLastName.Location = new System.Drawing.Point(156, 192);
            this.updateLastName.Name = "updateLastName";
            this.updateLastName.Size = new System.Drawing.Size(260, 38);
            this.updateLastName.TabIndex = 114;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(151, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 25);
            this.label4.TabIndex = 113;
            this.label4.Text = "First Name";
            // 
            // updateFirstName
            // 
            this.updateFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateFirstName.Location = new System.Drawing.Point(156, 110);
            this.updateFirstName.Name = "updateFirstName";
            this.updateFirstName.Size = new System.Drawing.Size(260, 38);
            this.updateFirstName.TabIndex = 112;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(151, 482);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 25);
            this.label2.TabIndex = 111;
            this.label2.Text = "Confirm Password";
            // 
            // updateConfirmPassword
            // 
            this.updateConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateConfirmPassword.Location = new System.Drawing.Point(156, 510);
            this.updateConfirmPassword.Name = "updateConfirmPassword";
            this.updateConfirmPassword.Size = new System.Drawing.Size(260, 38);
            this.updateConfirmPassword.TabIndex = 110;
            this.updateConfirmPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(151, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 25);
            this.label3.TabIndex = 109;
            this.label3.Text = "New Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 108;
            this.label1.Text = "Email";
            // 
            // updatePassword
            // 
            this.updatePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatePassword.Location = new System.Drawing.Point(156, 425);
            this.updatePassword.Name = "updatePassword";
            this.updatePassword.Size = new System.Drawing.Size(260, 38);
            this.updatePassword.TabIndex = 107;
            this.updatePassword.UseSystemPasswordChar = true;
            // 
            // updateEmail
            // 
            this.updateEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateEmail.Location = new System.Drawing.Point(156, 293);
            this.updateEmail.Name = "updateEmail";
            this.updateEmail.Size = new System.Drawing.Size(260, 38);
            this.updateEmail.TabIndex = 106;
            // 
            // updateProfileValidation
            // 
            this.updateProfileValidation.AutoSize = true;
            this.updateProfileValidation.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.updateProfileValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateProfileValidation.ForeColor = System.Drawing.Color.Crimson;
            this.updateProfileValidation.Location = new System.Drawing.Point(162, 345);
            this.updateProfileValidation.Name = "updateProfileValidation";
            this.updateProfileValidation.Size = new System.Drawing.Size(0, 24);
            this.updateProfileValidation.TabIndex = 116;
            // 
            // updatePasswordValidation
            // 
            this.updatePasswordValidation.AutoSize = true;
            this.updatePasswordValidation.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.updatePasswordValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatePasswordValidation.ForeColor = System.Drawing.Color.Crimson;
            this.updatePasswordValidation.Location = new System.Drawing.Point(524, 418);
            this.updatePasswordValidation.Name = "updatePasswordValidation";
            this.updatePasswordValidation.Size = new System.Drawing.Size(0, 24);
            this.updatePasswordValidation.TabIndex = 118;
            // 
            // submitUpdatePassword
            // 
            this.submitUpdatePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitUpdatePassword.Location = new System.Drawing.Point(518, 459);
            this.submitUpdatePassword.Name = "submitUpdatePassword";
            this.submitUpdatePassword.Size = new System.Drawing.Size(260, 44);
            this.submitUpdatePassword.TabIndex = 117;
            this.submitUpdatePassword.Text = "Update Password";
            this.submitUpdatePassword.UseVisualStyleBackColor = true;
            this.submitUpdatePassword.Click += new System.EventHandler(this.submitUpdatePassword_Click);
            // 
            // backToMenu
            // 
            this.backToMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToMenu.Location = new System.Drawing.Point(679, 28);
            this.backToMenu.Name = "backToMenu";
            this.backToMenu.Size = new System.Drawing.Size(174, 38);
            this.backToMenu.TabIndex = 131;
            this.backToMenu.Text = "Back to Menu";
            this.backToMenu.UseVisualStyleBackColor = true;
            this.backToMenu.Click += new System.EventHandler(this.backToMenu_Click);
            // 
            // submitUpdateProfile
            // 
            this.submitUpdateProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitUpdateProfile.Location = new System.Drawing.Point(518, 146);
            this.submitUpdateProfile.Name = "submitUpdateProfile";
            this.submitUpdateProfile.Size = new System.Drawing.Size(260, 44);
            this.submitUpdateProfile.TabIndex = 132;
            this.submitUpdateProfile.Text = "Update Profile";
            this.submitUpdateProfile.UseVisualStyleBackColor = true;
            this.submitUpdateProfile.Click += new System.EventHandler(this.submitUpdateProfile_Click);
            // 
            // ProfileView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(884, 581);
            this.Controls.Add(this.submitUpdateProfile);
            this.Controls.Add(this.backToMenu);
            this.Controls.Add(this.updatePasswordValidation);
            this.Controls.Add(this.submitUpdatePassword);
            this.Controls.Add(this.updateProfileValidation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.updateLastName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.updateFirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.updateConfirmPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updatePassword);
            this.Controls.Add(this.updateEmail);
            this.Controls.Add(this.submitUpdateUser);
            this.Name = "ProfileView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Account";
            this.Load += new System.EventHandler(this.ProfileView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button submitUpdateUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox updateLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox updateFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox updateConfirmPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox updatePassword;
        private System.Windows.Forms.TextBox updateEmail;
        private System.Windows.Forms.Label updateProfileValidation;
        private System.Windows.Forms.Label updatePasswordValidation;
        private System.Windows.Forms.Button submitUpdatePassword;
        private System.Windows.Forms.Button backToMenu;
        private System.Windows.Forms.Button submitUpdateProfile;
    }
}