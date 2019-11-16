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

namespace StudentSystemManagement
{
    public partial class frmScore : Form
    {
        SqlConnection sqlc = new SqlConnection(frmGraduate.Sipha);

        public int a = 0;
        float scoreUpdate = 0;
        public frmScore()
        {
            InitializeComponent();
            lblSubject.Enabled = false;
            btnnext.Enabled = false;
            btnEnter.Enabled = false;
            btnRefresh.Enabled = false;
           
            dtacountsub.Hide();
            btnUpdate.Enabled = false;
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
        int c;
        string[] n = new string[30];

        void getyear()
        {
            SqlCommand cmd = new SqlCommand();

            if (cboYear.Text == "Y1" && cboSemester.SelectedIndex == 0)
            {
                cmd.CommandText = "Select * From Year1 Where Class = '" + cboGrade.Text + "'";
                cmd.Connection = sqlc;
                sqlc.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable tb = new DataTable();
                tb.Load(reader);
                dtaScore.DataSource = tb;
                sqlc.Close();
            }
            else
            if (cboYear.Text == "Y1" && cboSemester.SelectedIndex == 1)
            {
                cmd.CommandText = "Select * From Year1Sem2 Where Class = '" + cboGrade.Text + "'";
                cmd.Connection = sqlc;
                sqlc.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable tb = new DataTable();
                tb.Load(reader);
                dtaScore.DataSource = tb;
                sqlc.Close();

            }
            else if (cboYear.Text == "Y2" && cboSemester.SelectedIndex == 0)
            {
                cmd.CommandText = "Select * From Year2 Where Class = '" + cboGrade.Text + "'";
                cmd.Connection = sqlc;
                sqlc.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable tb = new DataTable();
                tb.Load(reader);
                dtaScore.DataSource = tb;
                sqlc.Close();

            }
            else
                if (cboYear.Text == "Y2" && cboSemester.SelectedIndex == 1)
            {
                cmd.CommandText = "Select * From Year2Sem2 Where Class = '" + cboGrade.Text + "'";
                cmd.Connection = sqlc;
                sqlc.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable tb = new DataTable();
                tb.Load(reader);
                dtaScore.DataSource = tb;
                sqlc.Close();

            }
            else if (cboYear.Text == "Y3" && cboSemester.SelectedIndex == 0)
            {
                cmd.CommandText = "Select * From Year3 Where Class = '" + cboGrade.Text + "'";
                cmd.Connection = sqlc;
                sqlc.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable tb = new DataTable();
                tb.Load(reader);
                dtaScore.DataSource = tb;

                sqlc.Close();
            }
            else
                if (cboYear.Text == "Y3" && cboSemester.SelectedIndex == 1)
            {
                cmd.CommandText = "Select * From Year3Sem2 Where Class = '" + cboGrade.Text + "'";
                cmd.Connection = sqlc;
                sqlc.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable tb = new DataTable();
                tb.Load(reader);
                dtaScore.DataSource = tb;

                sqlc.Close();
            }
            else if (cboYear.Text == "Y4" && cboSemester.SelectedIndex == 0)
            {
                cmd.CommandText = "Select * From Year4 Where Class = '" + cboGrade.Text + "'";
                cmd.Connection = sqlc;
                sqlc.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable tb = new DataTable();
                tb.Load(reader);
                dtaScore.DataSource = tb;

                sqlc.Close();
            }
            else
                if (cboYear.Text == "Y4" && cboSemester.SelectedIndex == 1)
            {
                cmd.CommandText = "Select * From Year4Sem2 Where Class = '" + cboGrade.Text + "'";
                cmd.Connection = sqlc;
                sqlc.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable tb = new DataTable();
                tb.Load(reader);
                dtaScore.DataSource = tb;
                sqlc.Close();
            }
        }
      

        private void dtaScore_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate.Enabled = true;
            lblSubject.Enabled = true;
            btnEnter.Enabled = true;
            btnRefresh.Enabled = true;
            sum = 0;
            Avg = 0;
            g = ' ';
            txtFirstName.Text= dtaScore.SelectedRows[0].Cells[0].Value.ToString();
            txtLastName.Text= dtaScore.SelectedRows[0].Cells[1].Value.ToString();
            txtID.Text = dtaScore.SelectedRows[0].Cells[2].Value.ToString();
            txtTotalScore.Text = dtaScore.SelectedRows[0].Cells[3].Value.ToString();
            txtAvg.Text = dtaScore.SelectedRows[0].Cells[4].Value.ToString();
            txtGrade.Text = dtaScore.SelectedRows[0].Cells[5].Value.ToString();
            for (int i = 7; i < dtaScore.Columns.Count; ++i)
            {

                n[i] = dtaScore.Columns[i].HeaderText;
                c = i;
                lblSubject.Text = n[i];
                if(dtaScore.SelectedRows[0].Cells[i].Value.ToString()=="")
                {
                    dtaScore.SelectedRows[0].Cells[i].Value = 0;
                }
                else
                {
                    txtsub.Text = dtaScore.SelectedRows[0].Cells[i].Value.ToString();

                    scoreUpdate = float.Parse(txtsub.Text);
                  //  MessageBox.Show(scoreUpdate.ToString());
                }
              
            }
        }


