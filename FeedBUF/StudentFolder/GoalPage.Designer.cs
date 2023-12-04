namespace FeedBUF
{
    partial class GoalPage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.back = new System.Windows.Forms.Button();
            this.exitapplication = new System.Windows.Forms.Button();
            this.titlelabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SaveTXT = new System.Windows.Forms.Button();
            this.GoalBox = new System.Windows.Forms.RichTextBox();
            this.logout = new System.Windows.Forms.Button();
            this.studentname = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Controls.Add(this.studentname);
            this.panel1.Controls.Add(this.logout);
            this.panel1.Controls.Add(this.back);
            this.panel1.Controls.Add(this.exitapplication);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 120);
            this.panel1.TabIndex = 2;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(523, 0);
            this.back.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(126, 43);
            this.back.TabIndex = 1;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // exitapplication
            // 
            this.exitapplication.Location = new System.Drawing.Point(787, 0);
            this.exitapplication.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exitapplication.Name = "exitapplication";
            this.exitapplication.Size = new System.Drawing.Size(140, 43);
            this.exitapplication.TabIndex = 0;
            this.exitapplication.Text = "Exit application";
            this.exitapplication.UseVisualStyleBackColor = true;
            this.exitapplication.Click += new System.EventHandler(this.exitapplication_Click);
            // 
            // titlelabel
            // 
            this.titlelabel.AutoSize = true;
            this.titlelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelabel.Location = new System.Drawing.Point(332, 190);
            this.titlelabel.Name = "titlelabel";
            this.titlelabel.Size = new System.Drawing.Size(208, 29);
            this.titlelabel.TabIndex = 3;
            this.titlelabel.Text = "What is your goal?";
            this.titlelabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 521);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Deadline";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(14, 576);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(228, 26);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // SaveTXT
            // 
            this.SaveTXT.Location = new System.Drawing.Point(842, 511);
            this.SaveTXT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SaveTXT.Name = "SaveTXT";
            this.SaveTXT.Size = new System.Drawing.Size(104, 109);
            this.SaveTXT.TabIndex = 15;
            this.SaveTXT.Text = "Save";
            this.SaveTXT.UseVisualStyleBackColor = true;
            this.SaveTXT.Click += new System.EventHandler(this.SaveTXT_Click);
            // 
            // GoalBox
            // 
            this.GoalBox.Location = new System.Drawing.Point(337, 241);
            this.GoalBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GoalBox.Name = "GoalBox";
            this.GoalBox.Size = new System.Drawing.Size(228, 214);
            this.GoalBox.TabIndex = 5;
            this.GoalBox.Text = "";
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(655, 0);
            this.logout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(126, 43);
            this.logout.TabIndex = 2;
            this.logout.Text = "Log out";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // studentname
            // 
            this.studentname.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.studentname.Location = new System.Drawing.Point(3, 4);
            this.studentname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.studentname.Name = "studentname";
            this.studentname.Size = new System.Drawing.Size(404, 60);
            this.studentname.TabIndex = 17;
            this.studentname.Text = "Log out";
            this.studentname.UseVisualStyleBackColor = false;
            // 
            // GoalPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(939, 619);
            this.Controls.Add(this.SaveTXT);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GoalBox);
            this.Controls.Add(this.titlelabel);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GoalPage";
            this.Text = "GoalPage";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exitapplication;
        private System.Windows.Forms.Label titlelabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button SaveTXT;
        private System.Windows.Forms.RichTextBox GoalBox;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button logout;
        public System.Windows.Forms.Button studentname;
    }
}