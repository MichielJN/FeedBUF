namespace FeedBUF
{
    partial class HomePageTeacher
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
            this.GiveFeedbackTXT = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 110);
            this.label1.MaximumSize = new System.Drawing.Size(1000, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome Teacher!";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Controls.Add(this.ProfileButton);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 96);
            this.panel1.TabIndex = 2;
            // 
            // ProfileButton
            // 
            this.ProfileButton.Location = new System.Drawing.Point(732, 0);
            this.ProfileButton.Name = "ProfileButton";
            this.ProfileButton.Size = new System.Drawing.Size(164, 96);
            this.ProfileButton.TabIndex = 0;
            this.ProfileButton.Text = "Profile";
            this.ProfileButton.UseVisualStyleBackColor = true;
            this.ProfileButton.Click += new System.EventHandler(this.ProfileButton_Click);
            // 
            // GiveFeedbackTXT
            // 
            this.GiveFeedbackTXT.Location = new System.Drawing.Point(357, 285);
            this.GiveFeedbackTXT.Name = "GiveFeedbackTXT";
            this.GiveFeedbackTXT.Size = new System.Drawing.Size(144, 60);
            this.GiveFeedbackTXT.TabIndex = 3;
            this.GiveFeedbackTXT.Text = "Give feedback";
            this.GiveFeedbackTXT.UseVisualStyleBackColor = true;
            this.GiveFeedbackTXT.Click += new System.EventHandler(this.GiveFeedbackTXT_Click);
            // 
            // HomePageTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(900, 504);
            this.Controls.Add(this.GiveFeedbackTXT);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "HomePageTeacher";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ProfileButton;
        private System.Windows.Forms.Button GiveFeedbackTXT;
    }
}

