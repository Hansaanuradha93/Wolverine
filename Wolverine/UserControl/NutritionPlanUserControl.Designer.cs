namespace Wolverine
{
    partial class NutritionPlanUserControl
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
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.nutritionPlanNutritionsText = new System.Windows.Forms.RichTextBox();
            this.addWorkoutPlanButton = new System.Windows.Forms.Button();
            this.nutritionPlanNotesText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.nutritionPlanInstructorIdText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.nutritionPlanMemberIdText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.nutritionPlanIdText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Controls.Add(this.nutritionPlanNutritionsText);
            this.panel1.Controls.Add(this.addWorkoutPlanButton);
            this.panel1.Controls.Add(this.nutritionPlanNotesText);
            this.panel1.Controls.Add(this.nutritionPlanInstructorIdText);
            this.panel1.Controls.Add(this.nutritionPlanMemberIdText);
            this.panel1.Controls.Add(this.nutritionPlanIdText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(976, 700);
            this.panel1.TabIndex = 0;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(292, 42);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(131, 19);
            this.materialLabel2.TabIndex = 97;
            this.materialLabel2.Text = "Add Nutrition Plan";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(188, 254);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(84, 19);
            this.materialLabel1.TabIndex = 96;
            this.materialLabel1.Text = "Nutritions :";
            // 
            // nutritionPlanNutritionsText
            // 
            this.nutritionPlanNutritionsText.BackColor = System.Drawing.SystemColors.Control;
            this.nutritionPlanNutritionsText.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nutritionPlanNutritionsText.Location = new System.Drawing.Point(192, 290);
            this.nutritionPlanNutritionsText.Name = "nutritionPlanNutritionsText";
            this.nutritionPlanNutritionsText.Size = new System.Drawing.Size(348, 135);
            this.nutritionPlanNutritionsText.TabIndex = 95;
            this.nutritionPlanNutritionsText.Text = "";
            // 
            // addWorkoutPlanButton
            // 
            this.addWorkoutPlanButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.addWorkoutPlanButton.FlatAppearance.BorderSize = 0;
            this.addWorkoutPlanButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addWorkoutPlanButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addWorkoutPlanButton.ForeColor = System.Drawing.Color.White;
            this.addWorkoutPlanButton.Location = new System.Drawing.Point(103, 499);
            this.addWorkoutPlanButton.Name = "addWorkoutPlanButton";
            this.addWorkoutPlanButton.Size = new System.Drawing.Size(533, 35);
            this.addWorkoutPlanButton.TabIndex = 94;
            this.addWorkoutPlanButton.Text = "Add Nutritions Plan";
            this.addWorkoutPlanButton.UseVisualStyleBackColor = false;
            this.addWorkoutPlanButton.Click += new System.EventHandler(this.addWorkoutPlanButton_Click);
            // 
            // nutritionPlanNotesText
            // 
            this.nutritionPlanNotesText.Depth = 0;
            this.nutritionPlanNotesText.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nutritionPlanNotesText.ForeColor = System.Drawing.Color.Transparent;
            this.nutritionPlanNotesText.Hint = "Notes";
            this.nutritionPlanNotesText.Location = new System.Drawing.Point(192, 440);
            this.nutritionPlanNotesText.MouseState = MaterialSkin.MouseState.HOVER;
            this.nutritionPlanNotesText.Name = "nutritionPlanNotesText";
            this.nutritionPlanNotesText.PasswordChar = '\0';
            this.nutritionPlanNotesText.SelectedText = "";
            this.nutritionPlanNotesText.SelectionLength = 0;
            this.nutritionPlanNotesText.SelectionStart = 0;
            this.nutritionPlanNotesText.Size = new System.Drawing.Size(339, 23);
            this.nutritionPlanNotesText.TabIndex = 93;
            this.nutritionPlanNotesText.UseSystemPasswordChar = false;
            // 
            // nutritionPlanInstructorIdText
            // 
            this.nutritionPlanInstructorIdText.Depth = 0;
            this.nutritionPlanInstructorIdText.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nutritionPlanInstructorIdText.ForeColor = System.Drawing.Color.Transparent;
            this.nutritionPlanInstructorIdText.Hint = "Instructor ID";
            this.nutritionPlanInstructorIdText.Location = new System.Drawing.Point(192, 212);
            this.nutritionPlanInstructorIdText.MouseState = MaterialSkin.MouseState.HOVER;
            this.nutritionPlanInstructorIdText.Name = "nutritionPlanInstructorIdText";
            this.nutritionPlanInstructorIdText.PasswordChar = '\0';
            this.nutritionPlanInstructorIdText.SelectedText = "";
            this.nutritionPlanInstructorIdText.SelectionLength = 0;
            this.nutritionPlanInstructorIdText.SelectionStart = 0;
            this.nutritionPlanInstructorIdText.Size = new System.Drawing.Size(339, 23);
            this.nutritionPlanInstructorIdText.TabIndex = 91;
            this.nutritionPlanInstructorIdText.UseSystemPasswordChar = false;
            // 
            // nutritionPlanMemberIdText
            // 
            this.nutritionPlanMemberIdText.Depth = 0;
            this.nutritionPlanMemberIdText.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nutritionPlanMemberIdText.ForeColor = System.Drawing.Color.Transparent;
            this.nutritionPlanMemberIdText.Hint = "Member ID";
            this.nutritionPlanMemberIdText.Location = new System.Drawing.Point(192, 162);
            this.nutritionPlanMemberIdText.MouseState = MaterialSkin.MouseState.HOVER;
            this.nutritionPlanMemberIdText.Name = "nutritionPlanMemberIdText";
            this.nutritionPlanMemberIdText.PasswordChar = '\0';
            this.nutritionPlanMemberIdText.SelectedText = "";
            this.nutritionPlanMemberIdText.SelectionLength = 0;
            this.nutritionPlanMemberIdText.SelectionStart = 0;
            this.nutritionPlanMemberIdText.Size = new System.Drawing.Size(339, 23);
            this.nutritionPlanMemberIdText.TabIndex = 90;
            this.nutritionPlanMemberIdText.UseSystemPasswordChar = false;
            // 
            // nutritionPlanIdText
            // 
            this.nutritionPlanIdText.Depth = 0;
            this.nutritionPlanIdText.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nutritionPlanIdText.ForeColor = System.Drawing.Color.Transparent;
            this.nutritionPlanIdText.Hint = "Nutrition Plan ID";
            this.nutritionPlanIdText.Location = new System.Drawing.Point(192, 105);
            this.nutritionPlanIdText.MouseState = MaterialSkin.MouseState.HOVER;
            this.nutritionPlanIdText.Name = "nutritionPlanIdText";
            this.nutritionPlanIdText.PasswordChar = '\0';
            this.nutritionPlanIdText.SelectedText = "";
            this.nutritionPlanIdText.SelectionLength = 0;
            this.nutritionPlanIdText.SelectionStart = 0;
            this.nutritionPlanIdText.Size = new System.Drawing.Size(339, 23);
            this.nutritionPlanIdText.TabIndex = 89;
            this.nutritionPlanIdText.UseSystemPasswordChar = false;
            // 
            // NutritionPlanUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "NutritionPlanUserControl";
            this.Size = new System.Drawing.Size(976, 700);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addWorkoutPlanButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField nutritionPlanNotesText;
        private MaterialSkin.Controls.MaterialSingleLineTextField nutritionPlanInstructorIdText;
        private MaterialSkin.Controls.MaterialSingleLineTextField nutritionPlanMemberIdText;
        private MaterialSkin.Controls.MaterialSingleLineTextField nutritionPlanIdText;
        private System.Windows.Forms.RichTextBox nutritionPlanNutritionsText;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}