        float sum = 0;
        float Avg = 0;
        char g ;
        void showresulut()
        {
            if (txtsub.Text != "")
            {
                sum = sum + Convert.ToInt32(txtsub.Text);
                Avg = sum / (dtaScore.ColumnCount - 7);
                if (Avg < 50)
                    g = 'F';
                else if (Avg < 65)
                    g = 'E';
                else if (Avg < 75)
                    g = 'D';
                else if (Avg < 85)
                    g = 'C';
                else if (Avg < 95)
                    g = 'B';
                else
                    g = 'A';
            }
        }
        private void btnnext_Click(object sender, EventArgs e)
        {
            try
            {
                txtsub.Focus();
                btnEnter.Enabled = true;
                sqlc.Open();
                if (c == 7)
                {
                    lblSubject.Name = "Score";
                    MessageBox.Show("end of subject Please Click Refresh");
                    btnEnter.Enabled = false;
                    for (int i = 7; i < dtaScore.Columns.Count; ++i)
                    {
                        c = i;
                    }
                    btnnext.Enabled = false;

                }
                lblSubject.Text = n[--c];
                btnnext.Enabled = false;
            }
            
            catch (Exception)
            {
                sqlc.Close();
            }

            sqlc.Close();

        }
        

        private void btnget_Click(object sender, EventArgs e)
        {
            try
            {
                getyear();
                sqlc.Open();
                if (cboYear.Text == "Y1" && cboSemester.SelectedIndex == 0)
                {
                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandText = "Select Semester1 From SubYear1  where Semester1 Is not Null ";
                    cmd.Connection = sqlc;
                  
                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable tb = new DataTable();
                    tb.Load(reader);
                    dtacountsub.DataSource = tb;
                  

                    for (int i = 7; i < dtaScore.Columns.Count; ++i)
                    {
                        n[i] = dtaScore.Columns[i].HeaderText;
                        c = i;
                        lblSubject.Text = n[i];

                    }
                }
                else if (cboYear.Text == "Y1" && cboSemester.SelectedIndex == 1)
                {
                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandText = "Select Semester2 From SubYear1  where Semester2 Is not Null ";
                    cmd.Connection = sqlc;
                 
                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable tb = new DataTable();
                    tb.Load(reader);
                    dtacountsub.DataSource = tb;

                   
                    for (int i = 7; i < dtaScore.Columns.Count; ++i)
                    {
                        n[i] = dtaScore.Columns[i].HeaderText;
                        c = i;
                        lblSubject.Text = n[i];

                    }

                }
                else if (cboYear.Text == "Y2" && cboSemester.SelectedIndex == 0)
                {
                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandText = "Select Semester1 From SubYear2  where Semester1 Is not Null ";
                    cmd.Connection = sqlc;
                  
                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable tb = new DataTable();
                    tb.Load(reader);
                    dtacountsub.DataSource = tb;

                
                    for (int i = 7; i < dtaScore.Columns.Count; ++i)
                    {
                        n[i] = dtaScore.Columns[i].HeaderText;
                        c = i;
                        lblSubject.Text = n[i];

                    }
                }
                else if (cboYear.Text == "Y2" && cboSemester.SelectedIndex == 1)
                {
                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandText = "Select Semester2 From SubYear3  where Semester2 Is not Null ";
                    cmd.Connection = sqlc;
                  
                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable tb = new DataTable();
                    tb.Load(reader);
                    dtacountsub.DataSource = tb;

                 
                    for (int i = 7; i < dtaScore.Columns.Count; ++i)
                    {
                        n[i] = dtaScore.Columns[i].HeaderText;
                        c = i;
                        lblSubject.Text = n[i];

                    }

                }
                else if (cboYear.Text == "Y3" && cboSemester.SelectedIndex == 0)
                {
                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandText = "Select Semester1 From SubYear3  where Semester1 Is not Null ";
                    cmd.Connection = sqlc;
                 
                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable tb = new DataTable();
                    tb.Load(reader);
                    dtacountsub.DataSource = tb;
                  

                    for (int i = 7; i < dtaScore.Columns.Count; ++i)
                    {
                        n[i] = dtaScore.Columns[i].HeaderText;
                        c = i;
                        lblSubject.Text = n[i];

                    }
                }
                else if (cboYear.Text == "Y3" && cboSemester.SelectedIndex == 1)
                {
                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandText = "Select Semester2 From SubYear3  where Semester2 Is not Null ";
                    cmd.Connection = sqlc;
                
                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable tb = new DataTable();
                    tb.Load(reader);
                    dtacountsub.DataSource = tb;
                  

                    for (int i = 7; i < dtaScore.Columns.Count; ++i)
                    {
                        n[i] = dtaScore.Columns[i].HeaderText;
                        c = i;
                        lblSubject.Text = n[i];

                    }

                }
                else if (cboYear.Text == "Y4" && cboSemester.SelectedIndex == 0)
                {
                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandText = "Select Semester1 From SubYear4  where Semester1 Is not Null ";
                    cmd.Connection = sqlc;
                 
                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable tb = new DataTable();
                    tb.Load(reader);
                    dtacountsub.DataSource = tb;
                 

                    for (int i = 7; i < dtaScore.Columns.Count; ++i)
                    {
                        n[i] = dtaScore.Columns[i].HeaderText;
                        c = i;
                        lblSubject.Text = n[i];

                    }
                }
                else if (cboYear.Text == "Y4" && cboSemester.SelectedIndex == 1)
                {
                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandText = "Select Semester2 From SubYear4  where Semester2 Is not Null ";
                    cmd.Connection = sqlc;
                  
                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable tb = new DataTable();
                    tb.Load(reader);
                    dtacountsub.DataSource = tb;

                   
                    for (int i = 7; i < dtaScore.Columns.Count; ++i)
                    {
                        n[i] = dtaScore.Columns[i].HeaderText;
                        c = i;
                        lblSubject.Text = n[i];

                    }

                }
            } catch(Exception)
            {
                sqlc.Close();
            }
            sqlc.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // showresulut();
            btnget_Click(sender, e);
          
            txtAvg.Text = Avg.ToString();
            txtTotalScore.Text = sum.ToString();
            txtGrade.Text = g.ToString();

            try
            {
                //   MessageBox.Show(sum.ToString());


                sqlc.Open();
                if (cboYear.Text == "Y1" && cboSemester.Text == "Semester1")
                {
                    string sql = "UPDATE Year1 SET Total=" + txtTotalScore.Text + ",Average=" + txtAvg.Text + ",Grades='" + txtGrade.Text + "' WHERE StudentID=" + txtID.Text + "";
                    SqlCommand sqlcmm = new SqlCommand(sql, sqlc);
                    sqlcmm.ExecuteNonQuery();


                }
                else if (cboYear.Text == "Y1" && cboSemester.Text == "Semester2")
                {
                    string sql = "UPDATE Year1Sem2 SET Total=" + txtTotalScore.Text + ",Average=" + txtAvg.Text + ",Grades='" + txtGrade.Text + "' WHERE StudentID=" + txtID.Text + "";
                    SqlCommand sqlcmm = new SqlCommand(sql, sqlc);
                    sqlcmm.ExecuteNonQuery();


                }
                else if (cboYear.Text == "Y2" && cboSemester.Text == "Semester1")
                {

                    string sql = "UPDATE Year2 SET Total=" + txtTotalScore.Text + ",Average=" + txtAvg.Text + ",Grades='" + txtGrade.Text + "' WHERE StudentID=" + txtID.Text + "";
                    SqlCommand sqlcmm = new SqlCommand(sql, sqlc);
                    sqlcmm.ExecuteNonQuery();


                }
                else if (cboYear.Text == "Y2" && cboSemester.Text == "Semester2")
                {
                    string sql = "UPDATE Year2Sem2 SET Total=" + txtTotalScore.Text + ",Average=" + txtAvg.Text + ",Grades='" + txtGrade.Text + "' WHERE StudentID=" + txtID.Text + "";
                    SqlCommand sqlcmm = new SqlCommand(sql, sqlc);
                    sqlcmm.ExecuteNonQuery();


                }
                else if (cboYear.Text == "Y3" && cboSemester.Text == "Semester1")
                {

                    string sql = "UPDATE Year3 SET Total=" + txtTotalScore.Text + ",Average=" + txtAvg.Text + ",Grades='" + txtGrade.Text + "' WHERE StudentID=" + txtID.Text + "";
                    SqlCommand sqlcmm = new SqlCommand(sql, sqlc);
                    sqlcmm.ExecuteNonQuery();


                }
                else if (cboYear.Text == "Y3" && cboSemester.Text == "Semester2")
                {
                    string sql = "UPDATE Year3Sem2 SET Total=" + txtTotalScore.Text + ",Average=" + txtAvg.Text + ",Grades='" + txtGrade.Text + "' WHERE StudentID=" + txtID.Text + "";
                    SqlCommand sqlcmm = new SqlCommand(sql, sqlc);
                    sqlcmm.ExecuteNonQuery();


                }
                if (cboYear.Text == "Y4" && cboSemester.Text == "Semester1")
                {

                    string sql = "UPDATE Year4 SET Total=" + txtTotalScore.Text + ",Average=" + txtAvg.Text + ",Grades='" + txtGrade.Text + "' WHERE StudentID=" + txtID.Text + "";
                    SqlCommand sqlcmm = new SqlCommand(sql, sqlc);
                    sqlcmm.ExecuteNonQuery();


                }
                else if (cboYear.Text == "Y4" && cboSemester.Text == "Semester2")
                {
                    string sql = "UPDATE Year4Sem2 SET Total=" + txtTotalScore.Text + ",Average=" + txtAvg.Text + ",Grades='" + txtGrade.Text + "' WHERE StudentID=" + txtID.Text + "";
                    SqlCommand sqlcmm = new SqlCommand(sql, sqlc);
                    sqlcmm.ExecuteNonQuery();

                }

                btnEnter.Enabled = false;
                btnnext.Enabled = true;
                txtsub.Clear();
                sqlc.Close();
                btnget_Click(sender, e);



            }catch(Exception)
            {
                sqlc.Close();
            }
            
        }

