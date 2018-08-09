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
    public partial class TransactionReportForm : MetroFramework.Forms.MetroForm
    {

        String connectionString;
        //SqlConnection connection;
        public TransactionReportForm()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["Wolverine.Properties.Settings.GymnasiumConnectionString1"].ConnectionString;

            //connection = new SqlConnection(connectionString);
        }

        private void reservationReportLoadButton_Click(object sender, EventArgs e)
        {
            generateTransactionReports();
        }

        private void TransactionReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gymnasiumDataSet6.Transactions' table. You can move, or remove it, as needed.
            //this.transactionsTableAdapter.Fill(this.gymnasiumDataSet6.Transactions);

            dataGridView1.Visible = false;

        }

        private void generateTransactionReports() {

            try
            {
                dataGridView1.Visible = true;
                using (IDbConnection db = new SqlConnection(connectionString))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();

                    string query = "select t.tID, t.mID, t.tDate, t.tStartTime, t.tDuration, t.tAmount" +
                                    " from Transactions t" +
                                    $" where t.tDate Between '{fromDate.Value}' and '{toDate.Value}'";


                    transactionsBindingSource.DataSource = db.Query<Models.Transaction>(query, commandType: CommandType.Text);


                }
            }
            catch (SqlException ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
