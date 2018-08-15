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

namespace Wolverine
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

            sidePanel.Height = homeButton.Height;
            sidePanel.Top = homeButton.Top;

            if (!contentPanel.Controls.Contains(HomeUserControl.Instance))
            {

                contentPanel.Controls.Add(HomeUserControl.Instance);
                HomeUserControl.Instance.Dock = DockStyle.Fill;
                HomeUserControl.Instance.BringToFront();

            }
            else
            {
                HomeUserControl.Instance.BringToFront();
            }

        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            sidePanel.Height = homeButton.Height;
            sidePanel.Top = homeButton.Top;

            if (!contentPanel.Controls.Contains(HomeUserControl.Instance))
            {

                contentPanel.Controls.Add(HomeUserControl.Instance);
                HomeUserControl.Instance.Dock = DockStyle.Fill;
                HomeUserControl.Instance.BringToFront();

            }
            else
            {
                HomeUserControl.Instance.BringToFront();
            }


        }

        private void memberButton_Click(object sender, EventArgs e)
        {
            sidePanel.Height = memberButton.Height;
            sidePanel.Top = memberButton.Top;

            if (!contentPanel.Controls.Contains(MemberUserControl.Instance))
            {

                contentPanel.Controls.Add(MemberUserControl.Instance);
                MemberUserControl.Instance.Dock = DockStyle.Fill;
                MemberUserControl.Instance.BringToFront();

            }
            else
            {
                MemberUserControl.Instance.BringToFront();
            }

        }

        private void transactionButton_Click(object sender, EventArgs e)
        {
            sidePanel.Height = transactionButton.Height;
            sidePanel.Top = transactionButton.Top;

            if (!contentPanel.Controls.Contains(TransactionUserControl.Instance))
            {

                contentPanel.Controls.Add(TransactionUserControl.Instance);
                TransactionUserControl.Instance.Dock = DockStyle.Fill;
                TransactionUserControl.Instance.BringToFront();

            }
            else
            {
                TransactionUserControl.Instance.BringToFront();
            }
        }

        private void workoutPlansButton_Click(object sender, EventArgs e)
        {
            sidePanel.Height = workoutPlansButton.Height;
            sidePanel.Top = workoutPlansButton.Top;

            if (!contentPanel.Controls.Contains(WorkoutPlanUserControl.Instance))
            {

                contentPanel.Controls.Add(WorkoutPlanUserControl.Instance);
                WorkoutPlanUserControl.Instance.Dock = DockStyle.Fill;
                WorkoutPlanUserControl.Instance.BringToFront();

            }
            else
            {
                WorkoutPlanUserControl.Instance.BringToFront();
            }
        }

        private void reservationsButton_Click(object sender, EventArgs e)
        {
            sidePanel.Height = reservationsButton.Height;
            sidePanel.Top = reservationsButton.Top;

            if (!contentPanel.Controls.Contains(ReservationUserControl.Instance))
            {

                contentPanel.Controls.Add(ReservationUserControl.Instance);
                ReservationUserControl.Instance.Dock = DockStyle.Fill;
                ReservationUserControl.Instance.BringToFront();

            }
            else
            {
                ReservationUserControl.Instance.BringToFront();
            }
        }

        private void nutritionPlansButton_Click(object sender, EventArgs e)
        {
            sidePanel.Height = nutritionPlansButton.Height;
            sidePanel.Top = nutritionPlansButton.Top;

            if (!contentPanel.Controls.Contains(NutritionPlanUserControl.Instance))
            {

                contentPanel.Controls.Add(NutritionPlanUserControl.Instance);
                NutritionPlanUserControl.Instance.Dock = DockStyle.Fill;
                NutritionPlanUserControl.Instance.BringToFront();

            }
            else
            {
                NutritionPlanUserControl.Instance.BringToFront();
            }
        }

        private void instructorButton_Click(object sender, EventArgs e)
        {
            sidePanel.Height = instructorButton.Height;
            sidePanel.Top = instructorButton.Top;

            if (!contentPanel.Controls.Contains(InstructorControl.Instance))
            {

                contentPanel.Controls.Add(InstructorControl.Instance);
                InstructorControl.Instance.Dock = DockStyle.Fill;
                InstructorControl.Instance.BringToFront();

            }
            else
            {
                InstructorControl.Instance.BringToFront();
            }

        }

        private void reportsButton_Click(object sender, EventArgs e)
        {
            sidePanel.Height = reportsButton.Height;
            sidePanel.Top = reportsButton.Top;

            if (!contentPanel.Controls.Contains(ReportsUserControl.Instance))
            {

                contentPanel.Controls.Add(ReportsUserControl.Instance);
                ReportsUserControl.Instance.Dock = DockStyle.Fill;
                ReportsUserControl.Instance.BringToFront();

            }
            else
            {
                ReportsUserControl.Instance.BringToFront();
            }
        }
    }
}