        private void cboSemester_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {

                sqlc.Open();

                if (cboYear.Text == "Y1" && cboSemester.Text == "Semester1")
                {
                    string sql = "UPDATE Year1 SET " + lblSubject.Text.ToString() + "=" + txtsub.Text + " WHERE StudentID=" + txtID.Text + "";
                    SqlCommand sqlcmm = new SqlCommand(sql, sqlc);
                    sqlcmm.ExecuteNonQuery();
                    showresulut();

                }
                else if (cboYear.Text == "Y1" && cboSemester.Text == "Semester2")
                {
                    string sql = "UPDATE Year1Sem2 SET " + lblSubject.Text.ToString() + "=" + txtsub.Text + " WHERE StudentID=" + txtID.Text + "";
                    SqlCommand sqlcmm = new SqlCommand(sql, sqlc);
                    sqlcmm.ExecuteNonQuery();

                    showresulut();
                }
                else if (cboYear.Text == "Y2" && cboSemester.Text == "Semester1")
                {

                    string sql = "UPDATE Year2 SET " + lblSubject.Text.ToString() + "=" + txtsub.Text + " WHERE StudentID=" + txtID.Text + "";
                    SqlCommand sqlcmm = new SqlCommand(sql, sqlc);
                    sqlcmm.ExecuteNonQuery();

                    showresulut();
                }
                else if (cboYear.Text == "Y2" && cboSemester.Text == "Semester2")
                {
                    string sql = "UPDATE Year2Sem2 SET " + lblSubject.Text.ToString() + "=" + txtsub.Text + " WHERE StudentID=" + txtID.Text + "";
                    SqlCommand sqlcmm = new SqlCommand(sql, sqlc);
                    sqlcmm.ExecuteNonQuery();

                    showresulut();
                }
                else if (cboYear.Text == "Y3" && cboSemester.Text == "Semester1")
                {

                    string sql = "UPDATE Year3 SET " + lblSubject.Text.ToString() + "=" + txtsub.Text + " WHERE StudentID=" + txtID.Text + "";
                    SqlCommand sqlcmm = new SqlCommand(sql, sqlc);
                    sqlcmm.ExecuteNonQuery();

                    showresulut();
                }
                else if (cboYear.Text == "Y3" && cboSemester.Text == "Semester2")
                {
                    string sql = "UPDATE Year3Sem2 SET " + lblSubject.Text.ToString() + "=" + txtsub.Text + " WHERE StudentID=" + txtID.Text + "";
                    SqlCommand sqlcmm = new SqlCommand(sql, sqlc);
                    sqlcmm.ExecuteNonQuery();

                    showresulut();
                }
                if (cboYear.Text == "Y4" && cboSemester.Text == "Semester1")
                {

                    string sql = "UPDATE Year4 SET " + lblSubject.Text.ToString() + "=" + txtsub.Text + " WHERE StudentID=" + txtID.Text + "";
                    SqlCommand sqlcmm = new SqlCommand(sql, sqlc);
                    sqlcmm.ExecuteNonQuery();

                    showresulut();
                }
                else if (cboYear.Text == "Y4" && cboSemester.Text == "Semester2")
                {
                    string sql = "UPDATE Year4Sem2 SET " + lblSubject.Text.ToString() + "=" + txtsub.Text + " WHERE StudentID=" + txtID.Text + "";
                    SqlCommand sqlcmm = new SqlCommand(sql, sqlc);
                    sqlcmm.ExecuteNonQuery();
                    showresulut();
                }
                btnEnter.Enabled = false;
                btnnext.Enabled = true;
            }catch(Exception)
            {
                sqlc.Close();
            }
               sqlc.Close();
        }
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            float a;
           
