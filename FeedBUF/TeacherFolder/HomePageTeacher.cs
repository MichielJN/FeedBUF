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
    public partial class HomePageTeacher : Form
    {
        public HomePageTeacher()
        {
            InitializeComponent();
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            ProfileTeacher profileTeacher = new ProfileTeacher();
            profileTeacher.Show();
        }

        private void GiveFeedbackTXT_Click(object sender, EventArgs e)
        {
            this.Hide();
            GiveFeedbackPage giveFeedbackPage = new GiveFeedbackPage();
            giveFeedbackPage.Show();
        }
    }
}
