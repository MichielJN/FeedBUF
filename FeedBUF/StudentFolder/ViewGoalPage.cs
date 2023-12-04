using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//er moet voor gezorgd worden dat je niet niks kan typen bij description.
namespace FeedBUF
{
    public partial class ViewGoalPage : Form
    {
        private List<Student> students = Program.Dal.LoadCompleteStudents();
        private Teacher currentTeacher = new Teacher();
        private List<Goal> goalList = new List<Goal>();
        private Student currentStudent = new Student();
        private Goal currentGoal = new Goal();
        private SubTask currentSubTask = new SubTask();
        public ViewGoalPage(Student loggedInStudent)
        {
            currentStudent = loggedInStudent;
            List<Goal> updatedgoals = new List<Goal>();
            foreach(Goal goal in currentStudent.Goals)
            {
                updatedgoals.Add(Program.Dal.GetSubtaskList(goal));

            }
            foreach(Goal goal in updatedgoals)
            {
                List<SubTask> updatedsubtasks = new List<SubTask>();
                foreach(SubTask task in goal.SubTasks)
                {
                    updatedsubtasks.Add( Program.Dal.GetFeedbackListSubTask(task));
                }
                goal.SubTasks = updatedsubtasks;
            }
            currentStudent.Goals = updatedgoals;

            goalList = currentStudent.Goals;
            InitializeComponent();

            //foreach(Student _student in students)
            //{
            //   if(_student.Id == Program.LoggedInStudent)
            //    {
            //         student = Program.Dal.GetStudentGoals(_student);
            //    }
            //}

            foreach (Goal goal in currentStudent.Goals)
            {
                if (goal.Status == 1)
                {
                    string newDescription = "";
                    foreach (char character in goal.Description)
                    {
                        newDescription += character + "\u0336";
                    }
                    GoalsOfStudentBox.Items.Add(newDescription);
                }
                else
                {
                    GoalsOfStudentBox.Items.Add(goal.Description);
                }
            }
            studentname.Text = "Welkom " + currentStudent.Username;
        }

        private void ProfileButton_Click(object sender, EventArgs e)//exit application
        {
            Application.Exit();
        }

        private void back_Click(object sender, EventArgs e)
        {
            
            LoginPage loginPage = new LoginPage(1);
            loginPage.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FeedbackonGoalsbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SubGoalBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FeedbackonSubtaskBox.Items.Clear();
            

            foreach(SubTask subTask in currentGoal.SubTasks)
            {
                if(subTask.Description == SubGoalBox.Text | subTask.Description == SubGoalBox.Text.Replace("\u0336", ""))
                {
                    currentSubTask = subTask;
                    break;
                }
            }
            if(currentSubTask.Status == 0)
            {
                marksubgoalasfinishedbutton.Text = "Mark selected subtask as finished.";
            }
            else if(currentSubTask.Status == 1)
            {
                marksubgoalasfinishedbutton.Text = "Mark selected subtask as not finished";
            }  
            
            foreach(Feedback feedback in currentSubTask.FeedbackOnGoal)
            {
                foreach (Teacher teacher in Program.Dal.GetAllTeachers())
                {
                    if (teacher.ID == feedback.TeacherId)
                    {
                        FeedbackonSubtaskBox.Items.Add(teacher.Username + ": " + feedback.Description);
                    }
                }
                
            }
        }

        private void GoalsOfStudentBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GoalsOfStudentBox.Text.Contains("\u0336"))
            {
                markgoalasfinishedbutton.Text = "Mark selected goal as not finished";
            }
            else
            {
                markgoalasfinishedbutton.Text = "Mark selected goal as finished";
            }
            FeedbackonGoalsbox.Items.Clear();
            SubGoalBox.Items.Clear();
            foreach(Goal goal in currentStudent.Goals)
            {
                if(goal.Description == GoalsOfStudentBox.Text | goal.Description == GoalsOfStudentBox.Text.Replace("\u0336", ""))
                {
                    currentGoal = goal;
                    break;
                }            
            }
            
