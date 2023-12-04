using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedBUF
{
    public class Goal
    {
        public int Id { get; set; }
        public Student Student { get; set; }

        public string Description { get; set; }  
        public int StudentId { get; set; }
        public List<Feedback> FeedbackOnGoal { get; set; } = new List<Feedback>();
        public List<SubTask> SubTasks { get; set; } = new List<SubTask>();
        public int Status { get; set; } = 0;
        public Student Creator { get; set; }
        public int Published { get; set; } = 0;


        public Goal()
        {
            Id = 0;
            Student = new Student();
            Description = "";
            StudentId = 0;
            Status = 0;
        }
        public Goal(int id, string Description, int studentId, int status)
        {
            this.Id = id;
            this.Description = Description;
            this.StudentId = studentId;
            this.Status = status;
        }
        public Goal(int id, Student student, string Description, int studentId, List<Feedback> feedback, int status)
        {
            this.Id = id;
            this.Student = student;
            this.Description = Description;
            this.StudentId = studentId;
            this.FeedbackOnGoal = feedback;
            this.Status = status;
        }
        public Goal(int id, string Description, int studentId, List<Feedback> feedback, int status)
        {
            this.Id = id;
            this.Description = Description;
            this.StudentId = studentId;
            this.FeedbackOnGoal = feedback;
            this.Status = status;
        }
        public Goal(int id, string description, int studentId)
        {
            this.Id = id;
            this.Description = description;
            this.StudentId = studentId;
        }
        public Goal(string description, int studentId)
        {
            this.Description = description;
            this.StudentId = studentId;
        }
        public Goal(int id, string description, int studentId, List<Feedback> feedbackOnGoal)
        {
            this.Id = id;
            this.Description= description;
            this.StudentId= studentId;
            this.FeedbackOnGoal = feedbackOnGoal;
        }

        public Goal(int goalId, string description, int studentId, int status, int creator, int published)//bij dal

        {
            this.Id= goalId;
            this.Description = description;
            foreach(Student student in Program.Students)
            {
                if(student.Id == studentId)
                {
                    this.Student = student;
                }
            }
            //this.Student = Program.Dal.GetStudentById(studentId);
            this.Status = status;
            //this.Creator = Program.Dal.GetStudentById(creator);
            foreach (Student student in Program.Students)
            {
                if (student.Id == creator)
                {
                    this.Creator = student;
                }
                this.Published = published;
            }
        }


    }
}
