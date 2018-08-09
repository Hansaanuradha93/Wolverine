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
    public partial class ReservationUserControl : UserControl
    {

        String connectionString;
        SqlConnection connection;

        private static ReservationUserControl instance;

        public static ReservationUserControl Instance
        {

            get
            {
                if (instance == null)
                {
                    instance = new ReservationUserControl();
                }
                return instance;

            }
        }
        public ReservationUserControl()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["Wolverine.Properties.Settings.GymnasiumConnectionString1"].ConnectionString;

            connection = new SqlConnection(connectionString);
        }

        

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(reservationIdText.Text))
                if (!String.IsNullOrEmpty(reservationDataPicker.Text))
                    if (!String.IsNullOrEmpty(reservationStartTimePicker.Text))
                        if (!String.IsNullOrEmpty(reservationDurationText.Text))
                            if (!String.IsNullOrEmpty(reservationMemberIdText.Text)) {

                                String query = "Insert into Reservation(rID,rDate,rStartTime,rDuration,rAmount,rApproval,mID,iID) " +
     "values(@rID, @rDate, @rTime, @rDuration, @rAmount, 0, @rMemberID, null)";

                                double rAmount = 100;
                                rAmount = Double.Parse(reservationDurationText.Text) * 100;
                                reservationAmountText.Text = "Amount is " + rAmount.ToString() + " /=";

                                using (connection = new SqlConnection(connectionString))
                                using (SqlCommand command = new SqlCommand(query, connection))
                                {
                                    try
                                    {
                                        connection.Open();


                                        command.Parameters.AddWithValue("@rID", reservationIdText.Text.ToString());
                                        command.Parameters.AddWithValue("@rDuration", int.Parse(reservationDurationText.Text.ToString()));
                                        command.Parameters.AddWithValue("@rMemberID", reservationMemberIdText.Text.ToString());
                                        command.Parameters.AddWithValue("@rAmount", rAmount);
                                        command.Parameters.AddWithValue("@rDate", reservationDataPicker.Value.ToShortDateString());
                                        command.Parameters.AddWithValue("@rTime", reservationStartTimePicker.Value.ToLocalTime());


                                        int rows = command.ExecuteNonQuery();
                                        MessageBox.Show("Reservation Saved!");
                                    }
                                    catch (SqlException ex)
                                    {
                                        MessageBox.Show(ex.Message);

                                    }

                                }
                            }
            

        }

        private void approveReservationButton_Click(object sender, EventArgs e)
        {
            int rApprovalValue = 0;

            if (!String.IsNullOrEmpty(approveReservationText.Text))
                if (!String.IsNullOrEmpty(approveInstructorId.Text)) {

                    if (approvedRadioButton.Checked)
                        rApprovalValue = 1;


                    String query = "Update Reservation " +
                                    "set iID=@iID,rApproval=@rApproval " +
                                        "where rID=@rID";

                    using (connection = new SqlConnection(connectionString))
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        try
                        {
                            connection.Open();


                            command.Parameters.AddWithValue("@iID", approveInstructorId.Text.ToString());
                            command.Parameters.AddWithValue("@rApproval", rApprovalValue);
                            command.Parameters.AddWithValue("@rID", approveReservationText.Text.ToString());


                            int rows = command.ExecuteNonQuery();
                            MessageBox.Show("Approval Status Updated!");
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show(ex.ToString());

                        }

                    }

                }

              
        }

        
    }
}
