using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wolverine
{
    public partial class ReportsUserControl : UserControl
    {

        private static ReportsUserControl instance;

        public static ReportsUserControl Instance
        {

            get
            {
                if (instance == null)
                {
                    instance = new ReportsUserControl();
                }
                return instance;

            }
        }
        public ReportsUserControl()
        {
            InitializeComponent();
        }

        private void memberReportsButton_Click(object sender, EventArgs e)
        {
            MemberReportForm mReport = new MemberReportForm();
            mReport.ShowDialog();
        }

        private void transactionReportsButton_Click(object sender, EventArgs e)
        {
            TransactionReportForm tReport = new TransactionReportForm();
            tReport.ShowDialog();
        }

        private void reservationsReportsButton_Click(object sender, EventArgs e)
        {
            ReservationReportForm rReport = new ReservationReportForm();
            rReport.ShowDialog();
        }
    }
}