            float total = float.Parse(txtTotalScore.Text);
            a = total - scoreUpdate;
            sum = a;
            showresulut();
            //   MessageBox.Show(sum.ToString());
            txtTotalScore.Text = sum.ToString();
            try
            {
                sqlc.Open();
              

                if (cboYear.Text == "Y1" && cboSemester.Text == "Semester1")
                {
                    string sql = "UPDATE Year1 SET " + lblSubject.Text.ToString() + "=" + txtsub.Text + " WHERE StudentID=" + txtID.Text + "";
                    SqlCommand sqlcmm = new SqlCommand(sql, sqlc);
                    sqlcmm.ExecuteNonQuery();
                    // showresulut();

                }
                else if (cboYear.Text == "Y1" && cboSemester.Text == "Semester2")
                {
                    string sql = "UPDATE Year1Sem2 SET " + lblSubject.Text.ToString() + "=" + txtsub.Text + " WHERE StudentID=" + txtID.Text + "";
                    SqlCommand sqlcmm = new SqlCommand(sql, sqlc);
                    sqlcmm.ExecuteNonQuery();

                    //  showresulut();
                }
                else if (cboYear.Text == "Y2" && cboSemester.Text == "Semester1")
                {

                    string sql = "UPDATE Year2 SET " + lblSubject.Text.ToString() + "=" + txtsub.Text + " WHERE StudentID=" + txtID.Text + "";
                    SqlCommand sqlcmm = new SqlCommand(sql, sqlc);
                    sqlcmm.ExecuteNonQuery();

                    //   showresulut();
                }
                else if (cboYear.Text == "Y2" && cboSemester.Text == "Semester2")
                {
                    string sql = "UPDATE Year2Sem2 SET " + lblSubject.Text.ToString() + "=" + txtsub.Text + " WHERE StudentID=" + txtID.Text + "";
                    SqlCommand sqlcmm = new SqlCommand(sql, sqlc);
                    sqlcmm.ExecuteNonQuery();

                    //   showresulut();
                }
                else if (cboYear.Text == "Y3" && cboSemester.Text == "Semester1")
                {

                    string sql = "UPDATE Year3 SET " + lblSubject.Text.ToString() + "=" + txtsub.Text + " WHERE StudentID=" + txtID.Text + "";
                    SqlCommand sqlcmm = new SqlCommand(sql, sqlc);
                    sqlcmm.ExecuteNonQuery();

                    //   showresulut();
                }
                else if (cboYear.Text == "Y3" && cboSemester.Text == "Semester2")
                {
                    string sql = "UPDATE Year3Sem2 SET " + lblSubject.Text.ToString() + "=" + txtsub.Text + " WHERE StudentID=" + txtID.Text + "";
                    SqlCommand sqlcmm = new SqlCommand(sql, sqlc);
                    sqlcmm.ExecuteNonQuery();

                    //  showresulut();
                }
                if (cboYear.Text == "Y4" && cboSemester.Text == "Semester1")
                {

                    string sql = "UPDATE Year4 SET " + lblSubject.Text.ToString() + "=" + txtsub.Text + " WHERE StudentID=" + txtID.Text + "";
                    SqlCommand sqlcmm = new SqlCommand(sql, sqlc);
                    sqlcmm.ExecuteNonQuery();

                    //   showresulut();
                }
                else if (cboYear.Text == "Y4" && cboSemester.Text == "Semester2")
                {
                    string sql = "UPDATE Year4Sem2 SET " + lblSubject.Text.ToString() + "=" + txtsub.Text + " WHERE StudentID=" + txtID.Text + "";
                    SqlCommand sqlcmm = new SqlCommand(sql, sqlc);
                    sqlcmm.ExecuteNonQuery();
                    //  showresulut();
                }

                MessageBox.Show("Update Success Please Click Refresh", "Message");
                btnEnter.Enabled = false;
                btnnext.Enabled = true;
                txtsub.Clear();
            }
            catch (Exception) { sqlc.Close(); }
            
            sqlc.Close();
        }

        private void btnChooseSub_Click(object sender, EventArgs e)
        {
            try
            {
                btnnext.Enabled = false;
                btnget.Enabled = false;
                btnEnter.Enabled = false;
                sqlc.Open();
                if (c == 7)
                {
                    lblSubject.Name = "Score";
                 //   MessageBox.Show("end of subject");
                    btnEnter.Enabled = false;
                    for (int i = 7; i < dtaScore.Columns.Count; ++i)
                    {
                        c = i;
                        lblSubject.Text = n[c];
                    }
                    btnnext.Enabled = false;

                }
                lblSubject.Text = n[--c];

                txtsub.Text = dtaScore.SelectedRows[0].Cells[c].Value.ToString();
                scoreUpdate = float.Parse(txtsub.Text);
             //   MessageBox.Show(scoreUpdate.ToString());
                btnEnter.Enabled = true;
            }
            catch(Exception)
            {
                sqlc.Close();
            }
            sqlc.Close();
        }

        private void frmScore_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            frmMenu frm = new frmMenu();
            frm.ShowDialog();
            this.Close();
        }
    }
    }

