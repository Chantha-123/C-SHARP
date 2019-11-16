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
    public partial class Subject : Form
    {
        public static string Sipha = ConfigurationManager.ConnectionStrings["Test"].ToString();

        SqlConnection sqlc = new SqlConnection(Sipha);
        public Subject()
        {
            InitializeComponent();
            this.CenterToScreen();
            btnCancel.Enabled = false;
            dtaSubject.Hide();
            dtaSubject2.Hide();
            dtaSubject.ForeColor = Color.Black;
            dtaSubject2.ForeColor = Color.Black;

        }
        void clear()
        {
            txtSubject.Clear();
            cboYear.Text = "";
            cboSemester.Text = "";
        }
        void show()
        {

            sqlc.Open();
            if (cboYear.Text == "Year1")
            {
                if (cboSemester.Text == "Semester1")
                {
                    dtaSubject.Show();
                    dtaSubject2.Hide();
                    string sql = "SELECT Semester1 FROM SubYear1 WHERE Semester1 IS NOT NULL";
                    DataTable dtat = new DataTable();
                    SqlDataAdapter dta = new SqlDataAdapter(sql, sqlc);
                    dta.Fill(dtat);
                    dtaSubject.AutoGenerateColumns = false;
                    dtaSubject.DataSource = dtat;

                }
                else
                if (cboSemester.Text == "Semester2")
                {
                    dtaSubject2.Show();
                    dtaSubject.Hide();
                    string sql = "SELECT Semester2 FROM SubYear1 WHERE Semester2 IS NOT NULL";
                    DataTable dtat = new DataTable();
                    SqlDataAdapter dta = new SqlDataAdapter(sql, sqlc);
                    dta.Fill(dtat);
                    dtaSubject2.AutoGenerateColumns = false;
                    dtaSubject2.DataSource = dtat;
                }
            }
            else if (cboYear.Text == "Year2")
            {
                if (cboSemester.Text == "Semester1")
                {
                    dtaSubject.Show();
                    dtaSubject2.Hide();
                    string sql = "SELECT Semester1 FROM SubYear2 WHERE Semester1 IS NOT NULL";
                    DataTable dtat = new DataTable();
                    SqlDataAdapter dta = new SqlDataAdapter(sql, sqlc);
                    dta.Fill(dtat);
                    dtaSubject.AutoGenerateColumns = false;
                    dtaSubject.DataSource = dtat;
                }
                else
                if (cboSemester.Text == "Semester2")
                {
                    dtaSubject2.Show();
                    dtaSubject.Hide();
                    string sql = "SELECT Semester2 FROM SubYear2 WHERE Semester2 IS NOT NULL";
                    DataTable dtat = new DataTable();
                    SqlDataAdapter dta = new SqlDataAdapter(sql, sqlc);
                    dta.Fill(dtat);
                    dtaSubject2.AutoGenerateColumns = false;
                    dtaSubject2.DataSource = dtat;
                }
            }
            if (cboYear.Text == "Year3")
            {
                if (cboSemester.Text == "Semester1")
                {
                    dtaSubject.Show();
                    dtaSubject2.Hide();
                    string sql = "SELECT Semester1 FROM SubYear3 WHERE Semester1 IS NOT NULL";
                    DataTable dtat = new DataTable();
                    SqlDataAdapter dta = new SqlDataAdapter(sql, sqlc);
                    dta.Fill(dtat);
                    dtaSubject.AutoGenerateColumns = false;
                    dtaSubject.DataSource = dtat;
                }
                else
                if (cboSemester.Text == "Semester2")
                {
                    dtaSubject2.Show();
                    dtaSubject.Hide();
                    string sql = "SELECT Semester2 FROM SubYear3 WHERE Semester2 IS NOT NULL";
                    DataTable dtat = new DataTable();
                    SqlDataAdapter dta = new SqlDataAdapter(sql, sqlc);
                    dta.Fill(dtat);
                    dtaSubject2.AutoGenerateColumns = false;
                    dtaSubject2.DataSource = dtat;
                }
            }
            if (cboYear.Text == "Year4")
            {
                if (cboSemester.Text == "Semester1")
                {
                    dtaSubject.Show();
                    dtaSubject2.Hide();
                    string sql = "SELECT Semester1 FROM SubYear4 WHERE Semester1 IS NOT NULL";
                    DataTable dtat = new DataTable();
                    SqlDataAdapter dta = new SqlDataAdapter(sql, sqlc);
                    dta.Fill(dtat);
                    dtaSubject.AutoGenerateColumns = false;
                    dtaSubject.DataSource = dtat;
                }
                else
                if (cboSemester.Text == "Semester2")
                {
                    dtaSubject2.Show();
                    dtaSubject.Hide();
                    string sql = "SELECT Semester2 FROM SubYear4 WHERE Semester2 IS NOT NULL";
                    DataTable dtat = new DataTable();
                    SqlDataAdapter dta = new SqlDataAdapter(sql, sqlc);
                    dta.Fill(dtat);
                    dtaSubject2.AutoGenerateColumns = false;
                    dtaSubject2.DataSource = dtat;
                }

            }
            sqlc.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try {
          
            sqlc.Open();
                string nametable = txtSubject.Text;
           if(cboYear.Text=="Year1")
            {
                if(cboSemester.Text=="Semester1")
                {
                    String sql = "INSERT INTO SubYear1 (Semester1) VALUES('" +txtSubject.Text + "')";
                    String sqlAlt = "ALTER TABLE Year1 ADD "+txtSubject.Text.ToString()+" FLOAT ";
                    SqlCommand sqlcmmalt = new SqlCommand(sqlAlt, sqlc);
                    sqlcmmalt.ExecuteNonQuery();
                    SqlCommand sqlcmm = new SqlCommand(sql, sqlc);
                    sqlcmm.ExecuteNonQuery();
                    sqlc.Close();

                }
                else
                    if(cboSemester.Text=="Semester2")
                {
                    String sql = "INSERT INTO SubYear1 (Semester2) VALUES('" +txtSubject.Text + "')";
                    SqlCommand sqlcmm = new SqlCommand(sql, sqlc);
                    String sqlAlt = "ALTER TABLE Year1Sem2 ADD " + txtSubject.Text.ToString() + " FLOAT ";
                    SqlCommand sqlcmmalt = new SqlCommand(sqlAlt, sqlc);
                    sqlcmmalt.ExecuteNonQuery();
                    sqlcmm.ExecuteNonQuery();
                }
                MessageBox.Show("Adding Successful", "Message");
            }

            if (cboYear.Text == "Year2")
            {
                if (cboSemester.Text == "Semester1")
                {
                    String sql = "INSERT INTO SubYear2 (Semester1) VALUES('" + txtSubject.Text + "')";
                    SqlCommand sqlcmm = new SqlCommand(sql, sqlc);
                    String sqlAlt = "ALTER TABLE Year2 ADD " + txtSubject.Text.ToString() + " FLOAT ";
                    SqlCommand sqlcmmalt = new SqlCommand(sqlAlt, sqlc);
                    sqlcmmalt.ExecuteNonQuery();
                    sqlcmm.ExecuteNonQuery();
                }
                else
                    if (cboSemester.Text == "Semester2")
                {
                    String sql = "INSERT INTO SubYear2 (Semester2) VALUES('" + txtSubject.Text + "')";
                    SqlCommand sqlcmm = new SqlCommand(sql, sqlc);
                    String sqlAlt = "ALTER TABLE Year2Sem2 ADD " + txtSubject.Text.ToString() + " FLOAT ";
                    SqlCommand sqlcmmalt = new SqlCommand(sqlAlt, sqlc);
                    sqlcmmalt.ExecuteNonQuery();
                    sqlcmm.ExecuteNonQuery();
                }
                MessageBox.Show("Adding Successful", "Message");
            }

            if (cboYear.Text == "Year3")
            {
                if (cboSemester.Text == "Semester1")
                {
                    String sql = "INSERT INTO SubYear3 (Semester1) VALUES('" + txtSubject.Text + "')";
                    SqlCommand sqlcmm = new SqlCommand(sql, sqlc);
                    String sqlAlt = "ALTER TABLE Year3 ADD " + txtSubject.Text.ToString() + " FLOAT ";
                    SqlCommand sqlcmmalt = new SqlCommand(sqlAlt, sqlc);
                    sqlcmmalt.ExecuteNonQuery();
                    sqlcmm.ExecuteNonQuery();
                }
                else
                    if (cboSemester.Text == "Semester2")
                {
                    String sql = "INSERT INTO SubYear3 (Semester2) VALUES('" + txtSubject.Text + "')";
                    SqlCommand sqlcmm = new SqlCommand(sql, sqlc);
                    String sqlAlt = "ALTER TABLE Year3Sem2 ADD " + txtSubject.Text.ToString() + " FLOAT ";
                    SqlCommand sqlcmmalt = new SqlCommand(sqlAlt, sqlc);
                    sqlcmmalt.ExecuteNonQuery();
                    sqlcmm.ExecuteNonQuery();
                }
                MessageBox.Show("Adding Successful", "Message");
            }

            if (cboYear.Text == "Year4")
            {
                if (cboSemester.Text == "Semester1")
                {
                    String sql = "INSERT INTO SubYear4 (Semester1) VALUES('" + txtSubject.Text + "')";
                    SqlCommand sqlcmm = new SqlCommand(sql, sqlc);
                    String sqlAlt = "ALTER TABLE Year4 ADD " + txtSubject.Text.ToString() + " FLOAT ";
                    SqlCommand sqlcmmalt = new SqlCommand(sqlAlt, sqlc);
                    sqlcmmalt.ExecuteNonQuery();
                    sqlcmm.ExecuteNonQuery();
                }
                else
                    if (cboSemester.Text == "Semester2")
                {
                    String sql = "INSERT INTO SubYear4 (Semester2) VALUES('" + txtSubject.Text+ "')";
                    SqlCommand sqlcmm = new SqlCommand(sql, sqlc);
                    String sqlAlt = "ALTER TABLE Year4Sem2 ADD " + txtSubject.Text.ToString() + " FLOAT ";
                    SqlCommand sqlcmmalt = new SqlCommand(sqlAlt, sqlc);
                    sqlcmmalt.ExecuteNonQuery();
                    sqlcmm.ExecuteNonQuery();
                }
                MessageBox.Show("Adding Successful", "Message");
            }
            else
                if(txtSubject.Text==""|cboYear.Text==""|cboSemester.Text=="")
            MessageBox.Show("Not enough  information","Message");


            }

           
            catch(Exception)
            {
                MessageBox.Show("The Subject has in list.", "Message");
                sqlc.Close();
            }


            sqlc.Close();
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            sqlc.Open();
            if (cboYear.Text == "Year1")
            {
                if (cboSemester.Text == "Semester1")
                {
                    String sqldel = "DELETE  FROM SubYear1 WHERE Semester1='" + txtSubject.Text + "'";
                    String attd = "ALTER TABLE Year1 DROP COLUMN " + txtSubject.Text.ToString() + "";
                    SqlCommand sqld = new SqlCommand(attd, sqlc);
                    sqld.ExecuteNonQuery();
                    SqlCommand sqlcmm = new SqlCommand(sqldel, sqlc);
                    sqlcmm.ExecuteNonQuery();
                }
                if (cboSemester.Text == "Semester2")
                {
                    String sqldel = "DELETE  FROM SubYear1 WHERE Semester2='" + txtSubject.Text + "'";
                    SqlCommand sqlcmm = new SqlCommand(sqldel, sqlc);
                    String attd = "ALTER TABLE Year1Sem2 DROP COLUMN " + txtSubject.Text.ToString() + "";
                    SqlCommand sqld = new SqlCommand(attd, sqlc);
                    sqld.ExecuteNonQuery();
                    sqlcmm.ExecuteNonQuery();
                }
            }
            if (cboYear.Text == "Year2")
            {
                if (cboSemester.Text == "Semester1")
                {
                    String sqldel = "DELETE  FROM SubYear2 WHERE Semester1='" + txtSubject.Text + "'";
                    SqlCommand sqlcmm = new SqlCommand(sqldel, sqlc);
                    String attd = "ALTER TABLE Year2 DROP COLUMN " + txtSubject.Text.ToString() + "";
                    SqlCommand sqld = new SqlCommand(attd, sqlc);
                    sqld.ExecuteNonQuery();
                    sqlcmm.ExecuteNonQuery();
                }
                if (cboSemester.Text == "Semester2")
                {
                    String sqldel = "DELETE  FROM SubYear2 WHERE Semester2='" + txtSubject.Text + "'";
                    SqlCommand sqlcmm = new SqlCommand(sqldel, sqlc);
                    String attd = "ALTER TABLE Year2Sem2 DROP COLUMN " + txtSubject.Text.ToString() + "";
                    SqlCommand sqld = new SqlCommand(attd, sqlc);
                    sqld.ExecuteNonQuery();
                    sqlcmm.ExecuteNonQuery();
                }
            }
            if (cboYear.Text == "Year3")
            {
                if (cboSemester.Text == "Semester1")
                {
                    String sqldel = "DELETE  FROM SubYear3 WHERE Semester1='" + txtSubject.Text + "'";
                    SqlCommand sqlcmm = new SqlCommand(sqldel, sqlc);
                    String attd = "ALTER TABLE Year3 DROP COLUMN " + txtSubject.Text.ToString() + "";
                    SqlCommand sqld = new SqlCommand(attd, sqlc);
                    sqld.ExecuteNonQuery();
                    sqlcmm.ExecuteNonQuery();
                }
                if (cboSemester.Text == "Semester2")
                {
                    String sqldel = "DELETE  FROM SubYear3 WHERE Semester2='" + txtSubject.Text + "'";
                    SqlCommand sqlcmm = new SqlCommand(sqldel, sqlc);
                    String attd = "ALTER TABLE Year3Sem2 DROP COLUMN " + txtSubject.Text.ToString() + "";
                    SqlCommand sqld = new SqlCommand(attd, sqlc);
                    sqld.ExecuteNonQuery();
                    sqlcmm.ExecuteNonQuery();
                }
            }
            if (cboYear.Text == "Year4")
            {
                if (cboSemester.Text == "Semester1")
                {
                    String sqldel = "DELETE  FROM SubYear4 WHERE Semester1='" + txtSubject.Text + "'";
                    SqlCommand sqlcmm = new SqlCommand(sqldel, sqlc);
                    String attd = "ALTER TABLE Year4 DROP COLUMN " + txtSubject.Text.ToString() + "";
                    SqlCommand sqld = new SqlCommand(attd, sqlc);
                    sqld.ExecuteNonQuery();
                    sqlcmm.ExecuteNonQuery();
                }
                if (cboSemester.Text == "Semester2")
                {
                    String sqldel = "DELETE  FROM SubYear4 WHERE Semester2='" + txtSubject.Text + "'";
                    SqlCommand sqlcmm = new SqlCommand(sqldel, sqlc);
                    String attd = "ALTER TABLE Year4Sem2 DROP COLUMN " + txtSubject.Text.ToString() + "";
                    SqlCommand sqld = new SqlCommand(attd, sqlc);
                    sqld.ExecuteNonQuery();
                    sqlcmm.ExecuteNonQuery();

                }
            }

            MessageBox.Show("The subject deleted", "Message");
            clear();
            btnCancel.Enabled = false;
            sqlc.Close();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            show();
            btnCancel.Enabled = true;
        }

        private void dtaSubject_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtSubject.Text = dtaSubject.SelectedRows[0].Cells[0].Value.ToString();
            lblNamesun.Text = "មុខវិជ្ជាដែលត្រូវលុប";
            dtaSubject2.Hide();
            dtaSubject.Hide();
        }

        private void dtaSubject2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtSubject.Text = dtaSubject2.SelectedRows[0].Cells[0].Value.ToString();
            lblNamesun.Text = "មុខវិជ្ជាដែលត្រូវលុប";
            dtaSubject.Hide();
            dtaSubject2.Hide();
        }

        private void lblCancel_Click(object sender, EventArgs e)
        {
            lblNamesun.Text = "មុខវិជ្ជាដែលត្រូវបន្ថែម";
            clear();
            dtaSubject.Hide();
            dtaSubject2.Hide();
            btnCancel.Enabled = false;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtaSubject_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSubject.Text = dtaSubject.SelectedRows[0].Cells[0].Value.ToString();
            lblNamesun.Text = "មុខវិជ្ជាដែលត្រូវលុប";
            dtaSubject2.Hide();
            dtaSubject.Hide();
        }

        private void dtaSubject2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSubject.Text = dtaSubject2.SelectedRows[0].Cells[0].Value.ToString();
            lblNamesun.Text = "មុខវិជ្ជាដែលត្រូវលុប";
            dtaSubject.Hide();
            dtaSubject2.Hide();
        }

        private void Subject_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            this.Close();
            frmMenu frm = new frmMenu();
            frm.ShowDialog();
           
        }
    }
}
