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
    public partial class MakeNewAccount : Form
    {
        public MakeNewAccount()
        {
            InitializeComponent();
        }

        private void confirmaccountdetails_Click(object sender, EventArgs e)
        {
            List<Student> students = Program.Dal.GetAllStudents();
            List<Teacher> teachers = Program.Dal.GetAllTeachers();
            sometingwrong.Text = "";
            CheckAccountDetails(students, teachers);

        }

        private void CheckAccountDetails(List<Student> students, List<Teacher> teachers)
        {
            if (username.Text.Contains("@zuyd.nl"))
            {
                if (Password.Text.Count() > 0)
                {
                    if (studentcheckbox.Checked == true)
                    {
                        foreach (Student _student in students)
                        {
                            if (_student.Username == username.Text)
                            {
                                sometingwrong.Text = "E-mail already exists";
                            }
                        }
                        if (sometingwrong.Text != "E-mail already exists")
                        {
                            Student student = new Student(username.Text, Password.Text);
                            Program.Dal.AddStudent(student);
                            MessageBox.Show("You succesfully created a student account.");
                            this.Close();
                        }
                    }
                    else if (teachercheckbox.Checked == true)
                    {
                        foreach (Teacher _teacher in teachers)
                        {
                            if (_teacher.Username == username.Text)
                            {
                                sometingwrong.Text = "E-mail already exists";
                            }
                        }
                        if (sometingwrong.Text != "E-mail already exists")
                        {
                            Teacher teacher = new Teacher(username.Text, Password.Text);
                            Program.Dal.AddTeacher(teacher);
                            MessageBox.Show("You succesfully created a teacher account.");
                            this.Close();
                        }
                    }
                    else
                    {
                        sometingwrong.Text = "Select wether you are a student or a teacher";
                    }
                }

                else
                {
                    sometingwrong.Text = "Password must have at least one character.";
                }
            }
            else
            {
                sometingwrong.Text = "Username must be an E-mail from Zuyd hogeschool.";
            }
        }
    }
}
