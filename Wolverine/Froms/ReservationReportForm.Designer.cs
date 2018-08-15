namespace Wolverine
{
    partial class ReservationReportForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.toDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.fromDate = new System.Windows.Forms.DateTimePicker();
            this.reservationReportLoadButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rStartTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rDurationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rApprovalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gymnasiumDataSet5 = new Wolverine.GymnasiumDataSet5();
            this.reservationTableAdapter = new Wolverine.GymnasiumDataSet5TableAdapters.ReservationTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymnasiumDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(385, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "To";
            // 
            // toDate
            // 
            this.toDate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDate.Location = new System.Drawing.Point(458, 108);
            this.toDate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.toDate.Name = "toDate";
            this.toDate.Size = new System.Drawing.Size(271, 23);
            this.toDate.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(385, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "From";
            // 
            // fromDate
            // 
            this.fromDate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromDate.Location = new System.Drawing.Point(458, 60);
            this.fromDate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.fromDate.Name = "fromDate";
            this.fromDate.Size = new System.Drawing.Size(271, 23);
            this.fromDate.TabIndex = 10;
            // 
            // reservationReportLoadButton
            // 
            this.reservationReportLoadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reservationReportLoadButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationReportLoadButton.Location = new System.Drawing.Point(758, 98);
            this.reservationReportLoadButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.reservationReportLoadButton.Name = "reservationReportLoadButton";
            this.reservationReportLoadButton.Size = new System.Drawing.Size(187, 34);
            this.reservationReportLoadButton.TabIndex = 9;
            this.reservationReportLoadButton.Text = "Load";
            this.reservationReportLoadButton.UseVisualStyleBackColor = true;
            this.reservationReportLoadButton.Click += new System.EventHandler(this.reservationReportLoadButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rIDDataGridViewTextBoxColumn,
            this.mIDDataGridViewTextBoxColumn,
            this.rDateDataGridViewTextBoxColumn,
            this.rStartTimeDataGridViewTextBoxColumn,
            this.rDurationDataGridViewTextBoxColumn,
            this.rAmountDataGridViewTextBoxColumn,
            this.rApprovalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.reservationBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(99, 158);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(849, 491);
            this.dataGridView1.TabIndex = 8;
            // 
            // rIDDataGridViewTextBoxColumn
            // 
            this.rIDDataGridViewTextBoxColumn.DataPropertyName = "rID";
            this.rIDDataGridViewTextBoxColumn.HeaderText = "rID";
            this.rIDDataGridViewTextBoxColumn.Name = "rIDDataGridViewTextBoxColumn";
            // 
            // mIDDataGridViewTextBoxColumn
            // 
            this.mIDDataGridViewTextBoxColumn.DataPropertyName = "mID";
            this.mIDDataGridViewTextBoxColumn.HeaderText = "mID";
            this.mIDDataGridViewTextBoxColumn.Name = "mIDDataGridViewTextBoxColumn";
            // 
            // rDateDataGridViewTextBoxColumn
            // 
            this.rDateDataGridViewTextBoxColumn.DataPropertyName = "rDate";
            this.rDateDataGridViewTextBoxColumn.HeaderText = "rDate";
            this.rDateDataGridViewTextBoxColumn.Name = "rDateDataGridViewTextBoxColumn";
            // 
            // rStartTimeDataGridViewTextBoxColumn
            // 
            this.rStartTimeDataGridViewTextBoxColumn.DataPropertyName = "rStartTime";
            this.rStartTimeDataGridViewTextBoxColumn.HeaderText = "rStartTime";
            this.rStartTimeDataGridViewTextBoxColumn.Name = "rStartTimeDataGridViewTextBoxColumn";
            // 
            // rDurationDataGridViewTextBoxColumn
            // 
            this.rDurationDataGridViewTextBoxColumn.DataPropertyName = "rDuration";
            this.rDurationDataGridViewTextBoxColumn.HeaderText = "rDuration";
            this.rDurationDataGridViewTextBoxColumn.Name = "rDurationDataGridViewTextBoxColumn";
            // 
            // rAmountDataGridViewTextBoxColumn
            // 
            this.rAmountDataGridViewTextBoxColumn.DataPropertyName = "rAmount";
            this.rAmountDataGridViewTextBoxColumn.HeaderText = "rAmount";
            this.rAmountDataGridViewTextBoxColumn.Name = "rAmountDataGridViewTextBoxColumn";
            // 
            // rApprovalDataGridViewTextBoxColumn
            // 
            this.rApprovalDataGridViewTextBoxColumn.DataPropertyName = "rApproval";
            this.rApprovalDataGridViewTextBoxColumn.HeaderText = "rApproval";
            this.rApprovalDataGridViewTextBoxColumn.Name = "rApprovalDataGridViewTextBoxColumn";
            // 
            // reservationBindingSource
            // 
            this.reservationBindingSource.DataMember = "Reservation";
            this.reservationBindingSource.DataSource = this.gymnasiumDataSet5;
            // 
            // gymnasiumDataSet5
            // 
            this.gymnasiumDataSet5.DataSetName = "GymnasiumDataSet5";
            this.gymnasiumDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reservationTableAdapter
            // 
            this.reservationTableAdapter.ClearBeforeFill = true;
            // 
            // ReservationReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 682);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fromDate);
            this.Controls.Add(this.reservationReportLoadButton);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ReservationReportForm";
            this.Padding = new System.Windows.Forms.Padding(23, 74, 23, 25);
            this.Text = "ReservationReportForm";
            this.Load += new System.EventHandler(this.ReservationReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymnasiumDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker toDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker fromDate;
        private System.Windows.Forms.Button reservationReportLoadButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private GymnasiumDataSet5 gymnasiumDataSet5;
        private System.Windows.Forms.BindingSource reservationBindingSource;
        private GymnasiumDataSet5TableAdapters.ReservationTableAdapter reservationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rStartTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rDurationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rApprovalDataGridViewTextBoxColumn;
    }
}