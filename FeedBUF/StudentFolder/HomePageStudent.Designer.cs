namespace FeedBUF
{
    partial class HomePageStudent
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ProfileButton = new System.Windows.Forms.Button();
            this.SetGoalTXT = new System.Windows.Forms.Button();
            this.FeedBackTXT = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, 142);
            this.label1.MaximumSize = new System.Drawing.Size(1125, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(504, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome student!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Controls.Add(this.ProfileButton);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(958, 120);
            this.panel1.TabIndex = 1;
            // 
            // ProfileButton
            // 
            this.ProfileButton.Location = new System.Drawing.Point(774, 0);
            this.ProfileButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ProfileButton.Name = "ProfileButton";
            this.ProfileButton.Size = new System.Drawing.Size(184, 120);
            this.ProfileButton.TabIndex = 0;
            this.ProfileButton.Text = "Profile";
            this.ProfileButton.UseVisualStyleBackColor = true;
            this.ProfileButton.Click += new System.EventHandler(this.ProfileButton_Click);
            // 
            // SetGoalTXT
            // 
            this.SetGoalTXT.Location = new System.Drawing.Point(375, 231);
            this.SetGoalTXT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SetGoalTXT.Name = "SetGoalTXT";
            this.SetGoalTXT.Size = new System.Drawing.Size(190, 79);
            this.SetGoalTXT.TabIndex = 2;
            this.SetGoalTXT.Text = "Set a goal";
            this.SetGoalTXT.UseVisualStyleBackColor = true;
            this.SetGoalTXT.Click += new System.EventHandler(this.SetGoalTXT_Click);
            // 
            // FeedBackTXT
            // 
            this.FeedBackTXT.Location = new System.Drawing.Point(375, 405);
            this.FeedBackTXT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FeedBackTXT.Name = "FeedBackTXT";
            this.FeedBackTXT.Size = new System.Drawing.Size(190, 79);
            this.FeedBackTXT.TabIndex = 3;
            this.FeedBackTXT.Text = "View Feedback";
            this.FeedBackTXT.UseVisualStyleBackColor = true;
            this.FeedBackTXT.Click += new System.EventHandler(this.FeedBackTXT_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(375, 318);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 79);
            this.button1.TabIndex = 4;
            this.button1.Text = "View my goals";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(375, 492);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 79);
            this.button2.TabIndex = 5;
            this.button2.Text = "Delete my account";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // HomePageStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(958, 650);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FeedBackTXT);
            this.Controls.Add(this.SetGoalTXT);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "HomePageStudent";
            this.Text = "HomePageStudent";
            this.Load += new System.EventHandler(this.HomePageStudent_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SetGoalTXT;
        private System.Windows.Forms.Button FeedBackTXT;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button ProfileButton;
        private System.Windows.Forms.Button button2;
    }
}