            foreach(SubTask subTask in currentGoal.SubTasks)
            {
                if (subTask.Status == 1)
                {
                    string newDescription = "";
                    foreach (char character in subTask.Description)
                    {
                        newDescription += character + "\u0336";
                    }
                    SubGoalBox.Items.Add(newDescription);
                }
                else
                {
                    SubGoalBox.Items.Add(subTask.Description);
                }
            }
            foreach(Feedback feedback in currentGoal.FeedbackOnGoal)
            {
                string teacherName = "";
                foreach(Teacher teacher in Program.Dal.GetAllTeachers())
                {
                    if(teacher.ID == feedback.TeacherId)
                    {
                        teacherName = teacher.Username;
                    }
                }
                FeedbackonGoalsbox.Items.Add(teacherName + ": " + feedback.Description);
            }

            //foreach(Student student in Program.Dal.GetAl)
            //{






               // if(student.Id == Program.LoggedInStudent)
                //{



                //    foreach (Goal goal in _student.Goals)
                //    {
                //        string finishedGoal;
                //        if (GoalsOfStudentBox.Text.Contains("\u0336"))
                //        {
                //            markgoalasfinishedbutton.Text = "Mark selected goal as not finished";
                //            finishedGoal = GoalsOfStudentBox.Text.Replace("\u0336", "");
                            
                //            if (finishedGoal == goal.Description) //als twee descriptions hetzelfde zijn werkt dit niet goed.
                //            {
                //                Goal _goal = Program.Dal.GetFeedbackListGoal(goal);

                //                foreach (Feedback feedback in _goal.FeedbackOnGoal)
                //                {
                //                    foreach (Teacher teacher in Program.Dal.GetAllTeachers())
                //                    {
                //                        if (teacher.ID == feedback.TeacherId)
                //                            //Teacher teacherOfThisFeedback = teachers.FirstOrDefault(_teacher => _teacher.ID == feedback.TeacherId);
                //                            FeedbackonGoalsbox.Items.Add($"{teacher.Username}: {feedback.Description}");
                //                    }
                //                }
                //            }
                //        }
                //        else if (goal.Description == GoalsOfStudentBox.Text) //als twee descriptions hetzelfde zijn werkt dit niet goed.
                //        {
                //            Goal _goal = Program.Dal.GetFeedbackListGoal(goal);

                //            foreach (Feedback feedback in _goal.FeedbackOnGoal)
                //            {
                //                //Teacher teacher = Program.Dal.GetAllTeachers()[int.Parse(Program.Dal.GetAllTeachers().FirstOrDefault(_teacher => _teacher.ID == feedback.TeacherId)];

                //                foreach (Teacher teacher in Program.Dal.GetAllTeachers())
                //                {
                //                    if(teacher.ID == feedback.TeacherId)
                //                    //int teacherOfFeedback = teachers.FirstOrDefault(_teacher => _teacher.ID == feedback.TeacherId);
                //                    FeedbackonGoalsbox.Items.Add($"{teacher.Username}: {feedback.Description}");
                //                }
                //            }
                //        }
                        
                //    }
                    
               // }
            //}


