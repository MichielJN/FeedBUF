using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedBUF
{
    public class Teacher
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public List<Student> Students { get; set; }

        public Teacher(int ID, string Username, string Password)
        {
            this.ID = ID;
            this.Username = Username;
            this.Password = Password;
        }
        public Teacher(string userName, string password)
        {
            this.Username = userName;
            this.Password = password;
        }
        public Teacher()
        {

        }
    }
}
