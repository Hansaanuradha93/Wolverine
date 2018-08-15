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
    public partial class TransactionUserControl : UserControl
    {
        String connectionString;
        SqlConnection connection;

        private static TransactionUserControl instance;

        public static TransactionUserControl Instance
        {

            get
            {
                if (instance == null)
                {
                    instance = new TransactionUserControl();
                }
                return instance;

            }
        }
        public TransactionUserControl()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["Wolverine.Properties.Settings.GymnasiumConnectionString1"].ConnectionString;

            connection = new SqlConnection(connectionString);
        }

        private void doTransactionButton_Click(object sender, EventArgs e)
        {
            
            if (!String.IsNullOrEmpty(transactionIdText.Text))
                if (!String.IsNullOrEmpty(transactionMemberId.Text))
                    if (!String.IsNullOrEmpty(transactionDate.Text))
                        if (!String.IsNullOrEmpty(transactionStartTime.Text))
                         if (!String.IsNullOrEmpty(transactionDurationText.Text))
                            {
                                doTransaction();
                                // Create a method to insert data to NoSql and call it here
                            }





        }

        private void doTransaction() {

            Double transactionAmount = 0;
            Double tDuration = Double.Parse(transactionDurationText.Text.ToString());
            transactionAmount = tDuration * 100;
            transactionAmountLabel.Text = "Amount is " + transactionAmount.ToString() + " /=";

            String query = "insert into Transactions(tID, mID, tDate, tStartTime, tDuration, tAmount) " +
                            "values(@tID, @mID, @tDate, @tStartTime, @tDuration, @tAmount)";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@tID", transactionIdText.Text.ToString());
                    command.Parameters.AddWithValue("@mID", transactionMemberId.Text.ToString());
                    command.Parameters.AddWithValue("@tDate", transactionDate.Value.ToShortDateString());
                    command.Parameters.AddWithValue("@tStartTime", transactionStartTime.Value);
                    command.Parameters.AddWithValue("@tDuration", tDuration.ToString());
                    command.Parameters.AddWithValue("@tAmount", transactionAmount.ToString());
                    
                    command.ExecuteNonQuery();
                    MessageBox.Show("Transaction Saved!");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);

                }

            }
        }
    }
}
