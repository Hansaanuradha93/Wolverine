namespace Wolverine
{
    partial class MemberReportForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mBatchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mCourseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mStreetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mGenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mContactNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gymnasiumDataSet3 = new Wolverine.GymnasiumDataSet3();
            this.memberTableAdapter = new Wolverine.GymnasiumDataSet3TableAdapters.MemberTableAdapter();
            this.memberReportLoadButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymnasiumDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mIDDataGridViewTextBoxColumn,
            this.mFirstNameDataGridViewTextBoxColumn,
            this.mLastNameDataGridViewTextBoxColumn,
            this.mAgeDataGridViewTextBoxColumn,
            this.mBatchDataGridViewTextBoxColumn,
            this.mCourseNameDataGridViewTextBoxColumn,
            this.mStreetDataGridViewTextBoxColumn,
            this.mCityDataGridViewTextBoxColumn,
            this.mStateDataGridViewTextBoxColumn,
            this.mGenderDataGridViewTextBoxColumn,
            this.mContactNumberDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.memberBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(39, 97);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(868, 428);
            this.dataGridView1.TabIndex = 0;
            // 
            // mIDDataGridViewTextBoxColumn
            // 
            this.mIDDataGridViewTextBoxColumn.DataPropertyName = "mID";
            this.mIDDataGridViewTextBoxColumn.HeaderText = "mID";
            this.mIDDataGridViewTextBoxColumn.Name = "mIDDataGridViewTextBoxColumn";
            // 
            // mFirstNameDataGridViewTextBoxColumn
            // 
            this.mFirstNameDataGridViewTextBoxColumn.DataPropertyName = "mFirstName";
            this.mFirstNameDataGridViewTextBoxColumn.HeaderText = "mFirstName";
            this.mFirstNameDataGridViewTextBoxColumn.Name = "mFirstNameDataGridViewTextBoxColumn";
            // 
            // mLastNameDataGridViewTextBoxColumn
            // 
            this.mLastNameDataGridViewTextBoxColumn.DataPropertyName = "mLastName";
            this.mLastNameDataGridViewTextBoxColumn.HeaderText = "mLastName";
            this.mLastNameDataGridViewTextBoxColumn.Name = "mLastNameDataGridViewTextBoxColumn";
            // 
            // mAgeDataGridViewTextBoxColumn
            // 
            this.mAgeDataGridViewTextBoxColumn.DataPropertyName = "mAge";
            this.mAgeDataGridViewTextBoxColumn.HeaderText = "mAge";
            this.mAgeDataGridViewTextBoxColumn.Name = "mAgeDataGridViewTextBoxColumn";
            // 
            // mBatchDataGridViewTextBoxColumn
            // 
            this.mBatchDataGridViewTextBoxColumn.DataPropertyName = "mBatch";
            this.mBatchDataGridViewTextBoxColumn.HeaderText = "mBatch";
            this.mBatchDataGridViewTextBoxColumn.Name = "mBatchDataGridViewTextBoxColumn";
            // 
            // mCourseNameDataGridViewTextBoxColumn
            // 
            this.mCourseNameDataGridViewTextBoxColumn.DataPropertyName = "mCourseName";
            this.mCourseNameDataGridViewTextBoxColumn.HeaderText = "mCourseName";
            this.mCourseNameDataGridViewTextBoxColumn.Name = "mCourseNameDataGridViewTextBoxColumn";
            // 
            // mStreetDataGridViewTextBoxColumn
            // 
            this.mStreetDataGridViewTextBoxColumn.DataPropertyName = "mStreet";
            this.mStreetDataGridViewTextBoxColumn.HeaderText = "mStreet";
            this.mStreetDataGridViewTextBoxColumn.Name = "mStreetDataGridViewTextBoxColumn";
            // 
            // mCityDataGridViewTextBoxColumn
            // 
            this.mCityDataGridViewTextBoxColumn.DataPropertyName = "mCity";
            this.mCityDataGridViewTextBoxColumn.HeaderText = "mCity";
            this.mCityDataGridViewTextBoxColumn.Name = "mCityDataGridViewTextBoxColumn";
            // 
            // mStateDataGridViewTextBoxColumn
            // 
            this.mStateDataGridViewTextBoxColumn.DataPropertyName = "mState";
            this.mStateDataGridViewTextBoxColumn.HeaderText = "mState";
            this.mStateDataGridViewTextBoxColumn.Name = "mStateDataGridViewTextBoxColumn";
            // 
            // mGenderDataGridViewTextBoxColumn
            // 
            this.mGenderDataGridViewTextBoxColumn.DataPropertyName = "mGender";
            this.mGenderDataGridViewTextBoxColumn.HeaderText = "mGender";
            this.mGenderDataGridViewTextBoxColumn.Name = "mGenderDataGridViewTextBoxColumn";
            // 
            // mContactNumberDataGridViewTextBoxColumn
            // 
            this.mContactNumberDataGridViewTextBoxColumn.DataPropertyName = "mContactNumber";
            this.mContactNumberDataGridViewTextBoxColumn.HeaderText = "mContactNumber";
            this.mContactNumberDataGridViewTextBoxColumn.Name = "mContactNumberDataGridViewTextBoxColumn";
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataMember = "Member";
            this.memberBindingSource.DataSource = this.gymnasiumDataSet3;
            // 
            // gymnasiumDataSet3
            // 
            this.gymnasiumDataSet3.DataSetName = "GymnasiumDataSet3";
            this.gymnasiumDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // memberTableAdapter
            // 
            this.memberTableAdapter.ClearBeforeFill = true;
            // 
            // memberReportLoadButton
            // 
            this.memberReportLoadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memberReportLoadButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberReportLoadButton.Location = new System.Drawing.Point(747, 52);
            this.memberReportLoadButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.memberReportLoadButton.Name = "memberReportLoadButton";
            this.memberReportLoadButton.Size = new System.Drawing.Size(160, 28);
            this.memberReportLoadButton.TabIndex = 1;
            this.memberReportLoadButton.Text = "Load";
            this.memberReportLoadButton.UseVisualStyleBackColor = true;
            this.memberReportLoadButton.Click += new System.EventHandler(this.memberReportLoadButton_Click);
            // 
            // MemberReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.memberReportLoadButton);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MemberReportForm";
            this.Padding = new System.Windows.Forms.Padding(23, 74, 23, 25);
            this.Text = "Member Report";
            this.Load += new System.EventHandler(this.MemberReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymnasiumDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private GymnasiumDataSet3 gymnasiumDataSet3;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private GymnasiumDataSet3TableAdapters.MemberTableAdapter memberTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mBatchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mCourseNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mStreetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mStateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mGenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mContactNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button memberReportLoadButton;
    }
}