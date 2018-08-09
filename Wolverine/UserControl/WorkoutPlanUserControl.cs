using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Wolverine
{
    public partial class WorkoutPlanUserControl : UserControl
    {
        String connectionString;
        SqlConnection connection;

        private static WorkoutPlanUserControl instance;

        public static WorkoutPlanUserControl Instance
        {

            get
            {
                if (instance == null)
                {
                    instance = new WorkoutPlanUserControl();
                }
                return instance;

            }
        }
        public WorkoutPlanUserControl()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["Wolverine.Properties.Settings.GymnasiumConnectionString1"].ConnectionString;

            connection = new SqlConnection(connectionString);

        }

        private void addWorkoutPlanButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(workoutPlanIdText.Text))
            {
                if (!String.IsNullOrEmpty(workoutPlanMemberIdText.Text))
                {
                    if (!String.IsNullOrEmpty(workoutPlanInstructorIdText.Text))
                    {
                        if (!String.IsNullOrEmpty(workoutPlanExercisesText.Text))
                        {
                            if (!String.IsNullOrEmpty(workoutPlansNotesText.Text))
                            {
                                String workoutPlanQuery = "insert into WorkoutPlan(wID, mID, iID, wNote) " +
                                                "values(@wID, @mID, @iID, @wNote)";

                                String workoutExerciseQuery = "insert into WorkoutExercise(wID,eExercise) " +
                                                                "values(@wID, @eExercise); ";

                                using (connection = new SqlConnection(connectionString))
                                using (SqlCommand command = new SqlCommand(workoutPlanQuery, connection))
                                {
                                    try
                                    {
                                        connection.Open();


                                        command.Parameters.AddWithValue("@wID", workoutPlanIdText.Text.ToString());
                                        command.Parameters.AddWithValue("@mID", workoutPlanMemberIdText.Text.ToString());
                                        command.Parameters.AddWithValue("@iID", workoutPlanInstructorIdText.Text.ToString());
                                        command.Parameters.AddWithValue("@wNote", workoutPlansNotesText.Text.ToString());



                                        int rows = command.ExecuteNonQuery();
                                    }
                                    catch (SqlException ex)
                                    {
                                        MessageBox.Show(ex.Message);

                                    }

                                }


                                using (connection = new SqlConnection(connectionString))
                                {
                                    connection.Open();
                                    using (SqlTransaction oTransaction = connection.BeginTransaction())
                                    {
                                        using (SqlCommand oCommand = connection.CreateCommand())
                                        {
                                            oCommand.Transaction = oTransaction;
                                            oCommand.CommandType = CommandType.Text;
                                            oCommand.CommandText = workoutExerciseQuery;
                                            oCommand.Parameters.Add(new SqlParameter("@wID", SqlDbType.NChar));
                                            oCommand.Parameters.Add(new SqlParameter("@eExercise", SqlDbType.NChar));
                                            try
                                            {
                                                foreach (String exercise in workoutPlanExercisesText.Lines)
                                                {

                                                    oCommand.Parameters[0].Value = workoutPlanIdText.Text.ToString();
                                                    oCommand.Parameters[1].Value = exercise;
                                                    


                                                    if (oCommand.ExecuteNonQuery() != 1)
                                                    {
                                                        //'handled as needed, 
                                                        //' but this snippet will throw an exception to force a rollback
                                                        throw new InvalidProgramException();
                                                    }
                                                }
                                                oTransaction.Commit();
                                                MessageBox.Show("Workout Plan saved!");
                                            }
                                            catch (Exception ex)
                                            {
                                                MessageBox.Show(ex.Message);
                                                oTransaction.Rollback();
                                                throw;
                                                
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
