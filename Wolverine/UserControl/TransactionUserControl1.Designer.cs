namespace Wolverine
{
    partial class TransactionUserControl
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
            this.doTransactionButton = new System.Windows.Forms.Button();
            this.transactionAmountLabel = new MaterialSkin.Controls.MaterialLabel();
            this.transactionStartTime = new System.Windows.Forms.DateTimePicker();
            this.transactionDate = new System.Windows.Forms.DateTimePicker();
            this.transactionDurationText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.transactionMemberId = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.transactionIdText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel2 = new System.Windows.Forms.Panel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.materialLabel4);
            this.panel1.Controls.Add(this.materialLabel3);
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Controls.Add(this.doTransactionButton);
            this.panel1.Controls.Add(this.transactionAmountLabel);
            this.panel1.Controls.Add(this.transactionStartTime);
            this.panel1.Controls.Add(this.transactionDate);
            this.panel1.Controls.Add(this.transactionDurationText);
            this.panel1.Controls.Add(this.transactionMemberId);
            this.panel1.Controls.Add(this.transactionIdText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 631);
            this.panel1.TabIndex = 0;
            // 
            // doTransactionButton
            // 
            this.doTransactionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.doTransactionButton.FlatAppearance.BorderSize = 0;
            this.doTransactionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doTransactionButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doTransactionButton.ForeColor = System.Drawing.Color.White;
            this.doTransactionButton.Location = new System.Drawing.Point(24, 421);
            this.doTransactionButton.Name = "doTransactionButton";
            this.doTransactionButton.Size = new System.Drawing.Size(533, 35);
            this.doTransactionButton.TabIndex = 87;
            this.doTransactionButton.Text = "Pay";
            this.doTransactionButton.UseVisualStyleBackColor = false;
            this.doTransactionButton.Click += new System.EventHandler(this.doTransactionButton_Click);
            // 
            // transactionAmountLabel
            // 
            this.transactionAmountLabel.AutoSize = true;
            this.transactionAmountLabel.Depth = 0;
            this.transactionAmountLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionAmountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.transactionAmountLabel.Location = new System.Drawing.Point(99, 371);
            this.transactionAmountLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.transactionAmountLabel.Name = "transactionAmountLabel";
            this.transactionAmountLabel.Size = new System.Drawing.Size(78, 20);
            this.transactionAmountLabel.TabIndex = 86;
            this.transactionAmountLabel.Text = "Amount : ";
            // 
            // transactionStartTime
            // 
            this.transactionStartTime.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.transactionStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.transactionStartTime.Location = new System.Drawing.Point(202, 268);
            this.transactionStartTime.Name = "transactionStartTime";
            this.transactionStartTime.Size = new System.Drawing.Size(240, 21);
            this.transactionStartTime.TabIndex = 85;
            // 
            // transactionDate
            // 
            this.transactionDate.CalendarFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionDate.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.transactionDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.transactionDate.Location = new System.Drawing.Point(202, 216);
            this.transactionDate.Name = "transactionDate";
            this.transactionDate.Size = new System.Drawing.Size(240, 21);
            this.transactionDate.TabIndex = 84;
            // 
            // transactionDurationText
            // 
            this.transactionDurationText.Depth = 0;
            this.transactionDurationText.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionDurationText.ForeColor = System.Drawing.Color.Transparent;
            this.transactionDurationText.Hint = "Duration";
            this.transactionDurationText.Location = new System.Drawing.Point(103, 321);
            this.transactionDurationText.MouseState = MaterialSkin.MouseState.HOVER;
            this.transactionDurationText.Name = "transactionDurationText";
            this.transactionDurationText.PasswordChar = '\0';
            this.transactionDurationText.SelectedText = "";
            this.transactionDurationText.SelectionLength = 0;
            this.transactionDurationText.SelectionStart = 0;
            this.transactionDurationText.Size = new System.Drawing.Size(339, 23);
            this.transactionDurationText.TabIndex = 65;
            this.transactionDurationText.UseSystemPasswordChar = false;
            // 
            // transactionMemberId
            // 
            this.transactionMemberId.Depth = 0;
            this.transactionMemberId.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionMemberId.ForeColor = System.Drawing.Color.Transparent;
            this.transactionMemberId.Hint = "Member ID";
            this.transactionMemberId.Location = new System.Drawing.Point(103, 156);
            this.transactionMemberId.MouseState = MaterialSkin.MouseState.HOVER;
            this.transactionMemberId.Name = "transactionMemberId";
            this.transactionMemberId.PasswordChar = '\0';
            this.transactionMemberId.SelectedText = "";
            this.transactionMemberId.SelectionLength = 0;
            this.transactionMemberId.SelectionStart = 0;
            this.transactionMemberId.Size = new System.Drawing.Size(339, 23);
            this.transactionMemberId.TabIndex = 64;
            this.transactionMemberId.UseSystemPasswordChar = false;
            // 
            // transactionIdText
            // 
            this.transactionIdText.Depth = 0;
            this.transactionIdText.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionIdText.ForeColor = System.Drawing.Color.Transparent;
            this.transactionIdText.Hint = "Transaction ID";
            this.transactionIdText.Location = new System.Drawing.Point(103, 103);
            this.transactionIdText.MouseState = MaterialSkin.MouseState.HOVER;
            this.transactionIdText.Name = "transactionIdText";
            this.transactionIdText.PasswordChar = '\0';
            this.transactionIdText.SelectedText = "";
            this.transactionIdText.SelectionLength = 0;
            this.transactionIdText.SelectionStart = 0;
            this.transactionIdText.Size = new System.Drawing.Size(339, 23);
            this.transactionIdText.TabIndex = 63;
            this.transactionIdText.UseSystemPasswordChar = false;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(575, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(401, 631);
            this.panel2.TabIndex = 1;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(212, 38);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(160, 23);
            this.materialLabel2.TabIndex = 99;
            this.materialLabel2.Text = "Add Transaction";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(99, 268);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(76, 20);
            this.materialLabel4.TabIndex = 101;
            this.materialLabel4.Text = "Start Time";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(99, 216);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(45, 20);
            this.materialLabel3.TabIndex = 100;
            this.materialLabel3.Text = "Date";
            // 
            // TransactionUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "TransactionUserControl";
            this.Size = new System.Drawing.Size(976, 631);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField transactionDurationText;
        private MaterialSkin.Controls.MaterialSingleLineTextField transactionMemberId;
        private MaterialSkin.Controls.MaterialSingleLineTextField transactionIdText;
        private System.Windows.Forms.DateTimePicker transactionDate;
        private System.Windows.Forms.DateTimePicker transactionStartTime;
        private MaterialSkin.Controls.MaterialLabel transactionAmountLabel;
        private System.Windows.Forms.Button doTransactionButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
    }
}
