using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedBUF
{
    public class SubTask : Goal
    {
        public Goal Goal { get; set; }

        public SubTask(int id, string description, Goal Goal)
        {
            this.Id = id;
            this.Description = description;
            this.Goal = Goal;


        }
        public SubTask(string description, Goal goal)
        {
            this.Description = description;
            this.Goal = goal;
        }
        public SubTask()
        {

        }
        public SubTask(int id, string description, Goal Goal, int status)
        {
            this.Id = id;
            this.Description = description;
            this.Goal = Goal;
            this.Status = status; 
        }
    }
     
}
