namespace StudentSystemManagement
{
    partial class frmGraduate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGraduate));
            this.dtaStudentsList = new System.Windows.Forms.DataGridView();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.llblTitle = new System.Windows.Forms.Label();
            this.cboyearPass = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.cboGradePass = new System.Windows.Forms.ComboBox();
            this.lblGrade = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblbuttomTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblseeyou = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblTitleNote = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtaStudentsList)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtaStudentsList
            // 
            this.dtaStudentsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaStudentsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentID,
            this.FirstName,
            this.LastName,
            this.Sex});
            resources.ApplyResources(this.dtaStudentsList, "dtaStudentsList");
            this.dtaStudentsList.Name = "dtaStudentsList";
            // 
            // StudentID
            // 
            this.StudentID.DataPropertyName = "StudentID";
            resources.ApplyResources(this.StudentID, "StudentID");
            this.StudentID.Name = "StudentID";
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            resources.ApplyResources(this.FirstName, "FirstName");
            this.FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            resources.ApplyResources(this.LastName, "LastName");
            this.LastName.Name = "LastName";
            // 
            // Sex
            // 
            this.Sex.DataPropertyName = "Average";
            resources.ApplyResources(this.Sex, "Sex");
            this.Sex.Name = "Sex";
            // 
            // llblTitle
            // 
            resources.ApplyResources(this.llblTitle, "llblTitle");
            this.llblTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.llblTitle.Name = "llblTitle";
            // 
            // cboyearPass
            // 
            this.cboyearPass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cboyearPass, "cboyearPass");
            this.cboyearPass.FormattingEnabled = true;
            this.cboyearPass.Items.AddRange(new object[] {
            resources.GetString("cboyearPass.Items"),
            resources.GetString("cboyearPass.Items1"),
            resources.GetString("cboyearPass.Items2"),
            resources.GetString("cboyearPass.Items3")});
            this.cboyearPass.Name = "cboyearPass";
            // 
            // lblYear
            // 
            resources.ApplyResources(this.lblYear, "lblYear");
            this.lblYear.Name = "lblYear";
            // 
            // cboGradePass
            // 
            this.cboGradePass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cboGradePass, "cboGradePass");
            this.cboGradePass.FormattingEnabled = true;
            this.cboGradePass.Name = "cboGradePass";
            this.cboGradePass.SelectedIndexChanged += new System.EventHandler(this.cboGrade_SelectedIndexChanged);
            // 
            // lblGrade
            // 
            resources.ApplyResources(this.lblGrade, "lblGrade");
            this.lblGrade.Name = "lblGrade";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.lblbuttomTitle);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // lblbuttomTitle
            // 
            resources.ApplyResources(this.lblbuttomTitle, "lblbuttomTitle");
            this.lblbuttomTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblbuttomTitle.Name = "lblbuttomTitle";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Controls.Add(this.llblTitle);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // lblseeyou
            // 
            resources.ApplyResources(this.lblseeyou, "lblseeyou");
            this.lblseeyou.Name = "lblseeyou";
            // 
            // lblNote
            // 
            resources.ApplyResources(this.lblNote, "lblNote");
            this.lblNote.Name = "lblNote";
            // 
            // lblTitleNote
            // 
            resources.ApplyResources(this.lblTitleNote, "lblTitleNote");
            this.lblTitleNote.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleNote.Name = "lblTitleNote";
            // 
            // frmGraduate
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::StudentSystemManagement.Properties.Resources.photo_2019_10_26_09_10_421;
            this.Controls.Add(this.lblTitleNote);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.lblseeyou);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cboyearPass);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.cboGradePass);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.dtaStudentsList);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGraduate";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGraduate_Load_1);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.frmGraduate_MouseDoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.dtaStudentsList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtaStudentsList;
        private System.Windows.Forms.Label llblTitle;
        private System.Windows.Forms.ComboBox cboyearPass;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ComboBox cboGradePass;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblseeyou;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblTitleNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.Label lblbuttomTitle;
    }
}