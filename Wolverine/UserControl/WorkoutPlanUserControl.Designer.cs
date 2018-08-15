namespace Wolverine
{
    partial class WorkoutPlanUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.workoutPlanExercisesText = new System.Windows.Forms.RichTextBox();
            this.addWorkoutPlanButton = new System.Windows.Forms.Button();
            this.workoutPlansNotesText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.workoutPlanInstructorIdText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.workoutPlanMemberIdText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.workoutPlanIdText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.materialLabel3);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Controls.Add(this.workoutPlanExercisesText);
            this.panel1.Controls.Add(this.addWorkoutPlanButton);
            this.panel1.Controls.Add(this.workoutPlansNotesText);
            this.panel1.Controls.Add(this.workoutPlanInstructorIdText);
            this.panel1.Controls.Add(this.workoutPlanMemberIdText);
            this.panel1.Controls.Add(this.workoutPlanIdText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(976, 700);
            this.panel1.TabIndex = 0;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(322, 29);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(129, 19);
            this.materialLabel3.TabIndex = 99;
            this.materialLabel3.Text = "Add Workout Plan";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(235, 250);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(82, 19);
            this.materialLabel1.TabIndex = 98;
            this.materialLabel1.Text = "Exercises: ";
            // 
            // workoutPlanExercisesText
            // 
            this.workoutPlanExercisesText.BackColor = System.Drawing.SystemColors.Control;
            this.workoutPlanExercisesText.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workoutPlanExercisesText.Location = new System.Drawing.Point(239, 286);
            this.workoutPlanExercisesText.Name = "workoutPlanExercisesText";
            this.workoutPlanExercisesText.Size = new System.Drawing.Size(348, 135);
            this.workoutPlanExercisesText.TabIndex = 97;
            this.workoutPlanExercisesText.Text = "";
            // 
            // addWorkoutPlanButton
            // 
            this.addWorkoutPlanButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.addWorkoutPlanButton.FlatAppearance.BorderSize = 0;
            this.addWorkoutPlanButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addWorkoutPlanButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addWorkoutPlanButton.ForeColor = System.Drawing.Color.White;
            this.addWorkoutPlanButton.Location = new System.Drawing.Point(151, 496);
            this.addWorkoutPlanButton.Name = "addWorkoutPlanButton";
            this.addWorkoutPlanButton.Size = new System.Drawing.Size(533, 35);
            this.addWorkoutPlanButton.TabIndex = 88;
            this.addWorkoutPlanButton.Text = "Add Workout Plan";
            this.addWorkoutPlanButton.UseVisualStyleBackColor = false;
            this.addWorkoutPlanButton.Click += new System.EventHandler(this.addWorkoutPlanButton_Click);
            // 
            // workoutPlansNotesText
            // 
            this.workoutPlansNotesText.Depth = 0;
            this.workoutPlansNotesText.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workoutPlansNotesText.ForeColor = System.Drawing.Color.Transparent;
            this.workoutPlansNotesText.Hint = "Notes";
            this.workoutPlansNotesText.Location = new System.Drawing.Point(239, 445);
            this.workoutPlansNotesText.MouseState = MaterialSkin.MouseState.HOVER;
            this.workoutPlansNotesText.Name = "workoutPlansNotesText";
            this.workoutPlansNotesText.PasswordChar = '\0';
            this.workoutPlansNotesText.SelectedText = "";
            this.workoutPlansNotesText.SelectionLength = 0;
            this.workoutPlansNotesText.SelectionStart = 0;
            this.workoutPlansNotesText.Size = new System.Drawing.Size(339, 23);
            this.workoutPlansNotesText.TabIndex = 68;
            this.workoutPlansNotesText.UseSystemPasswordChar = false;
            // 
            // workoutPlanInstructorIdText
            // 
            this.workoutPlanInstructorIdText.Depth = 0;
            this.workoutPlanInstructorIdText.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workoutPlanInstructorIdText.ForeColor = System.Drawing.Color.Transparent;
            this.workoutPlanInstructorIdText.Hint = "Instructor ID";
            this.workoutPlanInstructorIdText.Location = new System.Drawing.Point(239, 209);
            this.workoutPlanInstructorIdText.MouseState = MaterialSkin.MouseState.HOVER;
            this.workoutPlanInstructorIdText.Name = "workoutPlanInstructorIdText";
            this.workoutPlanInstructorIdText.PasswordChar = '\0';
            this.workoutPlanInstructorIdText.SelectedText = "";
            this.workoutPlanInstructorIdText.SelectionLength = 0;
            this.workoutPlanInstructorIdText.SelectionStart = 0;
            this.workoutPlanInstructorIdText.Size = new System.Drawing.Size(339, 23);
            this.workoutPlanInstructorIdText.TabIndex = 66;
            this.workoutPlanInstructorIdText.UseSystemPasswordChar = false;
            // 
            // workoutPlanMemberIdText
            // 
            this.workoutPlanMemberIdText.Depth = 0;
            this.workoutPlanMemberIdText.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workoutPlanMemberIdText.ForeColor = System.Drawing.Color.Transparent;
            this.workoutPlanMemberIdText.Hint = "Member ID";
            this.workoutPlanMemberIdText.Location = new System.Drawing.Point(239, 159);
            this.workoutPlanMemberIdText.MouseState = MaterialSkin.MouseState.HOVER;
            this.workoutPlanMemberIdText.Name = "workoutPlanMemberIdText";
            this.workoutPlanMemberIdText.PasswordChar = '\0';
            this.workoutPlanMemberIdText.SelectedText = "";
            this.workoutPlanMemberIdText.SelectionLength = 0;
            this.workoutPlanMemberIdText.SelectionStart = 0;
            this.workoutPlanMemberIdText.Size = new System.Drawing.Size(339, 23);
            this.workoutPlanMemberIdText.TabIndex = 65;
            this.workoutPlanMemberIdText.UseSystemPasswordChar = false;
            // 
            // workoutPlanIdText
            // 
            this.workoutPlanIdText.Depth = 0;
            this.workoutPlanIdText.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workoutPlanIdText.ForeColor = System.Drawing.Color.Transparent;
            this.workoutPlanIdText.Hint = "Workout Plan ID";
            this.workoutPlanIdText.Location = new System.Drawing.Point(239, 102);
            this.workoutPlanIdText.MouseState = MaterialSkin.MouseState.HOVER;
            this.workoutPlanIdText.Name = "workoutPlanIdText";
            this.workoutPlanIdText.PasswordChar = '\0';
            this.workoutPlanIdText.SelectedText = "";
            this.workoutPlanIdText.SelectionLength = 0;
            this.workoutPlanIdText.SelectionStart = 0;
            this.workoutPlanIdText.Size = new System.Drawing.Size(339, 23);
            this.workoutPlanIdText.TabIndex = 64;
            this.workoutPlanIdText.UseSystemPasswordChar = false;
            // 
            // WorkoutPlanUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "WorkoutPlanUserControl";
            this.Size = new System.Drawing.Size(976, 700);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField workoutPlansNotesText;
        private MaterialSkin.Controls.MaterialSingleLineTextField workoutPlanInstructorIdText;
        private MaterialSkin.Controls.MaterialSingleLineTextField workoutPlanMemberIdText;
        private MaterialSkin.Controls.MaterialSingleLineTextField workoutPlanIdText;
        private System.Windows.Forms.Button addWorkoutPlanButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.RichTextBox workoutPlanExercisesText;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
    }
}
