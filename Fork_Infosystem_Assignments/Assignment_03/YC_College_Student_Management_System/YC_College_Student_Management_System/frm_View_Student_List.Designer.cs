namespace YC_College_Student_Management_System
{
    partial class frm_View_Student_List
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
            this.lbl_View_Student_List = new System.Windows.Forms.Label();
            this.btn_Search_Student_List = new System.Windows.Forms.Button();
            this.dgv_View_Student_List = new System.Windows.Forms.DataGridView();
            this.rollNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yCStudentDetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._YC_College_Student_Managment_System_Database_dbDataSet2 = new YC_College_Student_Management_System._YC_College_Student_Managment_System_Database_dbDataSet2();
            this.yCStudentDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._YC_College_Student_Managment_System_Database_dbDataSet1 = new YC_College_Student_Management_System._YC_College_Student_Managment_System_Database_dbDataSet1();
            this.yCCollegeStudentManagmentSystemDatabasedbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._YC_College_Student_Managment_System_Database_dbDataSet = new YC_College_Student_Management_System._YC_College_Student_Managment_System_Database_dbDataSet();
            this.btn_Add_New_Student = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.yC_Student_DetailsTableAdapter = new YC_College_Student_Management_System._YC_College_Student_Managment_System_Database_dbDataSet1TableAdapters.YC_Student_DetailsTableAdapter();
            this.yC_Student_DetailsTableAdapter1 = new YC_College_Student_Management_System._YC_College_Student_Managment_System_Database_dbDataSet2TableAdapters.YC_Student_DetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Student_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yCStudentDetailsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._YC_College_Student_Managment_System_Database_dbDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yCStudentDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._YC_College_Student_Managment_System_Database_dbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yCCollegeStudentManagmentSystemDatabasedbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._YC_College_Student_Managment_System_Database_dbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_View_Student_List
            // 
            this.lbl_View_Student_List.AutoSize = true;
            this.lbl_View_Student_List.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_View_Student_List.Location = new System.Drawing.Point(322, 41);
            this.lbl_View_Student_List.Name = "lbl_View_Student_List";
            this.lbl_View_Student_List.Size = new System.Drawing.Size(388, 55);
            this.lbl_View_Student_List.TabIndex = 0;
            this.lbl_View_Student_List.Text = "View Student List";
            // 
            // btn_Search_Student_List
            // 
            this.btn_Search_Student_List.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_Search_Student_List.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search_Student_List.Location = new System.Drawing.Point(70, 622);
            this.btn_Search_Student_List.Name = "btn_Search_Student_List";
            this.btn_Search_Student_List.Size = new System.Drawing.Size(365, 64);
            this.btn_Search_Student_List.TabIndex = 2;
            this.btn_Search_Student_List.Text = "Search Student List";
            this.btn_Search_Student_List.UseVisualStyleBackColor = false;
            this.btn_Search_Student_List.Click += new System.EventHandler(this.btn_Search_Student_List_Click);
            // 
            // dgv_View_Student_List
            // 
            this.dgv_View_Student_List.AllowUserToAddRows = false;
            this.dgv_View_Student_List.AllowUserToDeleteRows = false;
            this.dgv_View_Student_List.AutoGenerateColumns = false;
            this.dgv_View_Student_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_View_Student_List.BackgroundColor = System.Drawing.Color.White;
            this.dgv_View_Student_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View_Student_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rollNODataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.mobileNoDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn});
            this.dgv_View_Student_List.DataSource = this.yCStudentDetailsBindingSource1;
            this.dgv_View_Student_List.Location = new System.Drawing.Point(12, 124);
            this.dgv_View_Student_List.Name = "dgv_View_Student_List";
            this.dgv_View_Student_List.ReadOnly = true;
            this.dgv_View_Student_List.RowTemplate.Height = 24;
            this.dgv_View_Student_List.Size = new System.Drawing.Size(1058, 474);
            this.dgv_View_Student_List.TabIndex = 1;
            // 
            // rollNODataGridViewTextBoxColumn
            // 
            this.rollNODataGridViewTextBoxColumn.DataPropertyName = "Roll_NO";
            this.rollNODataGridViewTextBoxColumn.HeaderText = "Roll_NO";
            this.rollNODataGridViewTextBoxColumn.Name = "rollNODataGridViewTextBoxColumn";
            this.rollNODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            this.dOBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobileNoDataGridViewTextBoxColumn
            // 
            this.mobileNoDataGridViewTextBoxColumn.DataPropertyName = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.HeaderText = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.Name = "mobileNoDataGridViewTextBoxColumn";
            this.mobileNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseDataGridViewTextBoxColumn
            // 
            this.courseDataGridViewTextBoxColumn.DataPropertyName = "Course";
            this.courseDataGridViewTextBoxColumn.HeaderText = "Course";
            this.courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
            this.courseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yCStudentDetailsBindingSource1
            // 
            this.yCStudentDetailsBindingSource1.DataMember = "YC_Student_Details";
            this.yCStudentDetailsBindingSource1.DataSource = this._YC_College_Student_Managment_System_Database_dbDataSet2;
            // 
            // _YC_College_Student_Managment_System_Database_dbDataSet2
            // 
            this._YC_College_Student_Managment_System_Database_dbDataSet2.DataSetName = "_YC_College_Student_Managment_System_Database_dbDataSet2";
            this._YC_College_Student_Managment_System_Database_dbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yCStudentDetailsBindingSource
            // 
            this.yCStudentDetailsBindingSource.DataMember = "YC_Student_Details";
            this.yCStudentDetailsBindingSource.DataSource = this._YC_College_Student_Managment_System_Database_dbDataSet1;
            // 
            // _YC_College_Student_Managment_System_Database_dbDataSet1
            // 
            this._YC_College_Student_Managment_System_Database_dbDataSet1.DataSetName = "_YC_College_Student_Managment_System_Database_dbDataSet1";
            this._YC_College_Student_Managment_System_Database_dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yCCollegeStudentManagmentSystemDatabasedbDataSetBindingSource
            // 
            this.yCCollegeStudentManagmentSystemDatabasedbDataSetBindingSource.DataSource = this._YC_College_Student_Managment_System_Database_dbDataSet;
            this.yCCollegeStudentManagmentSystemDatabasedbDataSetBindingSource.Position = 0;
            // 
            // _YC_College_Student_Managment_System_Database_dbDataSet
            // 
            this._YC_College_Student_Managment_System_Database_dbDataSet.DataSetName = "_YC_College_Student_Managment_System_Database_dbDataSet";
            this._YC_College_Student_Managment_System_Database_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_Add_New_Student
            // 
            this.btn_Add_New_Student.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_Add_New_Student.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_New_Student.Location = new System.Drawing.Point(608, 622);
            this.btn_Add_New_Student.Name = "btn_Add_New_Student";
            this.btn_Add_New_Student.Size = new System.Drawing.Size(354, 64);
            this.btn_Add_New_Student.TabIndex = 3;
            this.btn_Add_New_Student.Text = "Add New Student";
            this.btn_Add_New_Student.UseVisualStyleBackColor = false;
            this.btn_Add_New_Student.Click += new System.EventHandler(this.btn_Add_New_Student_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Logout.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.Location = new System.Drawing.Point(903, 12);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(167, 55);
            this.btn_Logout.TabIndex = 4;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Calibri", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.Location = new System.Drawing.Point(21, 12);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(146, 37);
            this.lbl_Username.TabIndex = 21;
            this.lbl_Username.Text = "Username";
            // 
            // yC_Student_DetailsTableAdapter
            // 
            this.yC_Student_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // yC_Student_DetailsTableAdapter1
            // 
            this.yC_Student_DetailsTableAdapter1.ClearBeforeFill = true;
            // 
            // frm_View_Student_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1082, 713);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.dgv_View_Student_List);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.btn_Add_New_Student);
            this.Controls.Add(this.btn_Search_Student_List);
            this.Controls.Add(this.lbl_View_Student_List);
            this.Name = "frm_View_Student_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_View_Student_List";
            this.Load += new System.EventHandler(this.frm_View_Student_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Student_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yCStudentDetailsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._YC_College_Student_Managment_System_Database_dbDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yCStudentDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._YC_College_Student_Managment_System_Database_dbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yCCollegeStudentManagmentSystemDatabasedbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._YC_College_Student_Managment_System_Database_dbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_View_Student_List;
        private System.Windows.Forms.Button btn_Search_Student_List;
        private System.Windows.Forms.DataGridView dgv_View_Student_List;
        private System.Windows.Forms.Button btn_Add_New_Student;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.BindingSource yCCollegeStudentManagmentSystemDatabasedbDataSetBindingSource;
        private _YC_College_Student_Managment_System_Database_dbDataSet _YC_College_Student_Managment_System_Database_dbDataSet;
        private System.Windows.Forms.Label lbl_Username;
        private _YC_College_Student_Managment_System_Database_dbDataSet1 _YC_College_Student_Managment_System_Database_dbDataSet1;
        private System.Windows.Forms.BindingSource yCStudentDetailsBindingSource;
        private _YC_College_Student_Managment_System_Database_dbDataSet1TableAdapters.YC_Student_DetailsTableAdapter yC_Student_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rollNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
        private _YC_College_Student_Managment_System_Database_dbDataSet2 _YC_College_Student_Managment_System_Database_dbDataSet2;
        private System.Windows.Forms.BindingSource yCStudentDetailsBindingSource1;
        private _YC_College_Student_Managment_System_Database_dbDataSet2TableAdapters.YC_Student_DetailsTableAdapter yC_Student_DetailsTableAdapter1;
    }
}