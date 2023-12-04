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
    public partial class GoalPage : Form
    {
        private Student currentStudent = new Student();
        private int changingGoal = 0;
        public Goal GoalForSubtask { get; set; }    
        public Goal GoaltoChange { get; set; }
        public GoalPage()
        {
            InitializeComponent();
        }
        public GoalPage(Goal goal, int number)//make subtask
        {
            changingGoal = 2;
            GoalForSubtask = goal;
            InitializeComponent();
            SaveTXT.Text = "Save subtask";
            titlelabel.Text = $"Create subgoal for {goal.Description}";
            foreach (Student student in Program.Dal.LoadCompleteStudents())
            {
                if (student.Id == Program.LoggedInStudent)
                {
                    currentStudent = student;
                }
            }
            foreach (Student student in Program.Dal.LoadCompleteStudents())
            {
                if (student.Id == Program.LoggedInStudent)
                {
                    currentStudent = student;
                }
            }
            studentname.Text = "Welkom " + currentStudent.Username;
        }
        public GoalPage(Goal goal)//change goal
        {
            this.changingGoal = 1;
            this.GoaltoChange = goal;
            InitializeComponent();
            GoalBox.Text = this.GoaltoChange.Description;
            SaveTXT.Text = "Save changes";
            titlelabel.Text = "Change goal";
            foreach (Student student in Program.Dal.LoadCompleteStudents())
            {
                if (student.Id == Program.LoggedInStudent)
                {
                    currentStudent = student;
                }
            }
            studentname.Text = "Welkom " + currentStudent.Username;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SaveTXT_Click(object sender, EventArgs e)
        {
            if (this.changingGoal == 0)
            {
                Goal goal = new Goal(GoalBox.Text, Program.LoggedInStudent);
                Program.Dal.AddGoal(GoalBox.Text, Program.LoggedInStudent);
                MessageBox.Show("Goal saved succesfully");
                Student currentStudent = Program.Dal.GetStudentById(Program.LoggedInStudent);
                currentStudent = Program.Dal.GetStudentGoals(currentStudent);
                ViewGoalPage viewGoalPage = new ViewGoalPage(currentStudent);
                viewGoalPage.Show();
                this.Close();
            }
            else if(this.changingGoal == 2)
            {
                SubTask subtask = new SubTask(GoalBox.Text, GoalForSubtask);
                Program.Dal.SaveSubTask(subtask);
                MessageBox.Show("Subtask saved correctly");
                ViewGoalPage viewGoalPage = new ViewGoalPage(currentStudent);
                viewGoalPage.Show();
                this.Close();

            }
            else
            {
                GoaltoChange.Description = GoalBox.Text;
                Program.Dal.UpdateGoal(this.GoaltoChange);
                MessageBox.Show("changes saved succesfully");
               // Student currentStudent = Program.Dal.GetStudentById(Program.LoggedInStudent);
                foreach(Student student in Program.Dal.LoadCompleteStudents())
                {
                    if(student.Id == Program.LoggedInStudent)
                    {
                        currentStudent = student;
                        break;
                    }
                }
                ViewGoalPage viewGoalPage = new ViewGoalPage(currentStudent);
                viewGoalPage.Show();
                this.Close();

            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            
            ViewGoalPage viewGoalPage = new ViewGoalPage(currentStudent);
            viewGoalPage.Show();
            this.Close();
        }

        private void exitapplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Program.LoggedInStudent = 0;
            LoginPage loginPage = new LoginPage(1);
            loginPage.Show();
            this.Close();
        }
    }
}
