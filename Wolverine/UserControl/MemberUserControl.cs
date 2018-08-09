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
    public partial class MemberUserControl : UserControl
    {
        String connectionString;
        SqlConnection connection;

        private static MemberUserControl instance;

        public static MemberUserControl Instance
        {

            get
            {
                if (instance == null)
                {
                    instance = new MemberUserControl();
                }
                return instance;

            }
        }
        public MemberUserControl()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["Wolverine.Properties.Settings.GymnasiumConnectionString1"].ConnectionString;

            connection = new SqlConnection(connectionString);

        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            String gender = "";

            if (!String.IsNullOrEmpty(memberIdText.Text))
                if (!String.IsNullOrEmpty(memberFirstNameText.Text))
                    if (!String.IsNullOrEmpty(memberLastNameText.Text))
                        if (!String.IsNullOrEmpty(memberAgeText.Text))
                            if (!String.IsNullOrEmpty(memberBatchText.Text))
                                if (!String.IsNullOrEmpty(memberCourseText.Text))
                                    if (!String.IsNullOrEmpty(memberStreetText.Text))
                                        if (!String.IsNullOrEmpty(memberCityText.Text))
                                            if (!String.IsNullOrEmpty(memberStateText.Text))
                                                if (!String.IsNullOrEmpty(memberContactNumberText.Text)) {
                                                    if(maleRadioButton.Checked)
                                                        gender = "Male";
                                                    else
                                                        gender = "Female";


                                                    String query = "INSERT INTO Member(mID,mFirstName, mLastName, mAge, mBatch, mCourseName, mStreet, mCity, mState, mGender, mContactNumber)" +
                                                                    "VALUES(@mID,@fName,@lName, @Age, @batch, @courseName, @streetName, @cityName, @stateName, @gender, @contactNumber)";

                                                    using (connection = new SqlConnection(connectionString))
                                                    using (SqlCommand command = new SqlCommand(query, connection))
                                                    {
                                                        try
                                                        {
                                                            connection.Open();

                                                            command.Parameters.AddWithValue("@mID", memberIdText.Text.ToString());
                                                            command.Parameters.AddWithValue("@fName", memberFirstNameText.Text.ToString());
                                                            command.Parameters.AddWithValue("@lName", memberLastNameText.Text.ToString());
                                                            command.Parameters.AddWithValue("@Age", int.Parse(memberAgeText.Text.ToString()));
                                                            command.Parameters.AddWithValue("@batch", memberBatchText.Text.ToString());
                                                            command.Parameters.AddWithValue("@courseName", memberCourseText.Text.ToString());
                                                            command.Parameters.AddWithValue("@streetName", memberStreetText.Text.ToString());
                                                            command.Parameters.AddWithValue("@cityName", memberCityText.Text.ToString());
                                                            command.Parameters.AddWithValue("@stateName", memberStateText.Text.ToString());
                                                            command.Parameters.AddWithValue("@gender", gender);
                                                            command.Parameters.AddWithValue("@contactNumber", memberContactNumberText.Text.ToString());


                                                            int rows = command.ExecuteNonQuery();
                                                            MessageBox.Show("Member Details Saved!");
                                                        }
                                                        catch (SqlException ex)
                                                        {
                                                            MessageBox.Show(ex.Message);

                                                        }

                                                    }
                                                }
            
        }

        

        private void searchMemberButton_Click(object sender, EventArgs e)
        {

        }

        private void memberContactNumberText_Click(object sender, EventArgs e)
        {

        }

        private void memberStateText_Click(object sender, EventArgs e)
        {

        }

        private void memberCityText_Click(object sender, EventArgs e)
        {

        }

        private void memberStreetText_Click(object sender, EventArgs e)
        {

        }

        private void memberCourseText_Click(object sender, EventArgs e)
        {

        }

        private void memberBatchText_Click(object sender, EventArgs e)
        {

        }

        private void memberAgeText_Click(object sender, EventArgs e)
        {

        }

        private void memberLastNameText_Click(object sender, EventArgs e)
        {

        }

        private void memberFirstNameText_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void maleRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void femaleRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
