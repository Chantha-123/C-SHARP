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
    public partial class frmClass : Form
    {
        SqlConnection sqlc = new SqlConnection(frmGraduate.Sipha);
        public frmClass()
        {
            InitializeComponent();
            show();
            this.CenterToScreen();
            txtClassName.Focus();
            dtaClassName.ForeColor = Color.Black;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            sqlc.Open();
            string sql = "INSERT INTO ClassName (ClassName) VALUES ('" + txtClassName.Text + "')";
            SqlCommand sqlcmm = new SqlCommand(sql, sqlc);
            sqlcmm.ExecuteNonQuery();
            sqlc.Close();
            show();
            txtClassName.Clear();
        }

        void show()
        {
            sqlc.Open();
            string sql = "SELECT ClassName FROM ClassName";
            SqlDataAdapter sqlad = new SqlDataAdapter(sql, sqlc);
            DataTable dt = new DataTable();
            sqlad.Fill(dt);
            dtaClassName.AutoGenerateColumns = false;
            dtaClassName.DataSource = dt;
            sqlc.Close();
        }
        private void frmClass_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            sqlc.Open();
            string sql = "DELETE  ClassName FROM  ClassName  WHERE ClassName='" + txtClassName.Text + "'";
            SqlCommand sqlcmm = new SqlCommand(sql, sqlc);
            sqlcmm.ExecuteNonQuery();
            sqlc.Close();
            show();
            txtClassName.Clear();
        }

        private void dtaClassName_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtaClassName_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtClassName.Text = dtaClassName.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtClassName.Clear();
        }

        private void panel2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void frmClass_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            this.Hide();
            frmMenu frmm = new frmMenu();
            frmm.ShowDialog();
            this.Close();
        }
    }
}
