namespace StudentSystemManagement
{
    partial class Subject
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.cboSemester = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNamesun = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtaSubject2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtaSubject = new System.Windows.Forms.DataGridView();
            this.Subjects = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblbuttomTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaSubject2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtaSubject)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Bokor", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(85, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(343, 43);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "មុខវិជ្ជាដែលត្រូវសិក្សាសម្រាប់ឆ្នាំនីមួយៗ";
            // 
            // cboYear
            // 
            this.cboYear.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Items.AddRange(new object[] {
            "Year1",
            "Year2",
            "Year3",
            "Year4"});
            this.cboYear.Location = new System.Drawing.Point(202, 3);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(212, 28);
            this.cboYear.TabIndex = 1;
            // 
            // cboSemester
            // 
            this.cboSemester.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSemester.FormattingEnabled = true;
            this.cboSemester.Items.AddRange(new object[] {
            "Semester1",
            "Semester2"});
            this.cboSemester.Location = new System.Drawing.Point(202, 53);
            this.cboSemester.Name = "cboSemester";
            this.cboSemester.Size = new System.Drawing.Size(212, 28);
            this.cboSemester.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bokor", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-4, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "ឆ្នាំទី";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bokor", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-4, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 34);
            this.label3.TabIndex = 4;
            this.label3.Text = "ឆមាសទី";
            // 
            // lblNamesun
            // 
            this.lblNamesun.AutoSize = true;
            this.lblNamesun.Font = new System.Drawing.Font("Bokor", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamesun.Location = new System.Drawing.Point(-4, 89);
            this.lblNamesun.Name = "lblNamesun";
            this.lblNamesun.Size = new System.Drawing.Size(156, 34);
            this.lblNamesun.TabIndex = 5;
            this.lblNamesun.Text = "មុខវិជ្ជាដែលត្រូវបន្ថែម";
            // 
            // txtSubject
            // 
            this.txtSubject.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubject.Location = new System.Drawing.Point(202, 96);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(212, 27);
            this.txtSubject.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dtaSubject2);
            this.panel1.Controls.Add(this.cboYear);
            this.panel1.Controls.Add(this.dtaSubject);
            this.panel1.Controls.Add(this.txtSubject);
            this.panel1.Controls.Add(this.cboSemester);
            this.panel1.Controls.Add(this.lblNamesun);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(24, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 143);
            this.panel1.TabIndex = 7;
            // 
            // dtaSubject2
            // 
            this.dtaSubject2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaSubject2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dtaSubject2.Location = new System.Drawing.Point(5, 3);
            this.dtaSubject2.Name = "dtaSubject2";
            this.dtaSubject2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtaSubject2.Size = new System.Drawing.Size(416, 133);
            this.dtaSubject2.TabIndex = 10;
            this.dtaSubject2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dtaSubject2_MouseDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Semester2";
            this.dataGridViewTextBoxColumn1.HeaderText = "Subject";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 500;
            // 
            // dtaSubject
            // 
            this.dtaSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaSubject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Subjects});
            this.dtaSubject.Location = new System.Drawing.Point(2, 3);
            this.dtaSubject.Name = "dtaSubject";
            this.dtaSubject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtaSubject.Size = new System.Drawing.Size(421, 133);
            this.dtaSubject.TabIndex = 9;
            this.dtaSubject.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtaSubject_CellDoubleClick);
            this.dtaSubject.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dtaSubject_MouseDoubleClick);
            // 
            // Subjects
            // 
            this.Subjects.DataPropertyName = "Semester1";
            this.Subjects.HeaderText = "Subject";
            this.Subjects.Name = "Subjects";
            this.Subjects.Width = 500;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnInsert);
            this.panel2.Controls.Add(this.btnShow);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Location = new System.Drawing.Point(121, 250);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(331, 37);
            this.panel2.TabIndex = 8;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Bokor", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(244, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(79, 32);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "បោះបង់";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.lblCancel_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Bokor", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(3, 2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(79, 32);
            this.btnInsert.TabIndex = 3;
            this.btnInsert.Text = "បន្ថែម";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnShow
            // 
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Bokor", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(163, 2);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(79, 32);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "បង្ហាញ";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Bokor", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(83, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(79, 32);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "លុប";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.Controls.Add(this.lblTitle);
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(-1, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(524, 53);
            this.panel3.TabIndex = 9;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Red;
            this.panel4.Controls.Add(this.lblbuttomTitle);
            this.panel4.Location = new System.Drawing.Point(0, 349);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(524, 50);
            this.panel4.TabIndex = 10;
            // 
            // lblbuttomTitle
            // 
            this.lblbuttomTitle.AutoSize = true;
            this.lblbuttomTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblbuttomTitle.Location = new System.Drawing.Point(177, 19);
            this.lblbuttomTitle.Name = "lblbuttomTitle";
            this.lblbuttomTitle.Size = new System.Drawing.Size(171, 13);
            this.lblbuttomTitle.TabIndex = 15;
            this.lblbuttomTitle.Text = "2019 Group I. All Rights Reserved.";
            // 
            // Subject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.ControlBox = false;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(500, 400);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "Subject";
            this.Text = "Subject";
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Subject_MouseDoubleClick);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaSubject2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtaSubject)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.ComboBox cboSemester;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNamesun;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.DataGridView dtaSubject;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DataGridView dtaSubject2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subjects;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label lblbuttomTitle;
    }
}