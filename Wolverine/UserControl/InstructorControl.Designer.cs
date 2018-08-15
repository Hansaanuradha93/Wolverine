namespace Wolverine
{
    partial class InstructorControl
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
            this.addInstructorButton = new System.Windows.Forms.Button();
            this.instructorIdText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.instructorFemaleRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.instructorMaleRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.instructorContactNumberText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.instructorStateText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.instructorCityText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.instructorStreetText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.instructorAgeText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.instructorLastNameText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.instructorFirstNameText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Controls.Add(this.addInstructorButton);
            this.panel1.Controls.Add(this.instructorIdText);
            this.panel1.Controls.Add(this.instructorFemaleRadioButton);
            this.panel1.Controls.Add(this.instructorMaleRadioButton);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Controls.Add(this.instructorContactNumberText);
            this.panel1.Controls.Add(this.instructorStateText);
            this.panel1.Controls.Add(this.instructorCityText);
            this.panel1.Controls.Add(this.instructorStreetText);
            this.panel1.Controls.Add(this.instructorAgeText);
            this.panel1.Controls.Add(this.instructorLastNameText);
            this.panel1.Controls.Add(this.instructorFirstNameText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.materialLabel2.Location = new System.Drawing.Point(338, 15);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(104, 19);
            this.materialLabel2.TabIndex = 95;
            this.materialLabel2.Text = "Add Instructor";
            // 
            // addInstructorButton
            // 
            this.addInstructorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.addInstructorButton.FlatAppearance.BorderSize = 0;
            this.addInstructorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addInstructorButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addInstructorButton.ForeColor = System.Drawing.Color.White;
            this.addInstructorButton.Location = new System.Drawing.Point(170, 481);
            this.addInstructorButton.Name = "addInstructorButton";
            this.addInstructorButton.Size = new System.Drawing.Size(533, 35);
            this.addInstructorButton.TabIndex = 81;
            this.addInstructorButton.Text = "Add Member";
            this.addInstructorButton.UseVisualStyleBackColor = false;
            this.addInstructorButton.Click += new System.EventHandler(this.addInstructorButton_Click);
            // 
            // instructorIdText
            // 
            this.instructorIdText.Depth = 0;
            this.instructorIdText.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructorIdText.ForeColor = System.Drawing.Color.Transparent;
            this.instructorIdText.Hint = "Instructor ID";
            this.instructorIdText.Location = new System.Drawing.Point(247, 68);
            this.instructorIdText.MouseState = MaterialSkin.MouseState.HOVER;
            this.instructorIdText.Name = "instructorIdText";
            this.instructorIdText.PasswordChar = '\0';
            this.instructorIdText.SelectedText = "";
            this.instructorIdText.SelectionLength = 0;
            this.instructorIdText.SelectionStart = 0;
            this.instructorIdText.Size = new System.Drawing.Size(339, 23);
            this.instructorIdText.TabIndex = 94;
            this.instructorIdText.UseSystemPasswordChar = false;
            // 
            // instructorFemaleRadioButton
            // 
            this.instructorFemaleRadioButton.AutoSize = true;
            this.instructorFemaleRadioButton.Depth = 0;
            this.instructorFemaleRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.instructorFemaleRadioButton.Location = new System.Drawing.Point(388, 390);
            this.instructorFemaleRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.instructorFemaleRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.instructorFemaleRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.instructorFemaleRadioButton.Name = "instructorFemaleRadioButton";
            this.instructorFemaleRadioButton.Ripple = true;
            this.instructorFemaleRadioButton.Size = new System.Drawing.Size(74, 30);
            this.instructorFemaleRadioButton.TabIndex = 93;
            this.instructorFemaleRadioButton.TabStop = true;
            this.instructorFemaleRadioButton.Text = "Female";
            this.instructorFemaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // instructorMaleRadioButton
            // 
            this.instructorMaleRadioButton.AutoSize = true;
            this.instructorMaleRadioButton.Depth = 0;
            this.instructorMaleRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.instructorMaleRadioButton.Location = new System.Drawing.Point(313, 388);
            this.instructorMaleRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.instructorMaleRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.instructorMaleRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.instructorMaleRadioButton.Name = "instructorMaleRadioButton";
            this.instructorMaleRadioButton.Ripple = true;
            this.instructorMaleRadioButton.Size = new System.Drawing.Size(59, 30);
            this.instructorMaleRadioButton.TabIndex = 92;
            this.instructorMaleRadioButton.TabStop = true;
            this.instructorMaleRadioButton.Text = "Male";
            this.instructorMaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(243, 390);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(56, 19);
            this.materialLabel1.TabIndex = 91;
            this.materialLabel1.Text = "Gender";
            // 
            // instructorContactNumberText
            // 
            this.instructorContactNumberText.Depth = 0;
            this.instructorContactNumberText.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructorContactNumberText.ForeColor = System.Drawing.Color.Transparent;
            this.instructorContactNumberText.Hint = "Contact Number";
            this.instructorContactNumberText.Location = new System.Drawing.Point(246, 438);
            this.instructorContactNumberText.MouseState = MaterialSkin.MouseState.HOVER;
            this.instructorContactNumberText.Name = "instructorContactNumberText";
            this.instructorContactNumberText.PasswordChar = '\0';
            this.instructorContactNumberText.SelectedText = "";
            this.instructorContactNumberText.SelectionLength = 0;
            this.instructorContactNumberText.SelectionStart = 0;
            this.instructorContactNumberText.Size = new System.Drawing.Size(339, 23);
            this.instructorContactNumberText.TabIndex = 90;
            this.instructorContactNumberText.UseSystemPasswordChar = false;
            // 
            // instructorStateText
            // 
            this.instructorStateText.Depth = 0;
            this.instructorStateText.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructorStateText.ForeColor = System.Drawing.Color.Transparent;
            this.instructorStateText.Hint = "State Name";
            this.instructorStateText.Location = new System.Drawing.Point(246, 346);
            this.instructorStateText.MouseState = MaterialSkin.MouseState.HOVER;
            this.instructorStateText.Name = "instructorStateText";
            this.instructorStateText.PasswordChar = '\0';
            this.instructorStateText.SelectedText = "";
            this.instructorStateText.SelectionLength = 0;
            this.instructorStateText.SelectionStart = 0;
            this.instructorStateText.Size = new System.Drawing.Size(339, 23);
            this.instructorStateText.TabIndex = 89;
            this.instructorStateText.UseSystemPasswordChar = false;
            // 
            // instructorCityText
            // 
            this.instructorCityText.Depth = 0;
            this.instructorCityText.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructorCityText.ForeColor = System.Drawing.Color.Transparent;
            this.instructorCityText.Hint = "City Name";
            this.instructorCityText.Location = new System.Drawing.Point(246, 303);
            this.instructorCityText.MouseState = MaterialSkin.MouseState.HOVER;
            this.instructorCityText.Name = "instructorCityText";
            this.instructorCityText.PasswordChar = '\0';
            this.instructorCityText.SelectedText = "";
            this.instructorCityText.SelectionLength = 0;
            this.instructorCityText.SelectionStart = 0;
            this.instructorCityText.Size = new System.Drawing.Size(339, 23);
            this.instructorCityText.TabIndex = 88;
            this.instructorCityText.UseSystemPasswordChar = false;
            // 
            // instructorStreetText
            // 
            this.instructorStreetText.Depth = 0;
            this.instructorStreetText.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructorStreetText.ForeColor = System.Drawing.Color.Transparent;
            this.instructorStreetText.Hint = "Street Name";
            this.instructorStreetText.Location = new System.Drawing.Point(246, 258);
            this.instructorStreetText.MouseState = MaterialSkin.MouseState.HOVER;
            this.instructorStreetText.Name = "instructorStreetText";
            this.instructorStreetText.PasswordChar = '\0';
            this.instructorStreetText.SelectedText = "";
            this.instructorStreetText.SelectionLength = 0;
            this.instructorStreetText.SelectionStart = 0;
            this.instructorStreetText.Size = new System.Drawing.Size(339, 23);
            this.instructorStreetText.TabIndex = 87;
            this.instructorStreetText.UseSystemPasswordChar = false;
            // 
            // instructorAgeText
            // 
            this.instructorAgeText.Depth = 0;
            this.instructorAgeText.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructorAgeText.ForeColor = System.Drawing.Color.Transparent;
            this.instructorAgeText.Hint = "Age";
            this.instructorAgeText.Location = new System.Drawing.Point(247, 210);
            this.instructorAgeText.MouseState = MaterialSkin.MouseState.HOVER;
            this.instructorAgeText.Name = "instructorAgeText";
            this.instructorAgeText.PasswordChar = '\0';
            this.instructorAgeText.SelectedText = "";
            this.instructorAgeText.SelectionLength = 0;
            this.instructorAgeText.SelectionStart = 0;
            this.instructorAgeText.Size = new System.Drawing.Size(125, 23);
            this.instructorAgeText.TabIndex = 84;
            this.instructorAgeText.UseSystemPasswordChar = false;
            // 
            // instructorLastNameText
            // 
            this.instructorLastNameText.Depth = 0;
            this.instructorLastNameText.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructorLastNameText.ForeColor = System.Drawing.Color.Transparent;
            this.instructorLastNameText.Hint = "Last Name";
            this.instructorLastNameText.Location = new System.Drawing.Point(246, 164);
            this.instructorLastNameText.MouseState = MaterialSkin.MouseState.HOVER;
            this.instructorLastNameText.Name = "instructorLastNameText";
            this.instructorLastNameText.PasswordChar = '\0';
            this.instructorLastNameText.SelectedText = "";
            this.instructorLastNameText.SelectionLength = 0;
            this.instructorLastNameText.SelectionStart = 0;
            this.instructorLastNameText.Size = new System.Drawing.Size(339, 23);
            this.instructorLastNameText.TabIndex = 83;
            this.instructorLastNameText.UseSystemPasswordChar = false;
            // 
            // instructorFirstNameText
            // 
            this.instructorFirstNameText.Depth = 0;
            this.instructorFirstNameText.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructorFirstNameText.ForeColor = System.Drawing.Color.Transparent;
            this.instructorFirstNameText.Hint = "First Name";
            this.instructorFirstNameText.Location = new System.Drawing.Point(247, 117);
            this.instructorFirstNameText.MouseState = MaterialSkin.MouseState.HOVER;
            this.instructorFirstNameText.Name = "instructorFirstNameText";
            this.instructorFirstNameText.PasswordChar = '\0';
            this.instructorFirstNameText.SelectedText = "";
            this.instructorFirstNameText.SelectionLength = 0;
            this.instructorFirstNameText.SelectionStart = 0;
            this.instructorFirstNameText.Size = new System.Drawing.Size(339, 23);
            this.instructorFirstNameText.TabIndex = 82;
            this.instructorFirstNameText.UseSystemPasswordChar = false;
            // 
            // InstructorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "InstructorControl";
            this.Size = new System.Drawing.Size(976, 700);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialRadioButton instructorFemaleRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton instructorMaleRadioButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField instructorContactNumberText;
        private MaterialSkin.Controls.MaterialSingleLineTextField instructorStateText;
        private MaterialSkin.Controls.MaterialSingleLineTextField instructorCityText;
        private MaterialSkin.Controls.MaterialSingleLineTextField instructorStreetText;
        private MaterialSkin.Controls.MaterialSingleLineTextField instructorAgeText;
        private MaterialSkin.Controls.MaterialSingleLineTextField instructorLastNameText;
        private MaterialSkin.Controls.MaterialSingleLineTextField instructorFirstNameText;
        private System.Windows.Forms.Button addInstructorButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField instructorIdText;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}
