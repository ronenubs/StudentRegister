namespace StudentRegister
{
    partial class StudentInfo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgStudents = new System.Windows.Forms.DataGridView();
            this.colStudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFirstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMiddlename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.dgStudents);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(26, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 403);
            this.panel1.TabIndex = 0;
            // 
            // dgStudents
            // 
            this.dgStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStudentID,
            this.colFirstname,
            this.colMiddlename,
            this.colLastname,
            this.colAge,
            this.colAddress});
            this.dgStudents.Location = new System.Drawing.Point(3, 3);
            this.dgStudents.MultiSelect = false;
            this.dgStudents.Name = "dgStudents";
            this.dgStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgStudents.Size = new System.Drawing.Size(442, 150);
            this.dgStudents.TabIndex = 0;
            // 
            // colStudentID
            // 
            this.colStudentID.HeaderText = "ID";
            this.colStudentID.Name = "colStudentID";
            // 
            // colFirstname
            // 
            this.colFirstname.HeaderText = "Firstname";
            this.colFirstname.Name = "colFirstname";
            // 
            // colMiddlename
            // 
            this.colMiddlename.HeaderText = "Middlename";
            this.colMiddlename.Name = "colMiddlename";
            // 
            // colLastname
            // 
            this.colLastname.HeaderText = "Lastname";
            this.colLastname.Name = "colLastname";
            // 
            // colAge
            // 
            this.colAge.HeaderText = "Age";
            this.colAge.Name = "colAge";
            // 
            // colAddress
            // 
            this.colAddress.HeaderText = "Address";
            this.colAddress.Name = "colAddress";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(72, 199);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(174, 77);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // StudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 450);
            this.Controls.Add(this.panel1);
            this.Name = "StudentInfo";
            this.Text = "StudentInfo";
            this.Load += new System.EventHandler(this.StudentInfo_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMiddlename;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
        private System.Windows.Forms.Button btnDelete;
    }
}