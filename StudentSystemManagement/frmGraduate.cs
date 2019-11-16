using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace StudentSystemManagement
{
  
    public partial class frmGraduate : Form
    {
        public static string Sipha = ConfigurationManager.ConnectionStrings["Test"].ToString();
      
        SqlConnection sqlc = new SqlConnection(Sipha);
        public frmGraduate()
        {
           
            InitializeComponent();
            this.CenterToScreen();
            cbbox();
            dtaStudentsList.ForeColor = Color.Black;
          
        }
        public void cbbox()
        {
            cboGradePass.Items.Clear();
            sqlc.Open();
            string sql = "SELECT ClassName from  ClassName";
            SqlCommand sqc = new SqlCommand(sql, sqlc);
            sqc.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter sqd = new SqlDataAdapter(sqc);
            sqd.Fill(dta);
            foreach (DataRow dr in dta.Rows)
            {
                cboGradePass.Items.Add(dr["ClassName"].ToString());
            }
            sqlc.Close();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            frmGraduate frmst = new frmGraduate();
            Form1 frm1 = new Form1();
            frm1.Show();
            frmst.Hide();
        }
       
      
        void showData()
        {
           
            sqlc.Open();
            //string sql5 = "select StudentID, FirstName, LastName, ((Year1.Average+Year1Sem1.Average)/2) From Year1 INNER JOIN Year1Sem2 ON Year1.StudentID = Year1Sem2.StudentID Where Class ='"+cboyearPass.Text+"'";
            //string sql = "select StudentID, FirstName,LastName,Average,Grades,count(*) from Year1 where average > " + x + " and Grade = '" + cboGradePass.Text + "' group by FirstName,StudentID,LastName,Average,Grades";
            //string sql2 = "select StudentID, FirstName,LastName,Average,Grades,count(*) from Year2 where average > " + x + " and Grade = '" + cboGradePass.Text + "' group by FirstName,StudentID,LastName,Average,Grades";
            //string sql3 = "select StudentID, FirstName,LastName,Average,Grades,count(*) from Year3 where average > " + x + " and Grade = '" + cboGradePass.Text + "' group by FirstName,StudentID,LastName,Average,Grades";
            //string sq4 = "select StudentID, FirstName,LastName,Average,Grades,count(*) from Year1 where average > " + x + " and Grade = '" + cboGradePass.Text + "' group by FirstName,StudentID,LastName,Average,Grades";
            //string sql6 = "select  StudentID,LastName from Year1 Where Class ='"+cboGradePass.Text+"'";

       if (cboyearPass.Text == "Y1")
            {

                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "select Year1.StudentID, Year1.FirstName, Year1.LastName, ((Year1.Average+Year1Sem2.Average)/2.0) AS Average From Year1 INNER JOIN Year1Sem2 ON Year1.StudentID = Year1Sem2.StudentID Where Year1.Class ='" + cboGradePass.Text + "'";
                cmd.Connection = sqlc;
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable tb = new DataTable();
                tb.Load(reader);
                dtaStudentsList.DataSource = tb;

            }
            else if (cboyearPass.Text == "Y2")

            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "select Year2.StudentID, Year2.FirstName, Year2.LastName, ((Year2.Average+Year2Sem2.Average)/2.0) AS Average From Year2 INNER JOIN Year2Sem2 ON Year2.StudentID = Year2Sem2.StudentID Where Year2.Class ='" + cboGradePass.Text + "'";
                cmd.Connection = sqlc;
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable tb = new DataTable();
                tb.Load(reader);
                dtaStudentsList.DataSource = tb;
            }
            else if (cboyearPass.Text == "Y3")

            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "select Year3.StudentID, Year3.FirstName, Year3.LastName, ((Year3.Average+Year3Sem2.Average)/2.0) AS Average From Year3 INNER JOIN Year3Sem2 ON Year3.StudentID = Year3Sem2.StudentID Where Year3.Class ='" + cboGradePass.Text + "'";
                cmd.Connection = sqlc;
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable tb = new DataTable();
                tb.Load(reader);
                dtaStudentsList.DataSource = tb;
            }
            else if (cboyearPass.Text == "Y4")

            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "select Year4.StudentID, Year4.FirstName, Year4.LastName, ((Year4.Average+Year4Sem2.Average)/2.0) AS Average From Year4 INNER JOIN Year4Sem2 ON Year4.StudentID = Year4Sem2.StudentID Where Year4.Class ='" + cboGradePass.Text + "'";
                cmd.Connection = sqlc;
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable tb = new DataTable();
                tb.Load(reader);
                dtaStudentsList.DataSource = tb;
            }
           
            sqlc.Close();


        }
        private void cboGrade_SelectedIndexChanged(object sender, EventArgs e)
        {

            showData();

        }

      

        private void frmGraduate_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            frmMenu frm = new frmMenu();
            frm.ShowDialog();
           
            this.Close();
            dtaStudentsList.ForeColor = Color.Black;
        }

        private void frmGraduate_Load(object sender, EventArgs e)
        {

        }

        private void frmGraduate_Load_1(object sender, EventArgs e)
        {

        }
    }
}
