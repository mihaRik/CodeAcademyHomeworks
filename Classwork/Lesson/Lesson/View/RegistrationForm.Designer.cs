namespace Lesson.View
{
    partial class RegistrationForm
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
            this.l = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.passwordConfirmBox = new System.Windows.Forms.TextBox();
            this.userTypeSelect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addUserBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Location = new System.Drawing.Point(66, 17);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(32, 13);
            this.l.TabIndex = 5;
            this.l.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Confirm Password";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(101, 64);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(228, 20);
            this.passwordBox.TabIndex = 9;
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(101, 38);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(228, 20);
            this.usernameBox.TabIndex = 10;
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(101, 12);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(228, 20);
            this.emailBox.TabIndex = 11;
            // 
            // passwordConfirmBox
            // 
            this.passwordConfirmBox.Location = new System.Drawing.Point(101, 90);
            this.passwordConfirmBox.Name = "passwordConfirmBox";
            this.passwordConfirmBox.Size = new System.Drawing.Size(228, 20);
            this.passwordConfirmBox.TabIndex = 12;
            // 
            // userTypeSelect
            // 
            this.userTypeSelect.FormattingEnabled = true;
            this.userTypeSelect.Location = new System.Drawing.Point(101, 116);
            this.userTypeSelect.Name = "userTypeSelect";
            this.userTypeSelect.Size = new System.Drawing.Size(113, 21);
            this.userTypeSelect.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "User Type";
            // 
            // addUserBtn
            // 
            this.addUserBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUserBtn.Location = new System.Drawing.Point(254, 116);
            this.addUserBtn.Name = "addUserBtn";
            this.addUserBtn.Size = new System.Drawing.Size(75, 23);
            this.addUserBtn.TabIndex = 15;
            this.addUserBtn.Text = "Add User";
            this.addUserBtn.UseVisualStyleBackColor = true;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 151);
            this.Controls.Add(this.addUserBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userTypeSelect);
            this.Controls.Add(this.passwordConfirmBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.l);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox passwordConfirmBox;
        private System.Windows.Forms.ComboBox userTypeSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addUserBtn;
    }
}