namespace FeedBUF
{
    partial class ViewGoalPage
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.studentname = new System.Windows.Forms.Button();
            this.Explanation = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Button();
            this.exitapplication = new System.Windows.Forms.Button();
            this.markgoalasfinishedbutton = new System.Windows.Forms.Button();
            this.editgoalbutton = new System.Windows.Forms.Button();
            this.deletegoalbutton = new System.Windows.Forms.Button();
            this.feedBUFDataSet = new FeedBUF.FeedBUFDataSet();
            this.feedBUFDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GoalsOfStudentBox = new System.Windows.Forms.ListBox();
            this.SubGoalBox = new System.Windows.Forms.ListBox();
            this.FeedbackonGoalsbox = new System.Windows.Forms.ListBox();
            this.FeedbackonSubtaskBox = new System.Windows.Forms.ListBox();
            this.Goallabel = new System.Windows.Forms.Label();
            this.subtasklabel = new System.Windows.Forms.Label();
            this.feedbackgoallabel = new System.Windows.Forms.Label();
            this.feedbacksubtasklabel = new System.Windows.Forms.Label();
            this.createsubtask = new System.Windows.Forms.Button();
            this.marksubgoalasfinishedbutton = new System.Windows.Forms.Button();
            this.makenewgoal = new System.Windows.Forms.Button();
            this.publishselectedgoalbuton = new System.Windows.Forms.Button();
            this.viewpublishedgoalsbuton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.feedBUFDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedBUFDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Controls.Add(this.viewpublishedgoalsbuton);
            this.panel1.Controls.Add(this.publishselectedgoalbuton);
            this.panel1.Controls.Add(this.studentname);
            this.panel1.Controls.Add(this.Explanation);
            this.panel1.Controls.Add(this.logout);
            this.panel1.Controls.Add(this.exitapplication);
            this.panel1.Location = new System.Drawing.Point(9, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(928, 120);
            this.panel1.TabIndex = 2;
            // 
            // studentname
            // 
            this.studentname.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.studentname.Location = new System.Drawing.Point(239, 9);
            this.studentname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.studentname.Name = "studentname";
            this.studentname.Size = new System.Drawing.Size(404, 60);
            this.studentname.TabIndex = 16;
            this.studentname.Text = "Log out";
            this.studentname.UseVisualStyleBackColor = false;
            // 
            // Explanation
            // 
            this.Explanation.AutoSize = true;
            this.Explanation.Location = new System.Drawing.Point(8, 9);
            this.Explanation.Name = "Explanation";
            this.Explanation.Size = new System.Drawing.Size(190, 60);
            this.Explanation.TabIndex = 15;
            this.Explanation.Text = "To see feedback \r\non a goal or subgoal\r\nclick on a goal or subgoal.\r\n";
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(649, 9);
            this.logout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(125, 60);
            this.logout.TabIndex = 1;
            this.logout.Text = "Log out";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.back_Click);
            // 
            // exitapplication
            // 
            this.exitapplication.Location = new System.Drawing.Point(780, 9);
            this.exitapplication.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exitapplication.Name = "exitapplication";
            this.exitapplication.Size = new System.Drawing.Size(131, 60);
            this.exitapplication.TabIndex = 0;
            this.exitapplication.Text = "Exit application";
            this.exitapplication.UseVisualStyleBackColor = true;
            this.exitapplication.Click += new System.EventHandler(this.ProfileButton_Click);
            // 
            // markgoalasfinishedbutton
            // 
            this.markgoalasfinishedbutton.Location = new System.Drawing.Point(-3, 214);
            this.markgoalasfinishedbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.markgoalasfinishedbutton.Name = "markgoalasfinishedbutton";
            this.markgoalasfinishedbutton.Size = new System.Drawing.Size(107, 117);
            this.markgoalasfinishedbutton.TabIndex = 4;
            this.markgoalasfinishedbutton.Text = "Mark selected goal as finished.";
            this.markgoalasfinishedbutton.UseVisualStyleBackColor = true;
            this.markgoalasfinishedbutton.Click += new System.EventHandler(this.markgoalasfinishedbutton_Click);
            // 
            // editgoalbutton
            // 
            this.editgoalbutton.Location = new System.Drawing.Point(-4, 449);
            this.editgoalbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.editgoalbutton.Name = "editgoalbutton";
            this.editgoalbutton.Size = new System.Drawing.Size(106, 29);
            this.editgoalbutton.TabIndex = 5;
            this.editgoalbutton.Text = "Edit Goal";
            this.editgoalbutton.UseVisualStyleBackColor = true;
            this.editgoalbutton.Click += new System.EventHandler(this.editgoalbutton_Click);
            // 
            // deletegoalbutton
            // 
            this.deletegoalbutton.Location = new System.Drawing.Point(-3, 486);
            this.deletegoalbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deletegoalbutton.Name = "deletegoalbutton";
            this.deletegoalbutton.Size = new System.Drawing.Size(105, 56);
            this.deletegoalbutton.TabIndex = 6;
            this.deletegoalbutton.Text = "Delete Goal";
            this.deletegoalbutton.UseVisualStyleBackColor = true;
            this.deletegoalbutton.Click += new System.EventHandler(this.deletegoalbutton_Click);
            // 
            // feedBUFDataSet
            // 
            this.feedBUFDataSet.DataSetName = "FeedBUFDataSet";
            this.feedBUFDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // feedBUFDataSetBindingSource
            // 
            this.feedBUFDataSetBindingSource.DataSource = this.feedBUFDataSet;
            this.feedBUFDataSetBindingSource.Position = 0;
            // 
            // GoalsOfStudentBox
            // 
            this.GoalsOfStudentBox.FormattingEnabled = true;
            this.GoalsOfStudentBox.ItemHeight = 20;
            this.GoalsOfStudentBox.Location = new System.Drawing.Point(245, 127);
            this.GoalsOfStudentBox.Name = "GoalsOfStudentBox";
            this.GoalsOfStudentBox.Size = new System.Drawing.Size(689, 124);
            this.GoalsOfStudentBox.TabIndex = 7;
            this.GoalsOfStudentBox.SelectedIndexChanged += new System.EventHandler(this.GoalsOfStudentBox_SelectedIndexChanged);
            // 
            // SubGoalBox
            // 
            this.SubGoalBox.FormattingEnabled = true;
            this.SubGoalBox.ItemHeight = 20;
            this.SubGoalBox.Location = new System.Drawing.Point(245, 257);
            this.SubGoalBox.Name = "SubGoalBox";
            this.SubGoalBox.Size = new System.Drawing.Size(689, 124);
            this.SubGoalBox.TabIndex = 8;
            this.SubGoalBox.SelectedIndexChanged += new System.EventHandler(this.SubGoalBox_SelectedIndexChanged);
            // 
            // FeedbackonGoalsbox
            // 
            this.FeedbackonGoalsbox.FormattingEnabled = true;
            this.FeedbackonGoalsbox.ItemHeight = 20;
            this.FeedbackonGoalsbox.Location = new System.Drawing.Point(248, 387);
            this.FeedbackonGoalsbox.Name = "FeedbackonGoalsbox";
            this.FeedbackonGoalsbox.Size = new System.Drawing.Size(689, 124);
            this.FeedbackonGoalsbox.TabIndex = 9;
            this.FeedbackonGoalsbox.SelectedIndexChanged += new System.EventHandler(this.FeedbackonGoalsbox_SelectedIndexChanged);
            // 
            // FeedbackonSubtaskBox
            // 
            this.FeedbackonSubtaskBox.FormattingEnabled = true;
            this.FeedbackonSubtaskBox.ItemHeight = 20;
            this.FeedbackonSubtaskBox.Location = new System.Drawing.Point(245, 517);
            this.FeedbackonSubtaskBox.Name = "FeedbackonSubtaskBox";
            this.FeedbackonSubtaskBox.Size = new System.Drawing.Size(689, 124);
            this.FeedbackonSubtaskBox.TabIndex = 10;
            // 
            // Goallabel
            // 
            this.Goallabel.AutoSize = true;
            this.Goallabel.Location = new System.Drawing.Point(154, 136);
            this.Goallabel.Name = "Goallabel";
            this.Goallabel.Size = new System.Drawing.Size(85, 20);
            this.Goallabel.TabIndex = 11;
            this.Goallabel.Text = "Your goals";
            this.Goallabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // subtasklabel
            // 
            this.subtasklabel.AutoSize = true;
            this.subtasklabel.Location = new System.Drawing.Point(166, 261);
            this.subtasklabel.Name = "subtasklabel";
            this.subtasklabel.Size = new System.Drawing.Size(73, 40);
            this.subtasklabel.TabIndex = 12;
            this.subtasklabel.Text = "Your\r\nsubtasks";
            // 
            // feedbackgoallabel
            // 
            this.feedbackgoallabel.AutoSize = true;
            this.feedbackgoallabel.Location = new System.Drawing.Point(132, 387);
            this.feedbackgoallabel.Name = "feedbackgoallabel";
            this.feedbackgoallabel.Size = new System.Drawing.Size(107, 40);
            this.feedbackgoallabel.TabIndex = 13;
            this.feedbackgoallabel.Text = "Feedback on\r\n selected goal";
            // 
            // feedbacksubtasklabel
            // 
            this.feedbacksubtasklabel.AutoSize = true;
            this.feedbacksubtasklabel.Location = new System.Drawing.Point(110, 517);
            this.feedbacksubtasklabel.Name = "feedbacksubtasklabel";
            this.feedbacksubtasklabel.Size = new System.Drawing.Size(129, 40);
            this.feedbacksubtasklabel.TabIndex = 14;
            this.feedbacksubtasklabel.Text = "Feedback on\r\nselected subtask";
            // 
            // createsubtask
            // 
            this.createsubtask.Location = new System.Drawing.Point(-2, 550);
            this.createsubtask.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.createsubtask.Name = "createsubtask";
            this.createsubtask.Size = new System.Drawing.Size(107, 105);
            this.createsubtask.TabIndex = 16;
            this.createsubtask.Text = "Create subtask for selected goal.";
            this.createsubtask.UseVisualStyleBackColor = true;
            this.createsubtask.Click += new System.EventHandler(this.createsubtask_Click);
            // 
            // marksubgoalasfinishedbutton
            // 
            this.marksubgoalasfinishedbutton.Location = new System.Drawing.Point(-3, 339);
            this.marksubgoalasfinishedbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.marksubgoalasfinishedbutton.Name = "marksubgoalasfinishedbutton";
            this.marksubgoalasfinishedbutton.Size = new System.Drawing.Size(107, 102);
            this.marksubgoalasfinishedbutton.TabIndex = 17;
            this.marksubgoalasfinishedbutton.Text = "Mark selected subtask as finished.";
            this.marksubgoalasfinishedbutton.UseVisualStyleBackColor = true;
            this.marksubgoalasfinishedbutton.Click += new System.EventHandler(this.marksubgoalasfinishedbutton_Click);
            // 
            // makenewgoal
            // 
            this.makenewgoal.Location = new System.Drawing.Point(-3, 127);
            this.makenewgoal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.makenewgoal.Name = "makenewgoal";
            this.makenewgoal.Size = new System.Drawing.Size(107, 79);
            this.makenewgoal.TabIndex = 18;
            this.makenewgoal.Text = "Make a new goal.";
            this.makenewgoal.UseVisualStyleBackColor = true;
            this.makenewgoal.Click += new System.EventHandler(this.makenewgoal_Click);
            // 
            // publishselectedgoalbuton
            // 
            this.publishselectedgoalbuton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.publishselectedgoalbuton.Location = new System.Drawing.Point(239, 70);
            this.publishselectedgoalbuton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.publishselectedgoalbuton.Name = "publishselectedgoalbuton";
            this.publishselectedgoalbuton.Size = new System.Drawing.Size(143, 50);
            this.publishselectedgoalbuton.TabIndex = 17;
            this.publishselectedgoalbuton.Text = "Publish selected goal";
            this.publishselectedgoalbuton.UseVisualStyleBackColor = false;
            this.publishselectedgoalbuton.Click += new System.EventHandler(this.publishselectedgoalbuton_Click);
            // 
            // viewpublishedgoalsbuton
            // 
            this.viewpublishedgoalsbuton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.viewpublishedgoalsbuton.Location = new System.Drawing.Point(388, 70);
            this.viewpublishedgoalsbuton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.viewpublishedgoalsbuton.Name = "viewpublishedgoalsbuton";
            this.viewpublishedgoalsbuton.Size = new System.Drawing.Size(143, 50);
            this.viewpublishedgoalsbuton.TabIndex = 18;
            this.viewpublishedgoalsbuton.Text = "View published goals";
            this.viewpublishedgoalsbuton.UseVisualStyleBackColor = false;
            this.viewpublishedgoalsbuton.Click += new System.EventHandler(this.viewpublishedgoalsbuton_Click);
            // 
            // ViewGoalPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(923, 648);
            this.Controls.Add(this.makenewgoal);
            this.Controls.Add(this.marksubgoalasfinishedbutton);
            this.Controls.Add(this.createsubtask);
            this.Controls.Add(this.feedbacksubtasklabel);
            this.Controls.Add(this.feedbackgoallabel);
            this.Controls.Add(this.subtasklabel);
            this.Controls.Add(this.Goallabel);
            this.Controls.Add(this.FeedbackonSubtaskBox);
            this.Controls.Add(this.FeedbackonGoalsbox);
            this.Controls.Add(this.SubGoalBox);
            this.Controls.Add(this.GoalsOfStudentBox);
            this.Controls.Add(this.deletegoalbutton);
            this.Controls.Add(this.editgoalbutton);
            this.Controls.Add(this.markgoalasfinishedbutton);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ViewGoalPage";
            this.Text = "ViewGoalPage";
            this.Load += new System.EventHandler(this.ViewGoalPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.feedBUFDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedBUFDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exitapplication;
        private System.Windows.Forms.Button markgoalasfinishedbutton;
        private System.Windows.Forms.Button editgoalbutton;
        private System.Windows.Forms.Button deletegoalbutton;
        private System.Windows.Forms.BindingSource feedBUFDataSetBindingSource;
        private FeedBUFDataSet feedBUFDataSet;
        private System.Windows.Forms.ListBox GoalsOfStudentBox;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.ListBox SubGoalBox;
        private System.Windows.Forms.ListBox FeedbackonGoalsbox;
        private System.Windows.Forms.ListBox FeedbackonSubtaskBox;
        private System.Windows.Forms.Label Goallabel;
        private System.Windows.Forms.Label subtasklabel;
        private System.Windows.Forms.Label feedbackgoallabel;
        private System.Windows.Forms.Label feedbacksubtasklabel;
        private System.Windows.Forms.Label Explanation;
        private System.Windows.Forms.Button createsubtask;
        private System.Windows.Forms.Button marksubgoalasfinishedbutton;
        private System.Windows.Forms.Button makenewgoal;
        public System.Windows.Forms.Button studentname;
        public System.Windows.Forms.Button publishselectedgoalbuton;
        public System.Windows.Forms.Button viewpublishedgoalsbuton;
    }
}