using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeedBUF
{
    public partial class Published_Goals : Form
    {
        private Student currentSTudent;
        private Goal selectedGoal;
        private Goal selectedSubGoal;
        private List<Goal> goals;
        private ListBox playerGoals;

        public Published_Goals(Student student, ListBox playerGoalsListbox)
        {
            this.playerGoals = playerGoalsListbox;
            InitializeComponent();
            currentSTudent = student;
            this.goals = Program.Dal.GetAllGoals();
            foreach(Goal goal in goals)
            {
                if (goal.Published == 1)
                {
                    GoalsOfStudentBox.Items.Add(goal.Student.Username + ": " + goal.Description);
                }
            }
        }

        private void copygoalbutton_Click(object sender, EventArgs e)
        {
            if(GoalsOfStudentBox.SelectedIndex != -1)
            {
                if(selectedGoal.Creator.Id != currentSTudent.Id)
                {
                    Goal copiedGoal = selectedGoal;
                    copiedGoal.Published = 0;
                    copiedGoal.Student = currentSTudent;
                    currentSTudent.Goals.Add(copiedGoal);
                    Program.Dal.SaveGoal(copiedGoal);
                    playerGoals.Items.Add(copiedGoal.Description);
                    MessageBox.Show("Selected goal is copied");
                    this.goals = Program.Dal.GetAllGoals();
                    
                }
                
            }
        }

        private void GoalsOfStudentBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            // string[] selectedGoalArray = GoalsOfStudentBox.Text.Split(' ');
            //List<string> selectedGoalList = selectedGoalArray.ToList();
            //selectedGoalList.RemoveAt(0);
            //string selectedGoalString = "";
            //foreach(string word in selectedGoalList)
            ///{
            //  selectedGoalString += word;
            //}
            SubGoalBox.Items.Clear();
            FeedbackonGoalsbox.Items.Clear();
            FeedbackonSubtaskBox.Items.Clear();
            string selectedGoalString = GoalsOfStudentBox.Text;
            for(int i = 0; i < GoalsOfStudentBox.Text.Length + 2; i++)
            {
                string letter = selectedGoalString[0].ToString();
                string points = " ";
                if(letter == points)
                {
                    selectedGoalString = selectedGoalString.Remove(0, 1);
                    break;
                }
                else
                {
                   selectedGoalString = selectedGoalString.Remove(0, 1);
                    
                }
                letter = selectedGoalString[0].ToString();
            }
            
            //for(int i = 0; i < selectedGoalCount + 1; i++)
            //{
            //    selectedGoalString = selectedGoalString.Remove(0, 1);
            //}
            foreach(Goal goal in goals)
            {
                if(goal.Description == selectedGoalString)
                {

                    selectedGoal = goal;
                    Program.Dal.GetFeedbackListGoal(selectedGoal);
                    Program.Dal.GetSubtaskList(selectedGoal);
                    foreach(SubTask subTask in selectedGoal.SubTasks)
                    {
                        Program.Dal.GetFeedbackListSubTask(subTask);
                    }
                    break;
                }
    
            }
            foreach (Feedback feedback in selectedGoal.FeedbackOnGoal)
            {
                FeedbackonGoalsbox.Items.Add(feedback.Description);
            }
            foreach (SubTask subTask in selectedGoal.SubTasks)
            {
                SubGoalBox.Items.Add(subTask.Description);
            }

        }

        private void SubGoalBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FeedbackonSubtaskBox.Items.Clear();
            foreach(SubTask subTask in selectedGoal.SubTasks)
            {
                if(subTask.Description == SubGoalBox.Text)
                {
                    this.selectedSubGoal = subTask;
                }
            }
            foreach(Feedback feedback in selectedSubGoal.FeedbackOnGoal)
            {
                FeedbackonSubtaskBox.Items.Add(feedback.Description);
            }
        }
    }
}
