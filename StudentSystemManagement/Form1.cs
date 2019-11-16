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
    public partial class Form1 : Form
    {
        public static string Sipha = ConfigurationManager.ConnectionStrings["Test"].ToString();
        public Form1()
        {
            InitializeComponent();
            ShowData();
            lblID.Hide();
            txtID.Hide();
            cboSearch.Hide();
            txtSearch.Hide();
            dtaStudents.Hide();
            btnRemove.Enabled = false;
            btnUpdate.Enabled = false;
            btnBAck.Enabled = false;
            tmrrandom.Start();
            cbbox();




        }
        public void cbbox()
        {
            cboGrade.Items.Clear();
            sqlc.Open();
            string sql = "SELECT ClassName from  ClassName";
            SqlCommand sqc = new SqlCommand(sql, sqlc);
            sqc.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter sqd = new SqlDataAdapter(sqc);
            sqd.Fill(dta);
            foreach (DataRow dr in dta.Rows)
            {
                cboGrade.Items.Add(dr["ClassName"].ToString());
            }
            sqlc.Close();
        }
        string getfilephoto;
        SqlConnection sqlc = new SqlConnection(Sipha);
       
        void ShowData()
        {
          sqlc.Open();

            string sqlcmm = "SELECT * FROM Students";
            SqlDataAdapter sqda = new SqlDataAdapter(sqlcmm, sqlc);
            DataTable dt = new DataTable();
            sqda.Fill(dt);
            dtaStudents.AutoGenerateColumns = false;
            dtaStudents.DataSource = dt;
            sqlc.Close();

        }
        void clear()
        {
            txtID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            cboSex.Text = "";
            cboYear.Text = "";
            cboGrade.Text = "";
            openFileDialog.FileName = "";
            pctStudents.ImageLocation = openFileDialog.FileName;
        }
        int c=0;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try { 


            if (txtFirstName.Text != "" && txtLastName.Text != "" && cboSex.Text != "" && cboYear.Text != "" && cboYear.Text != "" && dateBirthStudent.Text != "")
            {
                txtID.Hide();
                txtID.Hide();
                sqlc.Open();

                //  int id = Convert.ToInt32(txtID.Text);
                string firstname = txtFirstName.Text;
                string lastName = txtLastName.Text;
                string sex = cboSex.Text;
                string datebirth = dateBirthStudent.Text;
                string grade = cboGrade.Text;
                string year = cboYear.Text;
                string photo = openFileDialog.FileName;
                string sqlcm = "INSERT INTO Students VALUES ('" + firstname + "','" + lastName + "','" + sex + "','" + datebirth + "','" + grade + "','" + year + "','" + photo + "') ";
                SqlCommand sqlcmm = new SqlCommand(sqlcm, sqlc);
                sqlcmm.ExecuteNonQuery();
                sqlc.Close();
                ShowData();
                sqlc.Open();

                for (int i = 0; i < dtaStudents.Rows.Count; ++i)
                {
                    c = i - 1;
                }

                if (cboYear.Text == "Y1")
                {

                    string sql = "INSERT INTO Year1 (FirstName,LastName,StudentID,Class) values('" + dtaStudents.Rows[c].Cells[1].Value + "','" + dtaStudents.Rows[c].Cells[2].Value + "'," + dtaStudents.Rows[c].Cells[0].Value + ",'" + dtaStudents.Rows[c].Cells[5].Value + "')  ";
                    string sql2 = "INSERT INTO Year1Sem2 (FirstName,LastName,StudentID,Class) values('" + dtaStudents.Rows[c].Cells[1].Value + "','" + dtaStudents.Rows[c].Cells[2].Value + "'," + dtaStudents.Rows[c].Cells[0].Value + ",'" + dtaStudents.Rows[c].Cells[5].Value + "')  ";
                    SqlCommand sqcmm = new SqlCommand(sql, sqlc);
                    SqlCommand sqlcmm2 = new SqlCommand(sql2, sqlc);
                    sqlcmm2.ExecuteNonQuery();
                    sqcmm.ExecuteNonQuery();


                }
                if (cboYear.Text == "Y2")
                {
                    string sql = "INSERT INTO Year2 (FirstName,LastName,StudentID,Class) values('" + dtaStudents.Rows[c].Cells[1].Value + "','" + dtaStudents.Rows[c].Cells[2].Value + "'," + dtaStudents.Rows[c].Cells[0].Value + ",'" + dtaStudents.Rows[c].Cells[5].Value + "')  ";
                    string sql2 = "INSERT INTO Year2Sem2 (FirstName,LastName,StudentID,Class) values('" + dtaStudents.Rows[c].Cells[1].Value + "','" + dtaStudents.Rows[c].Cells[2].Value + "'," + dtaStudents.Rows[c].Cells[0].Value + ",'" + dtaStudents.Rows[c].Cells[5].Value + "')  ";
                    SqlCommand sqcmm = new SqlCommand(sql, sqlc);
                    SqlCommand sqcmm2 = new SqlCommand(sql2, sqlc);
                    sqcmm2.ExecuteNonQuery();
                    sqcmm.ExecuteNonQuery();

                }
                if (cboYear.Text == "Y3")
                {
                    string sql = "INSERT INTO Year3 (FirstName,LastName,StudentID,Class) values('" + dtaStudents.Rows[c].Cells[1].Value + "','" + dtaStudents.Rows[c].Cells[2].Value + "'," + dtaStudents.Rows[c].Cells[0].Value + ",'" + dtaStudents.Rows[c].Cells[5].Value + "')  ";
                    string sql2 = "INSERT INTO Year3Sem2 (FirstName,LastName,StudentID,Class) values('" + dtaStudents.Rows[c].Cells[1].Value + "','" + dtaStudents.Rows[c].Cells[2].Value + "'," + dtaStudents.Rows[c].Cells[0].Value + ",'" + dtaStudents.Rows[c].Cells[5].Value + "')  ";
                    SqlCommand sqcmm = new SqlCommand(sql, sqlc);
                    SqlCommand sqcmm2 = new SqlCommand(sql2, sqlc);
                    sqcmm.ExecuteNonQuery();
                    sqcmm2.ExecuteNonQuery();

                }
                if (cboYear.Text == "Y4")
                {
                    string sql = "INSERT INTO Year4 (FirstName,LastName,StudentID,Class) values('" + dtaStudents.Rows[c].Cells[1].Value + "','" + dtaStudents.Rows[c].Cells[2].Value + "'," + dtaStudents.Rows[c].Cells[0].Value + ",'" + dtaStudents.Rows[c].Cells[5].Value + "')  ";
                    string sql2 = "INSERT INTO Year4Sem2 (FirstName,LastName,StudentID,Class) values('" + dtaStudents.Rows[c].Cells[1].Value + "','" + dtaStudents.Rows[c].Cells[2].Value + "'," + dtaStudents.Rows[c].Cells[0].Value + ",'" + dtaStudents.Rows[c].Cells[5].Value + "')  ";
                    SqlCommand sqcmm = new SqlCommand(sql, sqlc);
                    sqcmm.ExecuteNonQuery();
                    SqlCommand sqcmm2 = new SqlCommand(sql2, sqlc);
                    sqcmm2.ExecuteNonQuery();

                }


               
                MessageBox.Show("Add successfully !", "Message");

                getfilephoto = "";
            }
            else
                MessageBox.Show("Not enough information", "Mesage");

        } catch(Exception)
            {
                sqlc.Close();
            }

            sqlc.Close();
        }


      

        private void btnRemove_Click(object sender, EventArgs e)
        {
             try
            {
            int id = Convert.ToInt32(txtID.Text);
            sqlc.Open();
            string sql = "DELETE FROM Students WHERE StudentID="+id+"";
            SqlCommand sqlcmm = new SqlCommand(sql, sqlc);
            sqlcmm.ExecuteNonQuery();
            sqlc.Close();
            ShowData();
            txtID.Hide();
            lblID.Hide();
                clear();
                btnUpdate.Enabled = false;
                btnRemove.Enabled = false;
                MessageBox.Show("Delete Success", "Message");
            }
            catch
            {
                sqlc.Close();
            }
            sqlc.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                sqlc.Open();
                int id = Convert.ToInt32(txtID.Text);
                string firstname = txtFirstName.Text;
                string lastName = txtLastName.Text;
                string sex = cboSex.Text;
                string datebirth = dateBirthStudent.Text;
                string grade = cboGrade.Text;
                string year = cboYear.Text;
                string photo = pctStudents.ImageLocation;
                string sql = "UPDATE Students SET FirstName='" + firstname + "',LastName='" + lastName + "'," +
                    "       Sex='" + sex + "',DateBirth='" + datebirth + "',Class='" + grade + "',Year='" + year + "',photo='" + photo + "' WHERE StudentID=" + id + "";
                SqlCommand sqlcmm = new SqlCommand(sql, sqlc);
                sqlcmm.ExecuteNonQuery();
                if (cboYear.Text == "Y1")
                {

                    string sqlup = "UPDATE Year1 SET FirstName = '" + firstname + "',LastName = '" + lastName + "',Class='" + grade + "' WHERE StudentID = " + id + "";
                    SqlCommand sqlcmmup = new SqlCommand(sqlup, sqlc);
                    sqlcmmup.ExecuteNonQuery();
                    string sqlup2 = "UPDATE Year1Sem2 SET FirstName = '" + firstname + "',LastName = '" + lastName + "',Class='" + grade + "' WHERE StudentID = " + id + "";
                    SqlCommand sqlcmmup2 = new SqlCommand(sqlup2, sqlc);
                    sqlcmmup2.ExecuteNonQuery();
                }
                if (cboYear.Text == "Y2")
                {

                    string sqlup = "UPDATE Year2 SET FirstName = '" + firstname + "',LastName = '" + lastName + "',Class='" + grade + "'  WHERE StudentID = " + id + "";
                    SqlCommand sqlcmmup = new SqlCommand(sqlup, sqlc);
                    sqlcmmup.ExecuteNonQuery();
                    string sqlup2 = "UPDATE Year2Sem2 SET FirstName = '" + firstname + "',LastName = '" + lastName + "',Class='" + grade + "'  WHERE StudentID = " + id + "";
                    SqlCommand sqlcmmup2 = new SqlCommand(sqlup2, sqlc);
                    sqlcmmup2.ExecuteNonQuery();
                }
                if (cboYear.Text == "Y3")
                {

                    string sqlup = "UPDATE Year3 SET FirstName = '" + firstname + "',LastName = '" + lastName + "',Class='" + grade + "'  WHERE StudentID = " + id + "";
                    SqlCommand sqlcmmup = new SqlCommand(sqlup, sqlc);
                    sqlcmmup.ExecuteNonQuery();
                    string sqlup2 = "UPDATE Year3Sem2 SET FirstName = '" + firstname + "',LastName = '" + lastName + "',Class='" + grade + "'  WHERE StudentID = " + id + "";
                    SqlCommand sqlcmmup2 = new SqlCommand(sqlup2, sqlc);
                    sqlcmmup2.ExecuteNonQuery();
                }
                if (cboYear.Text == "Y4")
                {

                    string sqlup = "UPDATE Year4 SET FirstName = '" + firstname + "',LastName = '" + lastName + "',Class='" + grade + "'  WHERE StudentID = " + id + "";
                    SqlCommand sqlcmmup = new SqlCommand(sqlup, sqlc);
                    sqlcmmup.ExecuteNonQuery();
                    string sqlup2 = "UPDATE Year4Sem2 SET FirstName = '" + firstname + "',LastName = '" + lastName + "',Class='" + grade + "'  WHERE StudentID = " + id + "";
                    SqlCommand sqlcmmup2 = new SqlCommand(sqlup2, sqlc);
                    sqlcmmup2.ExecuteNonQuery();
                }
                sqlc.Close();
                ShowData();
                txtID.Hide();
                lblID.Hide();
                btnRemove.Enabled = false;
                btnUpdate.Enabled = false;
                MessageBox.Show("Update Succes", "Message");
            }
            catch(Exception)
            {
                sqlc.Close();
            }

            sqlc.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
            dtaStudents.Hide();
        }

      
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ContextMenu context = new ContextMenu();
            context.MenuItems.Add("Show");
        }
        

      

        private void button1_Click(object sender, EventArgs e)
        {
            //FrmResultStudents frmst = new FrmResultStudents();
            //frmst.Show();
            //ShowData();
            txtSearch.Show();
            cboSearch.Show();
            dtaStudents.Show();
            btnBAck.Enabled = true;
            btnRemove.Enabled = false;
            btnUpdate.Enabled = false;
            

          
           
            
        }

       /* private void dtaStudents_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
       
           // lblID.Show();
           // txtID.Show();
           // txtID.Text = dtaStudents.SelectedRows[0].Cells[0].Value.ToString();
           // txtFirstName.Text = dtaStudents.SelectedRows[0].Cells[1].Value.ToString();
           // txtLastName.Text = dtaStudents.SelectedRows[0].Cells[2].Value.ToString();
           // cboSex.Text = dtaStudents.SelectedRows[0].Cells[3].Value.ToString();
           // dateBirthStudent.Text = dtaStudents.SelectedRows[0].Cells[4].Value.ToString();
           // cboGrade.Text = dtaStudents.SelectedRows[0].Cells[5].Value.ToString();
           // cboYear.Text = dtaStudents.SelectedRows[0].Cells[6].Value.ToString();
           // dtaStudents.Hide();
           // txtSearch.Hide();
           //cboSearch.Hide();
           // btnUpdate.Enabled = true;
           // btnRemove.Enabled = true;
        }
        */
        private void lblBack_Click(object sender, EventArgs e)
        {
            dtaStudents.Hide();
            txtSearch.Hide();
            cboSearch.Hide();
           
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            sqlc.Open();
            try
            {
               
                if (cboSearch.Text == "NAME")
                {

                    string sql = "SELECT * FROM Students WHERE FirstName LIKE '%" + txtSearch.Text + "%'";
                    SqlCommand sqlcmm = new SqlCommand(sql, sqlc);
                    sqlcmm.ExecuteNonQuery();
                    SqlDataAdapter sqda = new SqlDataAdapter(sql, sqlc);
                    DataTable dt = new DataTable();
                    sqda.Fill(dt);
                    dtaStudents.AutoGenerateColumns = false;
                    dtaStudents.DataSource = dt;
                }
                else
                    if (cboSearch.Text == "ID")
                {
                    string sql = "SELECT * FROM Students WHERE StudentID =" + txtSearch.Text + "";
                    SqlCommand sqlcmm = new SqlCommand(sql, sqlc);
                    sqlcmm.ExecuteNonQuery();
                    SqlDataAdapter sqda = new SqlDataAdapter(sql, sqlc);
                    DataTable dt = new DataTable();
                    sqda.Fill(dt);
                    dtaStudents.AutoGenerateColumns = false;
                    dtaStudents.DataSource = dt;
                }
               
            }
            catch (Exception )
            {
               

            }
            sqlc.Close();

        }

        private void btnBrowse_Click_1(object sender, EventArgs e)
        {
            lblPhoto.Hide();
            openFileDialog.Filter = "All FILE|*.*|Image File|*.jpg|*.bmp|*.png";
            openFileDialog.ShowDialog();
            pctStudents.SizeMode = PictureBoxSizeMode.StretchImage;
            pctStudents.ImageLocation = openFileDialog.FileName;
            getfilephoto = openFileDialog.FileName;
        }

       
        void colorRgb()
        {
            Random rd = new Random();
            int R = rd.Next(0, 255);
            int A = rd.Next(0, 255);
            int G = rd.Next(0, 255);
            int B = rd.Next(0, 255);
            btnClear.ForeColor = Color.FromArgb(A, R, G, B);
            btnAdd.ForeColor = Color.FromArgb(R, A, G, B);
            btnRemove.ForeColor = Color.FromArgb(G, B, R, A);
            btnUpdate.ForeColor = Color.FromArgb(R, B, G, A);
            lblsubtilte.ForeColor = Color.FromArgb(B, R, G, A);
            lblTitle.ForeColor = Color.FromArgb(G, A, R, B);
            btnBAck.ForeColor = Color.FromArgb(B, R, G, A);
            btnBAck.ForeColor = Color.FromArgb(B, R, G, A);
           
            panel1.ForeColor = Color.FromArgb(B, R, G, A);
            btnBrowse.ForeColor = Color.FromArgb(B, R, G, A);


        }
      

        private void tmrrandom_Tick(object sender, EventArgs e)
        {
            
            colorRgb();

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
           
            Form1 frm1 = new Form1();
            frm1.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
           
           
            frmGraduate frmg = new frmGraduate();
            frmg.Close();
            frmGraduate frm = new frmGraduate();
            frm.Close();
            this.Close();
           
        }

        private void pictureBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            frmGraduate frmg = new frmGraduate();
            frmg.Show();
            this.Hide();
        }

        private void pictureBox3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
          
           
            Form1 frm1 = new Form1();
            frm1.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmGraduate frmg = new frmGraduate();
            frmg.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           
          
            this.Hide();
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            frmLogin frm = new frmLogin();
           
            frmGraduate frmg = new frmGraduate();
            frm.ShowDialog();
           
            frmg.Close();
            this.Close();
           
        }

        private void dtaStudents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            lblID.Show();
            txtID.Show();
            txtID.Text = dtaStudents.SelectedRows[0].Cells[0].Value.ToString();
            txtFirstName.Text = dtaStudents.SelectedRows[0].Cells[1].Value.ToString();
            txtLastName.Text = dtaStudents.SelectedRows[0].Cells[2].Value.ToString();
            cboSex.Text = dtaStudents.SelectedRows[0].Cells[3].Value.ToString();
            dateBirthStudent.Text = dtaStudents.SelectedRows[0].Cells[4].Value.ToString();
            cboGrade.Text = dtaStudents.SelectedRows[0].Cells[5].Value.ToString();
            cboYear.Text = dtaStudents.SelectedRows[0].Cells[6].Value.ToString();
            dtaStudents.Hide();
            txtSearch.Hide();
            cboSearch.Hide();
            btnUpdate.Enabled = true;
            btnRemove.Enabled = true;
        }

        private void Form1_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            this.Hide();
            frmMenu frm = new frmMenu();
            frm.ShowDialog();
            this.Close();
        }
    }
}
