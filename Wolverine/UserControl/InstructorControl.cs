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
    public partial class InstructorControl : UserControl
    {
        String connectionString;
        SqlConnection connection;

        private static InstructorControl instance;

        public static InstructorControl Instance
        {

            get
            {
                if (instance == null)
                {
                    instance = new InstructorControl();
                }
                return instance;

            }
        }
        public InstructorControl()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["Wolverine.Properties.Settings.GymnasiumConnectionString1"].ConnectionString;

            connection = new SqlConnection(connectionString);
        }

        private void addInstructorButton_Click(object sender, EventArgs e)
        {

            String gender = "";

            if (!String.IsNullOrEmpty(instructorIdText.Text))
                if (!String.IsNullOrEmpty(instructorFirstNameText.Text))
                    if (!String.IsNullOrEmpty(instructorLastNameText.Text))
                        if (!String.IsNullOrEmpty(instructorAgeText.Text))
                            if (!String.IsNullOrEmpty(instructorStreetText.Text))
                                if (!String.IsNullOrEmpty(instructorCityText.Text))
                                    if (!String.IsNullOrEmpty(instructorStateText.Text))
                                        if (!String.IsNullOrEmpty(instructorContactNumberText.Text)) {

                                            if (instructorMaleRadioButton.Checked)
                                                gender = "Male";
                                            else
                                                gender = "Female";

                                            String query = "INSERT INTO Instructor(iID,iFirstName, iLastName, iAge, iStreet, iCity, iState, iGender, iContactNumber)" +
                              "VALUES(@iID,@fName,@lName, @Age, @streetName, @cityName, @stateName, @gender, @contactNumber)";

                                            using (connection = new SqlConnection(connectionString))
                                            using (SqlCommand command = new SqlCommand(query, connection))
                                            {
                                                try
                                                {
                                                    connection.Open();

                                                    command.Parameters.AddWithValue("@iID", instructorIdText.Text.ToString());
                                                    command.Parameters.AddWithValue("@fName", instructorFirstNameText.Text.ToString());
                                                    command.Parameters.AddWithValue("@lName", instructorLastNameText.Text.ToString());
                                                    command.Parameters.AddWithValue("@Age", int.Parse(instructorAgeText.Text.ToString()));
                                                    command.Parameters.AddWithValue("@streetName", instructorStreetText.Text.ToString());
                                                    command.Parameters.AddWithValue("@cityName", instructorCityText.Text.ToString());
                                                    command.Parameters.AddWithValue("@stateName", instructorStateText.Text.ToString());
                                                    command.Parameters.AddWithValue("@gender", gender);
                                                    command.Parameters.AddWithValue("@contactNumber", instructorContactNumberText.Text.ToString());


                                                    command.ExecuteNonQuery();
                                                    MessageBox.Show("Instructor Details Saved!");
                                                }
                                                catch (Exception ex)
                                                {
                                                    MessageBox.Show(ex.Message);
                                                }
                                            }
                                        }
            
        }

      
    }
}
