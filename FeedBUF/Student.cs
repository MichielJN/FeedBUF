using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedBUF
{
    public class Student
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public List<Goal> Goals { get; set; } = new List<Goal>();


        public Student()
        {
            this.Id = 0;
            this.Username = "";
            this.Password = "";
        }
        public Student(string username, string password)
        {
            Username = username;
            Password = password;
        }
        public Student(int id, string username, string password)
        {
            this.Id = id;
            this.Username = username;
            this.Password = password;
        }
        public Student(int id, string username, string password, List<Goal> goals)
        {
            this.Id= id;
            this.Username = username;
            this.Password = password;
            this.Goals = goals;
        }
    }
}