            //foreach(SubTask subtask in currentGoal.SubTasks)
            //{
            //    SubGoalBox.Items.Add(subtask.Description);
            //}
            
        
     }
        private void deletegoalbutton_Click(object sender, EventArgs e)
        {
            
            List<Goal> goals = Program.Dal.GetAllGoals();
            foreach(Goal goal in goals)
            {
                if(goal.Description == GoalsOfStudentBox.Text)
                {
                    Program.Dal.DeleteGoal(goal);
                    GoalsOfStudentBox.Items.RemoveAt(GoalsOfStudentBox.SelectedIndex);
                    FeedbackonGoalsbox.Items.Clear();
                    SubGoalBox.Items.Clear();
                    FeedbackonSubtaskBox.Items.Clear();
                }
            }
        }

        private void ViewGoalPage_Load(object sender, EventArgs e)
        {

        }

        private void markgoalasfinishedbutton_Click(object sender, EventArgs e)//
        {
            if (markgoalasfinishedbutton.Text == "Mark selected goal as not finished" & GoalsOfStudentBox.SelectedIndex != -1)
            {
                currentGoal.Status = 0;
                Program.Dal.UpdateGoal(currentGoal);
                GoalsOfStudentBox.Items.RemoveAt(GoalsOfStudentBox.SelectedIndex);
                GoalsOfStudentBox.Items.Add(currentGoal.Description);
                markgoalasfinishedbutton.Text = "Mark selected goal as finished.";
                FeedbackonGoalsbox.Items.Clear();
                SubGoalBox.Items.Clear();
            }
            else if (GoalsOfStudentBox.SelectedIndex != -1)
            {
                currentGoal.Status = 1;
                Program.Dal.UpdateGoal(currentGoal);
                string newDescription = "";
                GoalsOfStudentBox.Items.RemoveAt(GoalsOfStudentBox.SelectedIndex);
                foreach (char character in currentGoal.Description)
                {
                    newDescription += character + "\u0336";
                }

                GoalsOfStudentBox.Items.Add(newDescription);
                markgoalasfinishedbutton.Text = "Mark selected goal as not finished";
                FeedbackonGoalsbox.Items.Clear();
                SubGoalBox.Items.Clear();
            }
            //goalList = currentStudent.Goals;
            foreach (Student student in Program.Dal.LoadCompleteStudents())
            {
                if (student.Id == currentStudent.Id)
                {
                    currentStudent = student;
                    goalList = student.Goals;


                }
            }

            FeedbackonSubtaskBox.Items.Clear(); 
        }



        //if (markgoalasfinishedbutton.Text == "Mark selected goal as not finished" & GoalsOfStudentBox.SelectedIndex != -1)
        //{
        //    foreach (Goal goal in goalList)
        //    {
        //        if (goal.Description == GoalsOfStudentBox.Text.Replace("\u0336", ""))
        //        {
        //            Goal selectedGoal = new Goal(goal.Id, goal.Description, goal.StudentId, goal.FeedbackOnGoal, 0);
        //            Program.Dal.UpdateGoal(selectedGoal);
        //            GoalsOfStudentBox.Items.RemoveAt(GoalsOfStudentBox.SelectedIndex);
        //            GoalsOfStudentBox.Items.Add(goal.Description);

        //        }
        //    }
        //    markgoalasfinishedbutton.Text = "Mark selected goal as finished.";
        //}
        //else if(GoalsOfStudentBox.SelectedIndex != -1)
        //{
        //    foreach (Goal goal in goalList)
        //    {
        //        if (goal.Description == GoalsOfStudentBox.Text & GoalsOfStudentBox.SelectedIndex != -1)
        //        {
        //            Goal selectedGoal = new Goal(goal.Id, goal.Description, goal.StudentId, goal.FeedbackOnGoal, 1);
        //            Program.Dal.UpdateGoal(selectedGoal);
        //            GoalsOfStudentBox.Items.RemoveAt(GoalsOfStudentBox.SelectedIndex);
        //            string newDescription = "";
        //            foreach (var character in selectedGoal.Description)
        //            {
        //                newDescription += character + "\u0336";
        //            }
        //            GoalsOfStudentBox.Items.Add(newDescription);

        //        }
        //    }

        //}
        //    foreach (Student student in Program.Dal.LoadCompleteStudents())
        //    {
        //        if (student.Id == currentStudent.Id)
        //        {
        //            currentStudent = student;
        //            goalList = student.Goals;


        //        }
        //    }

        //    SubGoalBox.Items.Clear();
        //    FeedbackonGoalsbox.Items.Clear();


        //UpdateStudentAndGoals();

    //}

        private void UpdateStudentAndGoals()
        {
            currentStudent = Program.Dal.GetStudentGoals(currentStudent);
            goalList = currentStudent.Goals;
            List<Goal> newGoalList = new List<Goal>();
            foreach (Goal goal in goalList)
            {
                Goal newGoal = Program.Dal.GetFeedbackListGoal(goal);
                newGoalList.Add(newGoal);


            }
            goalList = newGoalList;
            currentStudent.Goals = goalList;
        }

        private void editgoalbutton_Click(object sender, EventArgs e)
        {
            //foreach(Goal goal in goalList)
            //{
            //    //if (goal.Description == GoalsOfStudentBox.Text | goal.Description == GoalsOfStudentBox.Text.Replace("\u0336", ""))
            //    //{
            //    //    GoalPage goalPage = new GoalPage(goal);
            //    //    goalPage.Show();
            //    //    this.Close();
                    
            //    //}
            //}
            if(GoalsOfStudentBox.SelectedIndex != -1)
            {
                GoalPage goalPage = new GoalPage(currentGoal);
                goalPage.Show();
                this.Close();
            }
            
        }

        private void createsubtask_Click(object sender, EventArgs e)
        {

            GoalPage goalpage = new GoalPage(currentGoal, 5);
            goalpage.Show();
            this.Close();
            //foreach(Goal goal in this.goalList)
            //{
            //    if(goal.Description == GoalsOfStudentBox.Text)
            //    {
            //        GoalPage goalpage = new GoalPage(goal, 5);
            //        goalpage.Show();    
            //        this.Close();
            //    }
            //}
        }

        private void marksubgoalasfinishedbutton_Click(object sender, EventArgs e)
        {
            if (marksubgoalasfinishedbutton.Text == "Mark selected subtask as not finished" & SubGoalBox.SelectedIndex != -1)
            {
                currentSubTask.Status = 0;
                Program.Dal.UpdateSubTask(currentSubTask);
                SubGoalBox.Items.RemoveAt(SubGoalBox.SelectedIndex);
                SubGoalBox.Items.Add(currentSubTask.Description);

                
                marksubgoalasfinishedbutton.Text = "Mark selected subtask as finished.";
            }
            else if (SubGoalBox.SelectedIndex != -1)
            {
                currentSubTask.Status = 1;
                Program.Dal.UpdateSubTask(currentSubTask);
                string newDescription = "";
                SubGoalBox.Items.RemoveAt(SubGoalBox.SelectedIndex);
                foreach (char character in currentSubTask.Description)
                {
                    newDescription += character + "\u0336";
                }
                
                SubGoalBox.Items.Add(newDescription);
                marksubgoalasfinishedbutton.Text = "Mark selected subtask as not finished";
            }
            foreach (Student student in Program.Dal.LoadCompleteStudents())
            {
                if (student.Id == currentStudent.Id)
                {
                    currentStudent = student;
                    goalList = student.Goals;


                }
            }

            FeedbackonSubtaskBox.Items.Clear();
        }

        private void makenewgoal_Click(object sender, EventArgs e)
        {
            this.Hide();
            GoalPage goalPage = new GoalPage();
            goalPage.Show();
        }

        private void publishselectedgoalbuton_Click(object sender, EventArgs e)
        {
            if(GoalsOfStudentBox.SelectedIndex != -1)
            {
                currentGoal.Published = 1;
                Program.Dal.UpdateGoal(currentGoal);
                MessageBox.Show("Selected goal is published.");
            }
        }

        private void viewpublishedgoalsbuton_Click(object sender, EventArgs e)
        {
            Published_Goals publishedGoals = new Published_Goals(currentStudent, GoalsOfStudentBox);
            publishedGoals.Show();
        }
    }
}
