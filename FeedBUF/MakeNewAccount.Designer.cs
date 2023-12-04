namespace FeedBUF
{
    partial class MakeNewAccount
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
            this.textboxdescription = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.inputwrong = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.Passwordtextboxdescription = new System.Windows.Forms.Label();
            this.sometingwrong = new System.Windows.Forms.Button();
            this.confirmaccountdetails = new System.Windows.Forms.Button();
            this.studentcheckbox = new System.Windows.Forms.CheckBox();
            this.teachercheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textboxdescription
            // 
            this.textboxdescription.AutoSize = true;
            this.textboxdescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxdescription.Location = new System.Drawing.Point(43, 39);
            this.textboxdescription.Name = "textboxdescription";
            this.textboxdescription.Size = new System.Drawing.Size(702, 29);
            this.textboxdescription.TabIndex = 4;
            this.textboxdescription.Text = "Type your school E-mail adress here, this will be your loginname";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(212, 104);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(346, 26);
            this.username.TabIndex = 5;
            // 
            // inputwrong
            // 
            this.inputwrong.AutoSize = true;
            this.inputwrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputwrong.Location = new System.Drawing.Point(72, 68);
            this.inputwrong.Name = "inputwrong";
            this.inputwrong.Size = new System.Drawing.Size(0, 44);
            this.inputwrong.TabIndex = 7;
            this.inputwrong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(212, 249);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(346, 26);
            this.Password.TabIndex = 8;
            // 
            // Passwordtextboxdescription
            // 
            this.Passwordtextboxdescription.AutoSize = true;
            this.Passwordtextboxdescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwordtextboxdescription.Location = new System.Drawing.Point(230, 204);
            this.Passwordtextboxdescription.Name = "Passwordtextboxdescription";
            this.Passwordtextboxdescription.Size = new System.Drawing.Size(303, 29);
            this.Passwordtextboxdescription.TabIndex = 9;
            this.Passwordtextboxdescription.Text = "Type your password below";
            // 
            // sometingwrong
            // 
            this.sometingwrong.Location = new System.Drawing.Point(181, 68);
            this.sometingwrong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sometingwrong.Name = "sometingwrong";
            this.sometingwrong.Size = new System.Drawing.Size(403, 29);
            this.sometingwrong.TabIndex = 16;
            this.sometingwrong.UseVisualStyleBackColor = true;
            // 
            // confirmaccountdetails
            // 
            this.confirmaccountdetails.Location = new System.Drawing.Point(564, 342);
            this.confirmaccountdetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.confirmaccountdetails.Name = "confirmaccountdetails";
            this.confirmaccountdetails.Size = new System.Drawing.Size(206, 29);
            this.confirmaccountdetails.TabIndex = 17;
            this.confirmaccountdetails.Text = "Make account";
            this.confirmaccountdetails.UseVisualStyleBackColor = true;
            this.confirmaccountdetails.Click += new System.EventHandler(this.confirmaccountdetails_Click);
            // 
            // studentcheckbox
            // 
            this.studentcheckbox.AutoSize = true;
            this.studentcheckbox.Location = new System.Drawing.Point(260, 136);
            this.studentcheckbox.Name = "studentcheckbox";
            this.studentcheckbox.Size = new System.Drawing.Size(138, 36);
            this.studentcheckbox.TabIndex = 18;
            this.studentcheckbox.Text = "Student";
            this.studentcheckbox.UseVisualStyleBackColor = true;
            // 
            // teachercheckbox
            // 
            this.teachercheckbox.AutoSize = true;
            this.teachercheckbox.Location = new System.Drawing.Point(396, 136);
            this.teachercheckbox.Name = "teachercheckbox";
            this.teachercheckbox.Size = new System.Drawing.Size(140, 36);
            this.teachercheckbox.TabIndex = 19;
            this.teachercheckbox.Text = "Teacher";
            this.teachercheckbox.UseVisualStyleBackColor = true;
            // 
            // MakeNewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.teachercheckbox);
            this.Controls.Add(this.studentcheckbox);
            this.Controls.Add(this.confirmaccountdetails);
            this.Controls.Add(this.sometingwrong);
            this.Controls.Add(this.Passwordtextboxdescription);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.inputwrong);
            this.Controls.Add(this.username);
            this.Controls.Add(this.textboxdescription);
            this.Name = "MakeNewAccount";
            this.Text = "MakeNewAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textboxdescription;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label inputwrong;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label Passwordtextboxdescription;
        private System.Windows.Forms.Button sometingwrong;
        private System.Windows.Forms.Button confirmaccountdetails;
        private System.Windows.Forms.CheckBox studentcheckbox;
        private System.Windows.Forms.CheckBox teachercheckbox;
    }
}