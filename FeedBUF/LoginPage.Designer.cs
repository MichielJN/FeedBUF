namespace FeedBUF
{
    partial class LoginPage
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
            this.UsernameTXT = new System.Windows.Forms.TextBox();
            this.PasswordTXT = new System.Windows.Forms.TextBox();
            this.LoginTXT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Makenewaccount = new System.Windows.Forms.Button();
            this.somethingwrong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UsernameTXT
            // 
            this.UsernameTXT.Location = new System.Drawing.Point(82, 186);
            this.UsernameTXT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UsernameTXT.Name = "UsernameTXT";
            this.UsernameTXT.Size = new System.Drawing.Size(112, 26);
            this.UsernameTXT.TabIndex = 0;
            // 
            // PasswordTXT
            // 
            this.PasswordTXT.Location = new System.Drawing.Point(82, 280);
            this.PasswordTXT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PasswordTXT.Name = "PasswordTXT";
            this.PasswordTXT.Size = new System.Drawing.Size(112, 26);
            this.PasswordTXT.TabIndex = 1;
            // 
            // LoginTXT
            // 
            this.LoginTXT.Location = new System.Drawing.Point(299, 369);
            this.LoginTXT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LoginTXT.Name = "LoginTXT";
            this.LoginTXT.Size = new System.Drawing.Size(112, 44);
            this.LoginTXT.TabIndex = 2;
            this.LoginTXT.Text = "Login";
            this.LoginTXT.UseVisualStyleBackColor = true;
            this.LoginTXT.Click += new System.EventHandler(this.LoginTXT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // Makenewaccount
            // 
            this.Makenewaccount.Location = new System.Drawing.Point(40, 328);
            this.Makenewaccount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Makenewaccount.Name = "Makenewaccount";
            this.Makenewaccount.Size = new System.Drawing.Size(191, 44);
            this.Makenewaccount.TabIndex = 5;
            this.Makenewaccount.Text = "Make new account";
            this.Makenewaccount.UseVisualStyleBackColor = true;
            this.Makenewaccount.Click += new System.EventHandler(this.Makenewaccount_Click);
            // 
            // somethingwrong
            // 
            this.somethingwrong.Location = new System.Drawing.Point(40, 114);
            this.somethingwrong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.somethingwrong.Name = "somethingwrong";
            this.somethingwrong.Size = new System.Drawing.Size(191, 44);
            this.somethingwrong.TabIndex = 6;
            this.somethingwrong.UseVisualStyleBackColor = true;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(493, 702);
            this.Controls.Add(this.somethingwrong);
            this.Controls.Add(this.Makenewaccount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginTXT);
            this.Controls.Add(this.PasswordTXT);
            this.Controls.Add(this.UsernameTXT);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LoginPage";
            this.Text = "LoginPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UsernameTXT;
        private System.Windows.Forms.TextBox PasswordTXT;
        private System.Windows.Forms.Button LoginTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Makenewaccount;
        private System.Windows.Forms.Button somethingwrong;
    }
}