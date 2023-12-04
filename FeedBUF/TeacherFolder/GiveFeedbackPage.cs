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
    public partial class GiveFeedbackPage : Form
    {
        private List<Student> students = Program.Dal.LoadCompleteStudents();
        private Student currentstudent = new Student();
        private Goal currentGoal = new Goal();
        private SubTask currentSubTask = new SubTask();
        
        public GiveFeedbackPage()
        {
            InitializeComponent();
            foreach (Student student in students)
            {
                studentcombobox.Items.Add(student.Username);
            }
            foreach(Teacher teacher in Program.Dal.GetAllTeachers())
            {
                if (teacher.ID == Program.LoggedInTeacher)
                {
                    currentteacher.Text = "Welkom " + teacher.Username;
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void studentcombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxGoals.Items.Clear();
            subgoalbox.Items.Clear();
            feedbackgoalbox.Items.Clear();
            feedbacksubgoalbox.Items.Clear();
            foreach(Student student in students)
            {
                if(studentcombobox.Text == student.Username)
                {
                    currentstudent = student;
                    
                }
            }
            foreach (Goal goal in currentstudent.Goals)
            {
                if (goal.Status == 1)
                {
                    string newDescription = "";
                    foreach (char character in goal.Description)
                    {
                        newDescription += character + "\u0336";
                    }
                    listBoxGoals.Items.Add(newDescription);
                }
                else
                {
                    listBoxGoals.Items.Add(goal.Description);
                }
            }
        }

        private void SaveTXT_Click(object sender, EventArgs e)
        {
            if (subgoalbox.SelectedIndex == -1)//feedback on goal
            {

                foreach (Goal goal in currentstudent.Goals)
                {
                    if (goal.Description == listBoxGoals.Text | goal.Description == listBoxGoals.Text.Replace("\u0336", ""))
                    {
                        currentGoal = goal;
                        Feedback _feedback = new Feedback(GiveFeedbackBox.Text, Program.LoggedInTeacher, currentGoal.Id);
                        Program.Dal.SaveFeedBack(_feedback, 0);
                        GiveFeedbackBox.Text = "";
                        MessageBox.Show("Feedback saved correctly");


                    }
                }
            }
            else//feedback on subgoal
            {
                foreach(SubTask subtask in currentGoal.SubTasks)
                {
                    if(subtask.Description == subgoalbox.Text | subtask.Description == subgoalbox.Text.Replace("\u0336", ""))
                    {
                        currentSubTask = subtask;
                        Feedback _feedback = new Feedback(GiveFeedbackBox.Text, Program.LoggedInTeacher, currentSubTask.Id, 1);
                        Program.Dal.SaveFeedBack(_feedback, 1);
                        GiveFeedbackBox.Text = "";
                        MessageBox.Show("Feedback saved correctly");

                    }
                }

                

            }
            students = Program.Dal.LoadCompleteStudents();
            foreach (Student student in students)
            {
                if (student.Username == currentstudent.Username)
                {
                    currentstudent = student;
                }
            }


        }

        private void GiveFeedbackBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBoxGoals_SelectedIndexChanged(object sender, EventArgs e)
        {
            feedbackgoalbox.Items.Clear();
            subgoalbox.Items.Clear();
            feedbacksubgoalbox.Items.Clear();   
            foreach(Goal goal in currentstudent.Goals)
            {
                if (goal.Description == listBoxGoals.Text | goal.Description == listBoxGoals.Text.Replace("\u0336", ""))
                {
                    currentGoal = goal;                    
                }
            }
            currentGoal = Program.Dal.GetFeedbackListGoal(currentGoal);
            foreach(Feedback feedback in currentGoal.FeedbackOnGoal)
            {
                Teacher feedbackGiver = new Teacher();
                foreach(Teacher teacher in Program.Dal.GetAllTeachers())
                {
                    if (feedback.TeacherId == teacher.ID)
                    {
                        feedbackGiver = teacher;
                        
                    }
                }
                feedbackgoalbox.Items.Add(feedbackGiver.Username + ": " + feedback.Description);

            }

            foreach (SubTask subTask in currentGoal.SubTasks)
            {
                if (subTask.Status == 1)
                {
                    string newDescription = "";
                    foreach (char character in subTask.Description)
                    {
                        newDescription += character + "\u0336";
                    }
                    subgoalbox.Items.Add(newDescription);
                }
                else 
                {
                    subgoalbox.Items.Add(subTask.Description);
                }
            }

        }

        private void subgoalbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            feedbacksubgoalbox.Items.Clear();

            ShowFeedbackSubtasks();

        }

        private void ShowFeedbackSubtasks()
        {
            foreach (SubTask subtask in currentGoal.SubTasks)
            {
                if (subtask.Description == subgoalbox.Text | subtask.Description == subgoalbox.Text.Replace("\u0336", ""))
                {
                    currentSubTask = subtask;

                }
            }
            foreach (Feedback feedback in currentSubTask.FeedbackOnGoal)
            {
                foreach (Teacher teacher in Program.Dal.GetAllTeachers())
                {
                    if (teacher.ID == feedback.TeacherId)
                    {
                        feedbacksubgoalbox.Items.Add(teacher.Username + ": " + feedback.Description);

                    }
                }

            }
        }

        private void exitapplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            LoginPage logInPage = new LoginPage(1);
            logInPage.Show();
            this.Close();
        }
    }
}
