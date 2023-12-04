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
    public partial class HomePageStudent : Form
    {
        public HomePageStudent()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SetGoalTXT_Click(object sender, EventArgs e)
        {
            this.Hide();
            GoalPage goalPage = new GoalPage();
            goalPage.Show();
        }

        private void FeedBackTXT_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewFeedbackPage viewFeedbackPage = new ViewFeedbackPage();
            viewFeedbackPage.Show();
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProfileStudent profileStudent = new ProfileStudent();
            profileStudent.Show();
        }

        private void HomePageStudent_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//view goals
        {
            Student student = Program.Dal.GetStudentById(Program.LoggedInStudent);
            ViewGoalPage viewGoalPage = new ViewGoalPage(student);

            viewGoalPage.Show();
        }
    }
}
