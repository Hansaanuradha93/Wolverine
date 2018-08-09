namespace Wolverine
{
    partial class ReservationUserControl
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
            this.reservationAmountText = new MaterialSkin.Controls.MaterialLabel();
            this.addReservationButton = new System.Windows.Forms.Button();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.reservationMemberIdText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.reservationDurationText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.reservationStartTimePicker = new System.Windows.Forms.DateTimePicker();
            this.reservationDataPicker = new System.Windows.Forms.DateTimePicker();
            this.reservationIdText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel2 = new System.Windows.Forms.Panel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.notApproveRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.approvedRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.approveInstructorId = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.approveReservationText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.approveReservationButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Controls.Add(this.reservationAmountText);
            this.panel1.Controls.Add(this.addReservationButton);
            this.panel1.Controls.Add(this.materialLabel4);
            this.panel1.Controls.Add(this.materialLabel3);
            this.panel1.Controls.Add(this.reservationMemberIdText);
            this.panel1.Controls.Add(this.reservationDurationText);
            this.panel1.Controls.Add(this.reservationStartTimePicker);
            this.panel1.Controls.Add(this.reservationDataPicker);
            this.panel1.Controls.Add(this.reservationIdText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 700);
            this.panel1.TabIndex = 0;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(152, 24);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(118, 19);
            this.materialLabel2.TabIndex = 98;
            this.materialLabel2.Text = "Add Reservation";
            // 
            // reservationAmountText
            // 
            this.reservationAmountText.AutoSize = true;
            this.reservationAmountText.Depth = 0;
            this.reservationAmountText.Font = new System.Drawing.Font("Roboto", 11F);
            this.reservationAmountText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.reservationAmountText.Location = new System.Drawing.Point(58, 343);
            this.reservationAmountText.MouseState = MaterialSkin.MouseState.HOVER;
            this.reservationAmountText.Name = "reservationAmountText";
            this.reservationAmountText.Size = new System.Drawing.Size(74, 19);
            this.reservationAmountText.TabIndex = 95;
            this.reservationAmountText.Text = "Amount : ";
            // 
            // addReservationButton
            // 
            this.addReservationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.addReservationButton.FlatAppearance.BorderSize = 0;
            this.addReservationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addReservationButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addReservationButton.ForeColor = System.Drawing.Color.White;
            this.addReservationButton.Location = new System.Drawing.Point(8, 393);
            this.addReservationButton.Name = "addReservationButton";
            this.addReservationButton.Size = new System.Drawing.Size(442, 35);
            this.addReservationButton.TabIndex = 94;
            this.addReservationButton.Text = "Add Reservation";
            this.addReservationButton.UseVisualStyleBackColor = false;
            this.addReservationButton.Click += new System.EventHandler(this.addMemberButton_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(58, 238);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(79, 19);
            this.materialLabel4.TabIndex = 93;
            this.materialLabel4.Text = "Start Time";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(58, 196);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(40, 19);
            this.materialLabel3.TabIndex = 92;
            this.materialLabel3.Text = "Date";
            // 
            // reservationMemberIdText
            // 
            this.reservationMemberIdText.Depth = 0;
            this.reservationMemberIdText.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationMemberIdText.ForeColor = System.Drawing.Color.Transparent;
            this.reservationMemberIdText.Hint = "Member ID";
            this.reservationMemberIdText.Location = new System.Drawing.Point(62, 140);
            this.reservationMemberIdText.MouseState = MaterialSkin.MouseState.HOVER;
            this.reservationMemberIdText.Name = "reservationMemberIdText";
            this.reservationMemberIdText.PasswordChar = '\0';
            this.reservationMemberIdText.SelectedText = "";
            this.reservationMemberIdText.SelectionLength = 0;
            this.reservationMemberIdText.SelectionStart = 0;
            this.reservationMemberIdText.Size = new System.Drawing.Size(339, 23);
            this.reservationMemberIdText.TabIndex = 88;
            this.reservationMemberIdText.UseSystemPasswordChar = false;
            // 
            // reservationDurationText
            // 
            this.reservationDurationText.Depth = 0;
            this.reservationDurationText.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationDurationText.ForeColor = System.Drawing.Color.Transparent;
            this.reservationDurationText.Hint = "Duration";
            this.reservationDurationText.Location = new System.Drawing.Point(62, 295);
            this.reservationDurationText.MouseState = MaterialSkin.MouseState.HOVER;
            this.reservationDurationText.Name = "reservationDurationText";
            this.reservationDurationText.PasswordChar = '\0';
            this.reservationDurationText.SelectedText = "";
            this.reservationDurationText.SelectionLength = 0;
            this.reservationDurationText.SelectionStart = 0;
            this.reservationDurationText.Size = new System.Drawing.Size(339, 23);
            this.reservationDurationText.TabIndex = 87;
            this.reservationDurationText.UseSystemPasswordChar = false;
            // 
            // reservationStartTimePicker
            // 
            this.reservationStartTimePicker.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.reservationStartTimePicker.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationStartTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.reservationStartTimePicker.Location = new System.Drawing.Point(145, 239);
            this.reservationStartTimePicker.Name = "reservationStartTimePicker";
            this.reservationStartTimePicker.Size = new System.Drawing.Size(200, 21);
            this.reservationStartTimePicker.TabIndex = 84;
            // 
            // reservationDataPicker
            // 
            this.reservationDataPicker.CalendarFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationDataPicker.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.reservationDataPicker.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationDataPicker.Location = new System.Drawing.Point(144, 196);
            this.reservationDataPicker.Name = "reservationDataPicker";
            this.reservationDataPicker.Size = new System.Drawing.Size(200, 21);
            this.reservationDataPicker.TabIndex = 83;
            // 
            // reservationIdText
            // 
            this.reservationIdText.Depth = 0;
            this.reservationIdText.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationIdText.ForeColor = System.Drawing.Color.Transparent;
            this.reservationIdText.Hint = "Reservation ID";
            this.reservationIdText.Location = new System.Drawing.Point(62, 90);
            this.reservationIdText.MouseState = MaterialSkin.MouseState.HOVER;
            this.reservationIdText.Name = "reservationIdText";
            this.reservationIdText.PasswordChar = '\0';
            this.reservationIdText.SelectedText = "";
            this.reservationIdText.SelectionLength = 0;
            this.reservationIdText.SelectionStart = 0;
            this.reservationIdText.Size = new System.Drawing.Size(339, 23);
            this.reservationIdText.TabIndex = 82;
            this.reservationIdText.UseSystemPasswordChar = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.materialLabel5);
            this.panel2.Controls.Add(this.notApproveRadioButton);
            this.panel2.Controls.Add(this.approvedRadioButton);
            this.panel2.Controls.Add(this.materialLabel1);
            this.panel2.Controls.Add(this.approveInstructorId);
            this.panel2.Controls.Add(this.approveReservationText);
            this.panel2.Controls.Add(this.approveReservationButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(463, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(513, 700);
            this.panel2.TabIndex = 1;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(96, 24);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(147, 19);
            this.materialLabel5.TabIndex = 99;
            this.materialLabel5.Text = "Approve Reservation";
            // 
            // notApproveRadioButton
            // 
            this.notApproveRadioButton.AutoSize = true;
            this.notApproveRadioButton.Depth = 0;
            this.notApproveRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.notApproveRadioButton.ForeColor = System.Drawing.Color.White;
            this.notApproveRadioButton.Location = new System.Drawing.Point(90, 231);
            this.notApproveRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.notApproveRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.notApproveRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.notApproveRadioButton.Name = "notApproveRadioButton";
            this.notApproveRadioButton.Ripple = true;
            this.notApproveRadioButton.Size = new System.Drawing.Size(47, 30);
            this.notApproveRadioButton.TabIndex = 87;
            this.notApproveRadioButton.TabStop = true;
            this.notApproveRadioButton.Text = "No";
            this.notApproveRadioButton.UseVisualStyleBackColor = true;
            // 
            // approvedRadioButton
            // 
            this.approvedRadioButton.AutoSize = true;
            this.approvedRadioButton.Depth = 0;
            this.approvedRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.approvedRadioButton.ForeColor = System.Drawing.Color.White;
            this.approvedRadioButton.Location = new System.Drawing.Point(89, 197);
            this.approvedRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.approvedRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.approvedRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.approvedRadioButton.Name = "approvedRadioButton";
            this.approvedRadioButton.Ripple = true;
            this.approvedRadioButton.Size = new System.Drawing.Size(52, 30);
            this.approvedRadioButton.TabIndex = 86;
            this.approvedRadioButton.TabStop = true;
            this.approvedRadioButton.Text = "Yes";
            this.approvedRadioButton.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(19, 199);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(68, 19);
            this.materialLabel1.TabIndex = 85;
            this.materialLabel1.Text = "Approvel";
            // 
            // approveInstructorId
            // 
            this.approveInstructorId.Depth = 0;
            this.approveInstructorId.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approveInstructorId.ForeColor = System.Drawing.Color.Transparent;
            this.approveInstructorId.Hint = "Instructor ID";
            this.approveInstructorId.Location = new System.Drawing.Point(19, 141);
            this.approveInstructorId.MouseState = MaterialSkin.MouseState.HOVER;
            this.approveInstructorId.Name = "approveInstructorId";
            this.approveInstructorId.PasswordChar = '\0';
            this.approveInstructorId.SelectedText = "";
            this.approveInstructorId.SelectionLength = 0;
            this.approveInstructorId.SelectionStart = 0;
            this.approveInstructorId.Size = new System.Drawing.Size(339, 23);
            this.approveInstructorId.TabIndex = 84;
            this.approveInstructorId.UseSystemPasswordChar = false;
            // 
            // approveReservationText
            // 
            this.approveReservationText.Depth = 0;
            this.approveReservationText.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approveReservationText.ForeColor = System.Drawing.Color.Transparent;
            this.approveReservationText.Hint = "Reservation ID";
            this.approveReservationText.Location = new System.Drawing.Point(19, 91);
            this.approveReservationText.MouseState = MaterialSkin.MouseState.HOVER;
            this.approveReservationText.Name = "approveReservationText";
            this.approveReservationText.PasswordChar = '\0';
            this.approveReservationText.SelectedText = "";
            this.approveReservationText.SelectionLength = 0;
            this.approveReservationText.SelectionStart = 0;
            this.approveReservationText.Size = new System.Drawing.Size(339, 23);
            this.approveReservationText.TabIndex = 83;
            this.approveReservationText.UseSystemPasswordChar = false;
            // 
            // approveReservationButton
            // 
            this.approveReservationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.approveReservationButton.FlatAppearance.BorderSize = 0;
            this.approveReservationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.approveReservationButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approveReservationButton.ForeColor = System.Drawing.Color.White;
            this.approveReservationButton.Location = new System.Drawing.Point(6, 393);
            this.approveReservationButton.Name = "approveReservationButton";
            this.approveReservationButton.Size = new System.Drawing.Size(358, 35);
            this.approveReservationButton.TabIndex = 42;
            this.approveReservationButton.Text = "Approve";
            this.approveReservationButton.UseVisualStyleBackColor = false;
            this.approveReservationButton.Click += new System.EventHandler(this.approveReservationButton_Click);
            // 
            // ReservationUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ReservationUserControl";
            this.Size = new System.Drawing.Size(976, 700);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField reservationMemberIdText;
        private MaterialSkin.Controls.MaterialSingleLineTextField reservationDurationText;
        private System.Windows.Forms.DateTimePicker reservationStartTimePicker;
        private System.Windows.Forms.DateTimePicker reservationDataPicker;
        private MaterialSkin.Controls.MaterialSingleLineTextField reservationIdText;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.Button addReservationButton;
        private System.Windows.Forms.Button approveReservationButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField approveInstructorId;
        private MaterialSkin.Controls.MaterialSingleLineTextField approveReservationText;
        private MaterialSkin.Controls.MaterialRadioButton notApproveRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton approvedRadioButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel reservationAmountText;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
    }
}
