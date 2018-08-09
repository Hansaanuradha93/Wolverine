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
    public partial class NutritionPlanUserControl : UserControl
    {
        String connectionString;
        SqlConnection connection;

        private static NutritionPlanUserControl instance;

        public static NutritionPlanUserControl Instance
        {

            get
            {
                if (instance == null)
                {
                    instance = new NutritionPlanUserControl();
                }
                return instance;

            }
        }
        public NutritionPlanUserControl()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["Wolverine.Properties.Settings.GymnasiumConnectionString1"].ConnectionString;

            connection = new SqlConnection(connectionString);
        }

        private void addWorkoutPlanButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(nutritionPlanIdText.Text))
            {
                if (!String.IsNullOrEmpty(nutritionPlanMemberIdText.Text))
                {
                    if (!String.IsNullOrEmpty(nutritionPlanInstructorIdText.Text))
                    {
                        if (!String.IsNullOrEmpty(nutritionPlanNutritionsText.Text))
                        {
                            if (!String.IsNullOrEmpty(nutritionPlanNotesText.Text))
                            {
                                String queryNutritionPlan = "insert into NutritionPlan (pID,mID,iID,pNote) " +
                                                "values(@pID, @mID, @iID, @pNote)";
                                String queryNutrition = "insert into Nutrition(nNutrition,pID) " + 
                                                        "values(@nutrition, @nutritionPId)";

                                
                                using (connection = new SqlConnection(connectionString))
                                using (SqlCommand nutritionPlanCommand = new SqlCommand(queryNutritionPlan, connection))
                                {
                                    try
                                    {
                                        connection.Open();


                                        nutritionPlanCommand.Parameters.AddWithValue("@pID", nutritionPlanIdText.Text.ToString());
                                        nutritionPlanCommand.Parameters.AddWithValue("@mID", nutritionPlanMemberIdText.Text.ToString());
                                        nutritionPlanCommand.Parameters.AddWithValue("@iID", nutritionPlanInstructorIdText.Text.ToString());
                                        nutritionPlanCommand.Parameters.AddWithValue("@pNote", nutritionPlanNotesText.Text.ToString());

                                        nutritionPlanCommand.ExecuteNonQuery();


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
                                            oCommand.CommandText = queryNutrition;
                                            oCommand.Parameters.Add(new SqlParameter("@nutrition", SqlDbType.NChar));
                                            oCommand.Parameters.Add(new SqlParameter("@nutritionPId", SqlDbType.NChar));
                                            try
                                            {
                                                foreach (String nutrition in nutritionPlanNutritionsText.Lines)
                                                {


                                                    oCommand.Parameters[0].Value = nutrition;
                                                    oCommand.Parameters[1].Value = nutritionPlanIdText.Text.ToString();

                                                    
                                                    if (oCommand.ExecuteNonQuery() != 1)
                                                    {
                                                        //'handled as needed, 
                                                        //' but this snippet will throw an exception to force a rollback
                                                        throw new InvalidProgramException();
                                                    }
                                                }
                                                oTransaction.Commit();
                                                MessageBox.Show("Nutrition Plan saved!");
                                            }
                                            catch (Exception)
                                            {
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
