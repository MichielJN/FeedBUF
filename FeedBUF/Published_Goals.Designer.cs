namespace FeedBUF
{
    partial class Published_Goals
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
            this.feedbacksubtasklabel = new System.Windows.Forms.Label();
            this.feedbackgoallabel = new System.Windows.Forms.Label();
            this.subtasklabel = new System.Windows.Forms.Label();
            this.Goallabel = new System.Windows.Forms.Label();
            this.FeedbackonSubtaskBox = new System.Windows.Forms.ListBox();
            this.FeedbackonGoalsbox = new System.Windows.Forms.ListBox();
            this.SubGoalBox = new System.Windows.Forms.ListBox();
            this.GoalsOfStudentBox = new System.Windows.Forms.ListBox();
            this.copygoalbutton = new System.Windows.Forms.Button();
            this.closewindowbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // feedbacksubtasklabel
            // 
            this.feedbacksubtasklabel.AutoSize = true;
            this.feedbacksubtasklabel.Location = new System.Drawing.Point(92, 504);
            this.feedbacksubtasklabel.Name = "feedbacksubtasklabel";
            this.feedbacksubtasklabel.Size = new System.Drawing.Size(129, 40);
            this.feedbacksubtasklabel.TabIndex = 22;
            this.feedbacksubtasklabel.Text = "Feedback on\r\nselected subtask";
            // 
            // feedbackgoallabel
            // 
            this.feedbackgoallabel.AutoSize = true;
            this.feedbackgoallabel.Location = new System.Drawing.Point(114, 374);
            this.feedbackgoallabel.Name = "feedbackgoallabel";
            this.feedbackgoallabel.Size = new System.Drawing.Size(107, 40);
            this.feedbackgoallabel.TabIndex = 21;
            this.feedbackgoallabel.Text = "Feedback on\r\n selected goal";
            // 
            // subtasklabel
            // 
            this.subtasklabel.AutoSize = true;
            this.subtasklabel.Location = new System.Drawing.Point(24, 244);
            this.subtasklabel.Name = "subtasklabel";
            this.subtasklabel.Size = new System.Drawing.Size(197, 20);
            this.subtasklabel.TabIndex = 20;
            this.subtasklabel.Text = "Subtasks for selected goal";
            // 
            // Goallabel
            // 
            this.Goallabel.AutoSize = true;
            this.Goallabel.Location = new System.Drawing.Point(92, 114);
            this.Goallabel.Name = "Goallabel";
            this.Goallabel.Size = new System.Drawing.Size(120, 20);
            this.Goallabel.TabIndex = 19;
            this.Goallabel.Text = "Published goals";
            // 
            // FeedbackonSubtaskBox
            // 
            this.FeedbackonSubtaskBox.FormattingEnabled = true;
            this.FeedbackonSubtaskBox.ItemHeight = 20;
            this.FeedbackonSubtaskBox.Location = new System.Drawing.Point(227, 504);
            this.FeedbackonSubtaskBox.Name = "FeedbackonSubtaskBox";
            this.FeedbackonSubtaskBox.Size = new System.Drawing.Size(689, 124);
            this.FeedbackonSubtaskBox.TabIndex = 18;
            // 
            // FeedbackonGoalsbox
            // 
            this.FeedbackonGoalsbox.FormattingEnabled = true;
            this.FeedbackonGoalsbox.ItemHeight = 20;
            this.FeedbackonGoalsbox.Location = new System.Drawing.Point(230, 374);
            this.FeedbackonGoalsbox.Name = "FeedbackonGoalsbox";
            this.FeedbackonGoalsbox.Size = new System.Drawing.Size(689, 124);
            this.FeedbackonGoalsbox.TabIndex = 17;
            // 
            // SubGoalBox
            // 
            this.SubGoalBox.FormattingEnabled = true;
            this.SubGoalBox.ItemHeight = 20;
            this.SubGoalBox.Location = new System.Drawing.Point(227, 244);
            this.SubGoalBox.Name = "SubGoalBox";
            this.SubGoalBox.Size = new System.Drawing.Size(689, 124);
            this.SubGoalBox.TabIndex = 16;
            this.SubGoalBox.SelectedIndexChanged += new System.EventHandler(this.SubGoalBox_SelectedIndexChanged);
            // 
            // GoalsOfStudentBox
            // 
            this.GoalsOfStudentBox.FormattingEnabled = true;
            this.GoalsOfStudentBox.ItemHeight = 20;
            this.GoalsOfStudentBox.Location = new System.Drawing.Point(227, 114);
            this.GoalsOfStudentBox.Name = "GoalsOfStudentBox";
            this.GoalsOfStudentBox.Size = new System.Drawing.Size(689, 124);
            this.GoalsOfStudentBox.TabIndex = 15;
            this.GoalsOfStudentBox.SelectedIndexChanged += new System.EventHandler(this.GoalsOfStudentBox_SelectedIndexChanged);
            // 
            // copygoalbutton
            // 
            this.copygoalbutton.Location = new System.Drawing.Point(678, 645);
            this.copygoalbutton.Name = "copygoalbutton";
            this.copygoalbutton.Size = new System.Drawing.Size(238, 97);
            this.copygoalbutton.TabIndex = 23;
            this.copygoalbutton.Text = "Copy selected goal";
            this.copygoalbutton.UseVisualStyleBackColor = true;
            this.copygoalbutton.Click += new System.EventHandler(this.copygoalbutton_Click);
            // 
            // closewindowbutton
            // 
            this.closewindowbutton.Location = new System.Drawing.Point(723, 24);
            this.closewindowbutton.Name = "closewindowbutton";
            this.closewindowbutton.Size = new System.Drawing.Size(184, 52);
            this.closewindowbutton.TabIndex = 24;
            this.closewindowbutton.Text = "Close window";
            this.closewindowbutton.UseVisualStyleBackColor = true;
            // 
            // Published_Goals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 796);
            this.Controls.Add(this.closewindowbutton);
            this.Controls.Add(this.copygoalbutton);
            this.Controls.Add(this.feedbacksubtasklabel);
            this.Controls.Add(this.feedbackgoallabel);
            this.Controls.Add(this.subtasklabel);
            this.Controls.Add(this.Goallabel);
            this.Controls.Add(this.FeedbackonSubtaskBox);
            this.Controls.Add(this.FeedbackonGoalsbox);
            this.Controls.Add(this.SubGoalBox);
            this.Controls.Add(this.GoalsOfStudentBox);
            this.Name = "Published_Goals";
            this.Text = "Published_Goals";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label feedbacksubtasklabel;
        private System.Windows.Forms.Label feedbackgoallabel;
        private System.Windows.Forms.Label subtasklabel;
        private System.Windows.Forms.Label Goallabel;
        private System.Windows.Forms.ListBox FeedbackonSubtaskBox;
        private System.Windows.Forms.ListBox FeedbackonGoalsbox;
        private System.Windows.Forms.ListBox SubGoalBox;
        private System.Windows.Forms.ListBox GoalsOfStudentBox;
        private System.Windows.Forms.Button copygoalbutton;
        private System.Windows.Forms.Button closewindowbutton;
    }
}