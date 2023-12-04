using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeedBUF
{
    public partial class LoginPage : Form
    {
        private int formHasToClose = 0; 
        public LoginPage()
        {
            InitializeComponent();
        }
        public LoginPage(int close)
        {
            InitializeComponent();
            formHasToClose = 1;
            Program.LoggedInTeacher = 0;
            Program.LoggedInStudent = 0;

        }

        private void LoginTXT_Click(object sender, EventArgs e)
        {
            string username = UsernameTXT.Text;
            string password = PasswordTXT.Text;

            // here you can hardcode the user data or retrieve it from another source, such as an XML file
            List<Teacher> teachers = Program.Dal.GetAllTeachers();
            int studentId = 0;
            foreach(Student student in Program.Dal.LoadCompleteStudents())
            {
                if (student.Username == username & student.Password == password)
                {
                    Program.LoggedInStudent = student.Id;
                    studentId = student.Id;
                    ViewGoalPage viewGoalPage = new ViewGoalPage(student);
                    viewGoalPage.studentname.Text = "Welkom " + student.Username;
                    viewGoalPage.Show();
                    if (formHasToClose != 0)
                    {
                        this.Close();
                    }
                    else
                    {
                        this.Hide();
                    }


                    this.Hide();
                }
            }
            foreach(Teacher teacher in teachers)
            {
                if(teacher.Username == username & teacher.Password == password)
                {
                    // login as a teacher
                    // redirect to teacher homepage
                    Program.LoggedInTeacher = teacher.ID;
                    GiveFeedbackPage giveFeedbackPage = new GiveFeedbackPage();
                    giveFeedbackPage.Show();                    
                    if (formHasToClose != 0)
                    {
                        this.Close();
                    }
                    else
                    {
                        this.Hide();
                    }

                }

            }
            somethingwrong.Text = "Invalid login details";
            if (username == "Teacher" && password == "Teacher")
            {
                // login as a teacher
                MessageBox.Show("You have been logged in as a teacher.");
                // redirect to teacher homepage
                HomePageTeacher teacherHomepage = new HomePageTeacher();
                teacherHomepage.Show();
                if (formHasToClose != 0)
                {
                    this.Close();
                }
                else
                {
                    this.Hide();
                }
            }
            else if (username == "Student" && password == "Student")
            {
                // login as a student
                MessageBox.Show("You have been logged in as a student.");
                // redirect to student homepage
                HomePageStudent studentHomepage = new HomePageStudent();
                studentHomepage.Show();
                if(formHasToClose != 0)
                {
                    this.Close();
                }
                else
                {
                    this.Hide();
                }
                
            }
            else
            {
                // invalid username or password
            }
        }

        private void Makenewaccount_Click(object sender, EventArgs e)
        {
            MakeNewAccount makeNewAccount = new MakeNewAccount();
            makeNewAccount.Show();
        }
    }
}





