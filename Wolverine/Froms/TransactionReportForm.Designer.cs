namespace Wolverine
{
    partial class TransactionReportForm
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
            this.tIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tStartTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tDurationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gymnasiumDataSet6 = new Wolverine.GymnasiumDataSet6();
            this.label3 = new System.Windows.Forms.Label();
            this.transactionsTableAdapter = new Wolverine.GymnasiumDataSet6TableAdapters.TransactionsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymnasiumDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(224, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "From Date";
            // 
            // toDate
            // 
            this.toDate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDate.Location = new System.Drawing.Point(329, 126);
            this.toDate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.toDate.Name = "toDate";
            this.toDate.Size = new System.Drawing.Size(315, 26);
            this.toDate.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, -17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "From";
            // 
            // fromDate
            // 
            this.fromDate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromDate.Location = new System.Drawing.Point(329, 80);
            this.fromDate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.fromDate.Name = "fromDate";
            this.fromDate.Size = new System.Drawing.Size(314, 26);
            this.fromDate.TabIndex = 16;
            // 
            // reservationReportLoadButton
            // 
            this.reservationReportLoadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reservationReportLoadButton.Location = new System.Drawing.Point(680, 123);
            this.reservationReportLoadButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.reservationReportLoadButton.Name = "reservationReportLoadButton";
            this.reservationReportLoadButton.Size = new System.Drawing.Size(187, 34);
            this.reservationReportLoadButton.TabIndex = 15;
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
            this.tIDDataGridViewTextBoxColumn,
            this.mID,
            this.tDateDataGridViewTextBoxColumn,
            this.tStartTimeDataGridViewTextBoxColumn,
            this.tDurationDataGridViewTextBoxColumn,
            this.tAmountDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.transactionsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(117, 174);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(750, 447);
            this.dataGridView1.TabIndex = 14;
            // 
            // tIDDataGridViewTextBoxColumn
            // 
            this.tIDDataGridViewTextBoxColumn.DataPropertyName = "tID";
            this.tIDDataGridViewTextBoxColumn.HeaderText = "tID";
            this.tIDDataGridViewTextBoxColumn.Name = "tIDDataGridViewTextBoxColumn";
            // 
            // mID
            // 
            this.mID.DataPropertyName = "mID";
            this.mID.HeaderText = "mID";
            this.mID.Name = "mID";
            // 
            // tDateDataGridViewTextBoxColumn
            // 
            this.tDateDataGridViewTextBoxColumn.DataPropertyName = "tDate";
            this.tDateDataGridViewTextBoxColumn.HeaderText = "tDate";
            this.tDateDataGridViewTextBoxColumn.Name = "tDateDataGridViewTextBoxColumn";
            // 
            // tStartTimeDataGridViewTextBoxColumn
            // 
            this.tStartTimeDataGridViewTextBoxColumn.DataPropertyName = "tStartTime";
            this.tStartTimeDataGridViewTextBoxColumn.HeaderText = "tStartTime";
            this.tStartTimeDataGridViewTextBoxColumn.Name = "tStartTimeDataGridViewTextBoxColumn";
            // 
            // tDurationDataGridViewTextBoxColumn
            // 
            this.tDurationDataGridViewTextBoxColumn.DataPropertyName = "tDuration";
            this.tDurationDataGridViewTextBoxColumn.HeaderText = "tDuration";
            this.tDurationDataGridViewTextBoxColumn.Name = "tDurationDataGridViewTextBoxColumn";
            // 
            // tAmountDataGridViewTextBoxColumn
            // 
            this.tAmountDataGridViewTextBoxColumn.DataPropertyName = "tAmount";
            this.tAmountDataGridViewTextBoxColumn.HeaderText = "tAmount";
            this.tAmountDataGridViewTextBoxColumn.Name = "tAmountDataGridViewTextBoxColumn";
            // 
            // transactionsBindingSource
            // 
            this.transactionsBindingSource.DataMember = "Transactions";
            this.transactionsBindingSource.DataSource = this.gymnasiumDataSet6;
            // 
            // gymnasiumDataSet6
            // 
            this.gymnasiumDataSet6.DataSetName = "GymnasiumDataSet6";
            this.gymnasiumDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(229, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "To Date";
            // 
            // transactionsTableAdapter
            // 
            this.transactionsTableAdapter.ClearBeforeFill = true;
            // 
            // TransactionReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 682);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fromDate);
            this.Controls.Add(this.reservationReportLoadButton);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TransactionReportForm";
            this.Padding = new System.Windows.Forms.Padding(23, 74, 23, 25);
            this.Text = "TransactionReportForm";
            this.Load += new System.EventHandler(this.TransactionReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymnasiumDataSet6)).EndInit();
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
        private System.Windows.Forms.Label label3;
        private GymnasiumDataSet6 gymnasiumDataSet6;
        private System.Windows.Forms.BindingSource transactionsBindingSource;
        private GymnasiumDataSet6TableAdapters.TransactionsTableAdapter transactionsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tStartTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tDurationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tAmountDataGridViewTextBoxColumn;
    }
}