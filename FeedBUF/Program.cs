using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeedBUF
{
    internal static class Program
    {
        public static DAL Dal = new DAL();
        public static int LoggedInStudent = -1;
        public static int LoggedInTeacher = 0;
        //public static List<Student> Students = Dal.GetAllStudents();
        public static List<Student> Students = Dal.LoadCompleteStudents();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginPage());
        }
    }
}
