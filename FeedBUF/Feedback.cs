  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedBUF
{
    public class Feedback
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int TeacherId { get; set; }

        public int GoalId { get; set; }
        public int SubGoalId { get; set; }


        /*public Feedback(int iD, string description, Teacher teacher, Goal goal)

        {
            ID = iD;
            Description = description;
            Teacher = teacher;
            Goal = goal;
        }*/
        public Feedback(int Id, string description, int teacherId, int goalId)
        {
            this.Id = Id;
            this.Description = description;
            this.TeacherId = teacherId;
            this.GoalId = goalId;
        }
        public Feedback(int Id, string description, int teacherId, int subGoalId, int isSubGoal)
        {
            this.Id = Id;
            this.Description = description;
            this.TeacherId = teacherId;
            this.SubGoalId = subGoalId;
        }
        public Feedback(string description, int teacherId, int goalId)
        {
            this.Description=description;
            this.TeacherId=teacherId;
            this.GoalId=goalId;

        }
        public Feedback(string description, int teacherId, int subGoalId, int isSubgoal)
        {
            this.Description = description;
            this.TeacherId = teacherId;
            this.SubGoalId = subGoalId;
        }
    }
}
