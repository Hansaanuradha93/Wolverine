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
    public partial class MemberReportForm : MetroFramework.Forms.MetroForm
    {

        String connectionString;
        //SqlConnection connection;

        public MemberReportForm()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["Wolverine.Properties.Settings.GymnasiumConnectionString1"].ConnectionString;

            //connection = new SqlConnection(connectionString);
        }

        private void MemberReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gymnasiumDataSet3.Member' table. You can move, or remove it, as needed.
            dataGridView1.Visible = false;
        }

      

        private void generateMemberReports() {

            try
            {
                using (IDbConnection db = new SqlConnection(connectionString))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();

                    string query = "select m.mID, m.mFirstName,m.mLastName, m.mAge, m.mBatch, m.mCourseName, m.mStreet, m.mCity, m.mState, m.mGender, m.mContactNumber" +
                                    " from Member m";

                    memberBindingSource.DataSource = db.Query<Member>(query, commandType: CommandType.Text);
                }

                dataGridView1.Visible = true;
                //this.memberTableAdapter.Fill(this.gymnasiumDataSet3.Member);
            }
            catch (SqlException ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void memberReportLoadButton_Click(object sender, EventArgs e)
        {
            generateMemberReports();
        }
    }
}
