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
    public partial class frmLogin : Form
    {
        public static string Sipha = ConfigurationManager.ConnectionStrings["Test"].ToString();

        SqlConnection sqlc = new SqlConnection(Sipha);
        public frmLogin()
        {
            InitializeComponent();
          
            showdata();
            dtalogin.Hide();
            tmrnow.Start();
            timer1.Start();
          

        }

        void showdata()
        {
            sqlc.Open();
            string sql = "Select * from Login";
            SqlDataAdapter sqlcmm = new SqlDataAdapter(sql, sqlc);
            DataTable dtat = new DataTable();
            sqlcmm.Fill(dtat);
            dtalogin.AutoGenerateColumns = false;
            dtalogin.DataSource = dtat;
            sqlc.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
          
            if (txtUserNames.Text == dtalogin.Rows[0].Cells[1].Value.ToString() && txtPasswords.Text == dtalogin.Rows[0].Cells[2].Value.ToString())
            {
                this.Hide();
                frmMenu frmm = new frmMenu();
                 frmm.ShowDialog();
                this.Close();
              
            }
            else
            {
                MessageBox.Show("Incorrect login", "Message");
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
          
           
        }

        private void frmLogin_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Close();
          
          
            this.Close();
            
        }

        private void tmrnow_Tick(object sender, EventArgs e)
        {
            lblNow.Text = DateTime.Now.ToLongTimeString();
            lbldate.Text = DateTime.Now.ToLongDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rd = new Random();
            //int A = rd.Next(0, 255);
            //int R = rd.Next(0, 255);
            //int G = rd.Next(0, 255);
            //int B = rd.Next(0, 255);
            //label3.ForeColor = Color.FromArgb(A, R, B,G);
            //label4.ForeColor = Color.FromArgb(B, R, G, A);
            //label5.ForeColor = Color.FromArgb(R, A, B, G);
            //label6.ForeColor = Color.FromArgb(A, R, B, G);
            //label7.ForeColor = Color.FromArgb(A, R, B, G);
            //label8.ForeColor = Color.FromArgb(R, A, B, G);
            //label9.ForeColor = Color.FromArgb(B, R, G, A);
            //label11.ForeColor = Color.FromArgb(R, A, B, G);
            //label10.ForeColor = Color.FromArgb(B, R, G, A);
            //lbldate.ForeColor= Color.FromArgb(B, R, G, A);
            //lblNow.ForeColor= Color.FromArgb(A, R, B, G);
            //label1.ForeColor = Color.FromArgb(R, A, B, G);
            //label2.ForeColor = Color.FromArgb(B, R, G, A);
            //lblTiltle.ForeColor = Color.FromArgb(B, R, G, A);
            //label12.ForeColor = Color.FromArgb(B, R, G, A);
            //panel1.ForeColor = Color.FromArgb(B, R, G, A);


        }
    }
}
