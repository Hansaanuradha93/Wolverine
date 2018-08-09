using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using Dapper;

namespace Wolverine
{
    public partial class ReservationReportForm : MetroFramework.Forms.MetroForm
    {

        String connectionString;
        //SqlConnection connection;
        public ReservationReportForm()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["Wolverine.Properties.Settings.GymnasiumConnectionString1"].ConnectionString;

            //connection = new SqlConnection(connectionString);
        }

        private void reservationReportLoadButton_Click(object sender, EventArgs e)
        {

            generateReservationReports();

        }

        private void ReservationReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gymnasiumDataSet5.Reservation' table. You can move, or remove it, as needed.
            //this.reservationTableAdapter.Fill(this.gymnasiumDataSet5.Reservation);

        }

        private void generateReservationReports() {

            try
            {
                dataGridView1.Visible = true;
                using (IDbConnection db = new SqlConnection(connectionString))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();

                    string query = "select r.rID,r.rDate,r.rStartTime,r.rDuration,r.rAmount,r.rApproval" +
                                    " from Reservation r" +
                                    $" where r.rDate Between '{fromDate.Value}' and '{toDate.Value}'";


                    reservationBindingSource.DataSource = db.Query<Reservation>(query, commandType: CommandType.Text);

                }
            }
            catch (SqlException ex){
                MessageBox.Show(ex.Message);
            }
        }

       

        

        
    }
}
