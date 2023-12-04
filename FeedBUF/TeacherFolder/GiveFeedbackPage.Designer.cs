namespace FeedBUF
{
    partial class GiveFeedbackPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.studentcombobox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxGoals = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GiveFeedbackBox = new System.Windows.Forms.RichTextBox();
            this.SaveTXT = new System.Windows.Forms.Button();
            this.subgoalbox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.feedbackgoalbox = new System.Windows.Forms.ListBox();
            this.feedbacksubgoalbox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.explanationlabel = new System.Windows.Forms.Label();
            this.currentteacher = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.exitapplication = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Controls.Add(this.logout);
            this.panel1.Controls.Add(this.exitapplication);
            this.panel1.Controls.Add(this.currentteacher);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(965, 120);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choose Student";
            // 
            // studentcombobox
            // 
            this.studentcombobox.FormattingEnabled = true;
            this.studentcombobox.Location = new System.Drawing.Point(246, 125);
            this.studentcombobox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.studentcombobox.Name = "studentcombobox";
            this.studentcombobox.Size = new System.Drawing.Size(269, 28);
            this.studentcombobox.TabIndex = 5;
            this.studentcombobox.SelectedIndexChanged += new System.EventHandler(this.studentcombobox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 40);
            this.label2.TabIndex = 6;
            this.label2.Text = "Goals of\r\nselected student";
            // 
            // listBoxGoals
            // 
            this.listBoxGoals.FormattingEnabled = true;
            this.listBoxGoals.ItemHeight = 20;
            this.listBoxGoals.Location = new System.Drawing.Point(177, 161);
            this.listBoxGoals.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxGoals.Name = "listBoxGoals";
            this.listBoxGoals.Size = new System.Drawing.Size(477, 104);
            this.listBoxGoals.TabIndex = 7;
            this.listBoxGoals.SelectedIndexChanged += new System.EventHandler(this.listBoxGoals_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(668, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Give Feedback:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // GiveFeedbackBox
            // 
            this.GiveFeedbackBox.Location = new System.Drawing.Point(671, 273);
            this.GiveFeedbackBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GiveFeedbackBox.Name = "GiveFeedbackBox";
            this.GiveFeedbackBox.Size = new System.Drawing.Size(292, 314);
            this.GiveFeedbackBox.TabIndex = 9;
            this.GiveFeedbackBox.Text = "";
            this.GiveFeedbackBox.TextChanged += new System.EventHandler(this.GiveFeedbackBox_TextChanged);
            // 
            // SaveTXT
            // 
            this.SaveTXT.Location = new System.Drawing.Point(861, 590);
            this.SaveTXT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SaveTXT.Name = "SaveTXT";
            this.SaveTXT.Size = new System.Drawing.Size(104, 36);
            this.SaveTXT.TabIndex = 10;
            this.SaveTXT.Text = "Save";
            this.SaveTXT.UseVisualStyleBackColor = true;
            this.SaveTXT.Click += new System.EventHandler(this.SaveTXT_Click);
            // 
            // subgoalbox
            // 
            this.subgoalbox.FormattingEnabled = true;
            this.subgoalbox.ItemHeight = 20;
            this.subgoalbox.Location = new System.Drawing.Point(177, 273);
            this.subgoalbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.subgoalbox.Name = "subgoalbox";
            this.subgoalbox.Size = new System.Drawing.Size(477, 104);
            this.subgoalbox.TabIndex = 11;
            this.subgoalbox.SelectedIndexChanged += new System.EventHandler(this.subgoalbox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(68, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 40);
            this.label4.TabIndex = 12;
            this.label4.Text = "Subtasks of\r\nselected goal";
            // 
            // feedbackgoalbox
            // 
            this.feedbackgoalbox.FormattingEnabled = true;
            this.feedbackgoalbox.ItemHeight = 20;
            this.feedbackgoalbox.Location = new System.Drawing.Point(177, 385);
            this.feedbackgoalbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.feedbackgoalbox.Name = "feedbackgoalbox";
            this.feedbackgoalbox.Size = new System.Drawing.Size(477, 104);
            this.feedbackgoalbox.TabIndex = 13;
            // 
            // feedbacksubgoalbox
            // 
            this.feedbacksubgoalbox.FormattingEnabled = true;
            this.feedbacksubgoalbox.ItemHeight = 20;
            this.feedbacksubgoalbox.Location = new System.Drawing.Point(177, 497);
            this.feedbacksubgoalbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.feedbacksubgoalbox.Name = "feedbacksubgoalbox";
            this.feedbacksubgoalbox.Size = new System.Drawing.Size(477, 104);
            this.feedbacksubgoalbox.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(68, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 40);
            this.label5.TabIndex = 15;
            this.label5.Text = "Feedback on\r\nselected goal.\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 497);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 40);
            this.label6.TabIndex = 16;
            this.label6.Text = "Feedback on\r\nselected subtask.";
            // 
            // explanationlabel
            // 
            this.explanationlabel.AutoSize = true;
            this.explanationlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.explanationlabel.Location = new System.Drawing.Point(669, 169);
            this.explanationlabel.Name = "explanationlabel";
            this.explanationlabel.Size = new System.Drawing.Size(283, 100);
            this.explanationlabel.TabIndex = 17;
            this.explanationlabel.Text = "A goal has to be selected.\r\nIf a subtask is selected you will give\r\nfeedback to t" +
    "hat subtask.\r\nIf a subtask is not selected you will give\r\nfeedback to the select" +
    "ed goal.\r\n";
            // 
            // currentteacher
            // 
            this.currentteacher.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.currentteacher.Location = new System.Drawing.Point(0, 4);
            this.currentteacher.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.currentteacher.Name = "currentteacher";
            this.currentteacher.Size = new System.Drawing.Size(404, 60);
            this.currentteacher.TabIndex = 18;
            this.currentteacher.Text = "Log out";
            this.currentteacher.UseVisualStyleBackColor = false;
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(700, 0);
            this.logout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(125, 60);
            this.logout.TabIndex = 20;
            this.logout.Text = "Log out";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // exitapplication
            // 
            this.exitapplication.Location = new System.Drawing.Point(831, 0);
            this.exitapplication.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exitapplication.Name = "exitapplication";
            this.exitapplication.Size = new System.Drawing.Size(131, 60);
            this.exitapplication.TabIndex = 19;
            this.exitapplication.Text = "Exit application";
            this.exitapplication.UseVisualStyleBackColor = true;
            this.exitapplication.Click += new System.EventHandler(this.exitapplication_Click);
            // 
            // GiveFeedbackPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(979, 635);
            this.Controls.Add(this.explanationlabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.feedbacksubgoalbox);
            this.Controls.Add(this.feedbackgoalbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.subgoalbox);
            this.Controls.Add(this.SaveTXT);
            this.Controls.Add(this.GiveFeedbackBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxGoals);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.studentcombobox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GiveFeedbackPage";
            this.Text = "FeedbackPage";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox studentcombobox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxGoals;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox GiveFeedbackBox;
        private System.Windows.Forms.Button SaveTXT;
        private System.Windows.Forms.ListBox subgoalbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox feedbackgoalbox;
        private System.Windows.Forms.ListBox feedbacksubgoalbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label explanationlabel;
        public System.Windows.Forms.Button currentteacher;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button exitapplication;
    }
}