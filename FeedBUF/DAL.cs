using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedBUF
{
    public class DAL
    {
        private static SqlConnection connection = new SqlConnection("data source=DESKTOP-ERF02CF;initial catalog=FeedBUF;trusted_connection=true");
        private static SqlConnection connectionInside = new SqlConnection("data source=DESKTOP-ERF02CF;initial catalog=FeedBUF;trusted_connection=true");

        public static void RemoveFeedback(int feedbackID)
        {
            try
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    connection.Open();
                    command.CommandText = "DELETE FROM Feedback WHERE ID = @ID";
                    command.Parameters.AddWithValue("@ID", feedbackID);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (SqlException ex) { throw ex; }
        }


        public List<Student> LoadCompleteStudents()
        {
            List<Student> students = new List<Student>();
            
            foreach (Student student in GetAllStudents())
            {
                List<Goal> goals = new List<Goal>();
                
                Student _student = GetStudentGoals(student);

                foreach (Goal goal in _student.Goals)
                {
                    List<SubTask> subtasks = new List<SubTask>();
                    Goal _goal = GetFeedbackListGoal(goal);
                    _goal = GetSubtaskList(_goal);                                        
                    foreach(SubTask subTask in _goal.SubTasks)
                    {
                       SubTask _subTask = GetFeedbackListSubTask(subTask);
                        subtasks.Add(_subTask);
                    }
                    _goal.SubTasks = subtasks;
                    goals.Add(_goal);
                }
                Student completeStudent = _student;
                completeStudent.Goals = goals;
                students.Add(completeStudent);
            }
            connection.Close();
            return students;
        }

        public void AddGoal(string description, int StudentId)
        {
            try
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    connection.Open();
                    command.CommandText = "INSERT INTO Goal (Description, StudentId, Status, CreatorId, Published) VALUES (@Description, @StudentId, @Status, @CreatorId, @Published)";
                    command.Parameters.AddWithValue("@Description", description);
                    command.Parameters.AddWithValue("@StudentId", StudentId);
                    command.Parameters.AddWithValue("@Status", 0);
                    command.Parameters.AddWithValue("@CreatorId", StudentId);
                    command.Parameters.AddWithValue("@PUblished", 0);
                    command.ExecuteNonQuery();
                    SqlCommand CommandRead = new SqlCommand("SELECT Id FROM Goal ORDER BY Id DESC", connection);
                    int goalId = 0;
                    using (SqlDataReader reader = CommandRead.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader.HasRows == false)
                            {

                            }
                            else
                            {
                                goalId = reader.GetInt32(reader.GetOrdinal("Id"));
                                reader.Close();// hoeft niet vanwege using

                                /*SqlConnection connectionInside = connection;
                                SqlCommand commandInside = new SqlCommand();
                                commandInside.Connection = connectionInside;
                                connectionInside.Open();
                                int goalId = reader.GetInt32(reader.GetOrdinal("Id"));
                                commandInside.CommandText = "INSERT INTO StudentGoal (GoalId, StudentId) VALUES (@GoalId, @StudentId)";
                                commandInside.Parameters.AddWithValue("@GoalId", goalId);
                                commandInside.Parameters.AddWithValue("@StudentId", StudentId);
                                commandInside.ExecuteNonQuery();
                                connectionInside.Close();
                                */
                                break;
                            }

                        }

                    }
                    command.Parameters.Clear();
                    command.CommandText = "INSERT INTO StudentGoal (GoalId, StudentId) VALUES (@GoalId, @StudentId)";
                    command.Parameters.AddWithValue("@GoalId", goalId);
                    command.Parameters.AddWithValue("@StudentId", StudentId);
                    command.ExecuteNonQuery();

                    connection.Close();
                }
            }
            catch (SqlException ex) { throw ex; }
        }

        public void SaveGoal(Goal goal)
        {
            try
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    connection.Open();
                    command.CommandText = "INSERT INTO Goal (Description, StudentId, Status, CreatorId, Published) VALUES (@Description, @StudentId, @Status, @CreatorId, @Published)";
                    command.Parameters.AddWithValue("@Description", goal.Description);
                    command.Parameters.AddWithValue("@StudentId", goal.Student.Id);
                    command.Parameters.AddWithValue("@Status", goal.Status);
                    command.Parameters.AddWithValue("@CreatorId", goal.Creator.Id);
                    command.Parameters.AddWithValue("@PUblished", goal.Published);
                    command.ExecuteNonQuery();
                    SqlCommand CommandRead = new SqlCommand("SELECT Id FROM Goal ORDER BY Id DESC", connection);
                    int goalId = 0;
                    using (SqlDataReader reader = CommandRead.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader.HasRows == false)
                            {

                            }
                            else
                            {
                                goalId = reader.GetInt32(reader.GetOrdinal("Id"));
                                reader.Close();
                                break;
                            }

                        }

                    }
                    command.Parameters.Clear();
                    command.CommandText = "INSERT INTO StudentGoal (GoalId, StudentId) VALUES (@GoalId, @StudentId)";
                    command.Parameters.AddWithValue("@GoalId", goalId);
                    command.Parameters.AddWithValue("@StudentId", goal.Student.Id);
                    command.ExecuteNonQuery();

                    connection.Close();
                }
            }
            catch (SqlException ex) { throw ex; }
        }

        public void AddStudent(Student student)
        {
            try
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    connection.Open();
                    command.CommandText = "INSERT INTO Student (Username, Password) VALUES (@Username, @Password)";
                    command.Parameters.AddWithValue("@Username", student.Username);
                    command.Parameters.AddWithValue("@Password", student.Password);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (SqlException ex) { throw ex; }
        }

        public Student GetStudentGoals(Student student)
        {
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = connection;
                connection.Open();
                command.CommandText = "SELECT * FROM StudentGoal";
                SqlDataReader reader = command.ExecuteReader();
                List<Goal> goals = new List<Goal>();
                while (reader.Read())
                {
                    if ((int)reader[2] == student.Id)
                    {

                        using (SqlCommand commandInside = new SqlCommand())
                        {
                            commandInside.Connection = connectionInside;
                            connectionInside.Open();
                            commandInside.CommandText = "SELECT * FROM Goal";
                            SqlDataReader readerInside = commandInside.ExecuteReader();
                            while (readerInside.Read())
                            {
                                if ((int)readerInside[0] == (int)reader[1])
                                {
                                    Goal goal = new Goal((int)readerInside["Id"], readerInside["Description"].ToString(), (int)readerInside["StudentId"], (int)readerInside["Status"]);
                                    goals.Add(goal);
                                }
                            }
                            connectionInside.Close();
                        }
                    }
                }
                Student Outstudent = new Student(student.Id, student.Username, student.Password, goals);

                connection.Close();
                reader.Close();

                return Outstudent;

            }
            
        }
        public SubTask GetFeedbackListSubTask(SubTask subTask)
        {
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = connection;
                connection.Open();
                command.CommandText = "SELECT * FROM SubTaskFeedback";
                SqlDataReader reader = command.ExecuteReader();
                List<Feedback> feedbacks = new List<Feedback>();
                while (reader.Read())
                {
                    if ((int)reader["SubTaskId"] == subTask.Id)
                    {

                        using (SqlCommand commandInside = new SqlCommand())
                        {
                            commandInside.Connection = connectionInside;
                            connectionInside.Open();
                            commandInside.CommandText = "SELECT * FROM Feedback";
                            SqlDataReader readerInside = commandInside.ExecuteReader();
                            while (readerInside.Read())
                            {
                                
                                if ((int)readerInside["Id"] == (int)reader["FeedbackId"])
                                {
                                    Feedback _feedBack = new Feedback(
                                        (int)readerInside["Id"], 
                                        readerInside["Description"].ToString(), 
                                        (int)readerInside["TeacherId"], 
                                        (int)readerInside["GoalId"]
                                        );
                                    feedbacks.Add(_feedBack);
                                }
                            }
                            connectionInside.Close();
                        }
                    }
                }
                SubTask OutSubTask = subTask;
                OutSubTask.FeedbackOnGoal = feedbacks;
                connection.Close();
                reader.Close();

                return OutSubTask;

            }


        }

        public void SaveFeedBack(Feedback feedback, int isSubTask)
        {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    connection.Open();
                    command.CommandText = "INSERT INTO Feedback (Description, TeacherId, GoalId, IsSubGoal) VALUES (@Description, @TeacherId, @GoalId, @IsSubGoal)";
                    command.Parameters.AddWithValue("@Description", feedback.Description);
                    command.Parameters.AddWithValue("@TeacherId", feedback.TeacherId);
                    command.Parameters.AddWithValue("GoalId", feedback.GoalId);
                    command.Parameters.AddWithValue("@IsSubGoal", isSubTask);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                    command.Connection = connection;
                    command.CommandText = "SELECT Id FROM Feedback ORDER BY Id DESC";
                    int feedbackId = 0;
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        if (reader.HasRows == false)
                        {
                            break;
                        }
                        feedbackId = reader.GetInt32(reader.GetOrdinal("Id"));                        
                        break;

                    }
                    reader.Close();
                    if (isSubTask == 0)
                    {

                    command.Parameters.Clear();
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO GoalFeedbackIntermediate (GoalId, FeedbackId) VALUES (@GoalId, @FeedbackId)"; ///saves list of feedback of the goal
                    command.Parameters.AddWithValue("@GoalId", feedback.GoalId);
                    command.Parameters.AddWithValue("@FeedbackId", feedbackId);
                    command.ExecuteNonQuery();
                    connection.Close();
                    }



                    else
                    {
                    command.Parameters.Clear();
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO SubTaskFeedback (SubTaskId, FeedbackId) VALUES (@SubTaskId, @FeedbackId)"; ///saves list of feedback of the subtask
                    command.Parameters.AddWithValue("@SubTaskId", feedback.SubGoalId);
                    command.Parameters.AddWithValue("@FeedbackId", feedbackId);
                    command.ExecuteNonQuery();
                    connection.Close();


                    }
                }
            connection.Close();
        }


        public void UpdateGoal(Goal goal)
        {
            using(SqlCommand command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "UPDATE Goal SET Description = @Description, StudentId = @StudentId, Status = @Status, Published = @Published WHERE Id = @Id";
                command.Parameters.AddWithValue("Id", goal.Id);
                command.Parameters.AddWithValue("@Description", goal.Description);
                command.Parameters.AddWithValue("@StudentId", goal.StudentId);
                command.Parameters.AddWithValue("@Status", goal.Status);
                command.Parameters.AddWithValue("@Published", goal.Published);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public Goal GetFeedbackListGoal(Goal goal)
        {
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = connection;
                connection.Open();
                command.CommandText = "SELECT * FROM GoalFeedbackIntermediate";
                SqlDataReader reader = command.ExecuteReader();
                List<Feedback> feedbacks = new List<Feedback>();
                while (reader.Read())
                {
                    if ((int)reader["GoalId"] == goal.Id)
                    {

                        using (SqlCommand commandInside = new SqlCommand())
                        {
                            commandInside.Connection = connectionInside;
                            connectionInside.Open();
                            commandInside.CommandText = "SELECT * FROM Feedback";
                            SqlDataReader readerInside = commandInside.ExecuteReader();
                            while (readerInside.Read())
                            {

                                if ((int)readerInside["Id"] == (int)reader["FeedbackId"])
                                {
                                    Feedback _feedBack = new Feedback(
                                        (int)readerInside["Id"],
                                        readerInside["Description"].ToString(),
                                        (int)readerInside["TeacherId"],
                                        (int)readerInside["GoalId"]
                                        );
                                    feedbacks.Add(_feedBack);
                                }
                            }
                            connectionInside.Close();
                        }
                    }
                }
                Goal outGoal = goal;
                outGoal.FeedbackOnGoal = feedbacks;
                connection.Close();
                reader.Close();

                return outGoal;

            }


        }

        //public Goal GetFeedbackListGoal(Goal goal)
        //{
        //    List<Teacher> list = Program.Dal.GetAllTeachers();
        //    SqlCommand command = new SqlCommand();
        //    command.Connection = connection;
        //    connection.Open();
        //    command.CommandText = "SELECT * FROM GoalFeedbackIntermediate";
        //    SqlDataReader reader = command.ExecuteReader();
        //    List<Feedback> feedbacks = new List<Feedback>();
        //    while (reader.Read())
        //    {
        //        if ((int)reader["GoalId"] == goal.Id)
        //        {

        //            using (SqlCommand commandInside = new SqlCommand())
        //            {
        //                commandInside.Connection = connectionInside;
        //                connectionInside.Open();
        //                commandInside.CommandText = "SELECT * FROM Feedback";
        //                SqlDataReader readerInside = commandInside.ExecuteReader();
        //                while (readerInside.Read())
        //                {
        //                    if(reader.HasRows == false)
        //                    {
        //                        break;
        //                    }
        //                    if ((int)reader["FeedbackId"] == (int)readerInside["Id"])
        //                    {
        //                        Feedback feedback = new Feedback((int)readerInside["Id"], 
        //                            readerInside["Description"].ToString(), 
        //                            (int)readerInside["TeacherId"], 
        //                            (int)readerInside["GoalId"]);
        //                            feedbacks.Add(feedback);
        //                            //break; //anders laad hij steeds maar een feedback
        //                    }
        //                }




        //            }
        //            connectionInside.Close();                    
        //            reader.Close();
        //            Goal _goal = goal;
        //            _goal.FeedbackOnGoal = feedbacks;
        //            connection.Close();
        //            return _goal;


        //        }
        //        connection.Close();
        //        return goal;
        //    }
        //    connection.Close();
        //    return goal;
        //}
        public Goal GetSubtaskList(Goal goal)
        {
            List<SubTask> subtasks = new List<SubTask>();
            using(SqlCommand command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM GoalSubGoalIntermediate";
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if ((int)reader["GoalId"] == goal.Id)
                    {
                        using(SqlCommand commandInside = new SqlCommand())
                        {
                            commandInside.Connection = connectionInside;
                            connectionInside.Open();
                            commandInside.CommandText = "SELECT * FROM SubTask";
                            SqlDataReader readerInside = commandInside.ExecuteReader();
                            while (readerInside.Read())
                            {
                                if ((int)reader["SubGoalId"] == (int)readerInside["Id"])
                                {
                                    SubTask subTask = new SubTask((int)readerInside["Id"], readerInside["Description"].ToString(), goal, (int)readerInside["Status"]);
                                    subtasks.Add(subTask);
                                }
                            }
                            readerInside.Close();
                            connectionInside.Close();
                        }
                        
                    }
                }
                reader.Close();
                connection.Close();
            }
            Goal outGoal = goal;
            outGoal.SubTasks = subtasks;
            return outGoal;

        }
        public void UpdateSubTask(SubTask subtask)
        {
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = connection;
                connection.Open();
                command.CommandText = "UPDATE SubTask SET Description = @Description, GoalId = @GoalId, Status = @Status WHERE Id = @Id";
                command.Parameters.AddWithValue("@Id", subtask.Id);
                command.Parameters.AddWithValue("@Description", subtask.Description);
                command.Parameters.AddWithValue("GoalId", subtask.Goal.Id);
                command.Parameters.AddWithValue("@Status", subtask.Status);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void SaveSubTask(SubTask subtask)
        {
            using (SqlCommand command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO SubTask (Description, GoalId, Status) VALUES (@Description, @GoalId, @Status)";
                command.Parameters.AddWithValue("@Description", subtask.Description);
                command.Parameters.AddWithValue("@GoalId", subtask.Goal.Id);
                command.Parameters.AddWithValue("@Status", subtask.Status);
                command.ExecuteNonQuery();
                command.Parameters.Clear();
                command.CommandText = "SELECT * FROM SubTask ORDER BY Id DESC";
                SqlDataReader reader = command.ExecuteReader();
                int subgoalId = 0;
                while (reader.Read())
                {
                    subgoalId = (int)reader["Id"];
                    break;
                }
                reader.Close();
                command.Parameters.Clear();
                command.CommandText = "INSERT INTO GoalSubGoalIntermediate (GoalId, SubgoalId) VALUES (@GoalId, @SubgoalId)";
                command.Parameters.AddWithValue("@GoalId", subtask.Goal.Id);
                command.Parameters.AddWithValue("@SubgoalId", subgoalId);                
                command.ExecuteNonQuery();
                connection.Close();
            }
        }


        public List<Goal> GetAllGoals()
        {
            List<Goal> goals = new List<Goal>();
            using(SqlCommand command = new SqlCommand())
            {
                command.Connection = connection;
                connection.Open();
                command.CommandText = "SELECT * FROM Goal";
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Goal goal = new Goal((int)reader["Id"], reader["Description"].ToString(), (int)reader["StudentId"], (int)reader["Status"], (int)reader["CreatorId"], (int)reader["Published"]);
                    goals.Add(goal);
                }
                reader.Close();
                //connection.Close();
            }
            connection.Close();
            return goals;
        }

        public void DeleteGoal(Goal goal)
        {
            using(SqlCommand command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM StudentGoal WHERE GoalId = @GoalId";
                command.Parameters.AddWithValue("@GoalId", goal.Id);
                command.ExecuteNonQuery();
                command.Parameters.Clear();
                command.Connection = connection;
                command.CommandText = "DELETE FROM GoalFeedbackIntermediate WHERE GoalId = @GoalId";
                command.Parameters.AddWithValue("@GoalId", goal.Id);
                command.ExecuteNonQuery();
                command.Parameters.Clear();
                command.CommandText = "DELETE FROM GoalSubGoalIntermediate WHERE GoalId = @GoalId";
                command.Parameters.AddWithValue("@GoalId", goal.Id);
                command.ExecuteNonQuery();
                command.Parameters.Clear();
                command.CommandText = "DELETE FROM Goal WHERE Id = @Id";
                command.Parameters.AddWithValue("@Id", goal.Id);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public static void UpdateStudent(Student student)
        {
            try
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    connection.Open();
                    command.CommandText = "UPDATE Student SET Name = @Name, Username = @Username, Password = @Password WHERE Id = @Id";
                    command.Parameters.AddWithValue("@Id", student.Id);
                    command.Parameters.AddWithValue("@Username", student.Username);
                    command.Parameters.AddWithValue("@Password", student.Password);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (SqlException ex) { throw ex; }
        }

        public static void RemoveStudent(int studentID)
        {
            try
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    connection.Open();
                    command.CommandText = "DELETE FROM Student WHERE Id = @Id";
                    command.Parameters.AddWithValue("@Id", studentID);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (SqlException ex) { throw ex; }
        }

        public List<Student> GetAllStudents()
        {
            try
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    connection.Open();
                    command.CommandText = "SELECT * FROM Student";
                    SqlDataReader reader = command.ExecuteReader();
                    List<Student> students = new List<Student>();
                    while (reader.Read())
                    {
                        Student student = new Student(
                            (int)reader[0],
                            reader["Username"].ToString(),
                            reader["Password"].ToString()
                        );
                        students.Add(student);
                    }
                    reader.Close();
                    connection.Close();
                    return students;
                }
            }
            catch (SqlException ex) { throw ex; }
        }

        public void AddTeacher(Teacher teacher)
        {
            try
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    connection.Open();
                    command.CommandText = "INSERT INTO Teacher (Username, Password) VALUES (@Username, @Password)";
                    command.Parameters.AddWithValue("@Username", teacher.Username);
                    command.Parameters.AddWithValue("@Password", teacher.Password);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (SqlException ex) { throw ex; }
        }
   
        public Student GetStudentById(int studentId)
        {
            Student student = null;
            using (SqlCommand command = new SqlCommand())
            {
                connection.Open();
                command.Connection= connection;
                command.CommandText = "SELECT * FROM Student WHERE Id = @Id";
                command.Parameters.AddWithValue("@Id", studentId);
                SqlDataReader reader =command.ExecuteReader();               
                while (reader.Read())
                {
                        student = new Student(
                        (int)reader["Id"],
                        reader["Username"].ToString(),
                        reader["Password"].ToString()
                        );
                    
                    
                }
                reader.Close();
            }
            connection.Close();
            student = Program.Dal.GetStudentGoals(student);
            return student;
        }
        public static void RemoveTeacher(int teacherID)
        {
            try
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    connection.Open();
                    command.CommandText = "DELETE FROM Teacher WHERE ID = @ID";
                    command.Parameters.AddWithValue("@ID", teacherID);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (SqlException ex) { throw ex; }
        }

        public List<Teacher> GetAllTeachers()
        {
            try
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    connection.Open();
                    command.CommandText = "SELECT * FROM Teacher";
                    SqlDataReader reader = command.ExecuteReader();
                    List<Teacher> teachers = new List<Teacher>();
                    while (reader.Read())
                    {
                        Teacher teacher = new Teacher(
                            (int)reader["ID"],
                            reader["Username"].ToString(),
                            reader["Password"].ToString()
                        );
                        teachers.Add(teacher);
                    }
                    reader.Close();
                    connection.Close();
                    return teachers;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

    }
}
