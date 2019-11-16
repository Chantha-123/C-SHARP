using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentSystemManagement
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnStudentInfo_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                frmClass frmc = new frmClass();
                frmc.Hide();
                frmScore frmsc = new frmScore();
                frmGraduate frmg = new frmGraduate();
                Subject sub = new Subject();
                frmsc.Hide();
                frmg.Hide();
                sub.Hide();
                Form1 fr1 = new Form1();
                fr1.ShowDialog();
            }
            catch(Exception)
            {

            }
           
        }

        private void btnSubject_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                frmClass frmc = new frmClass();
                frmc.Hide();
                frmScore frmsc = new frmScore();
                Form1 frm1 = new Form1();
                frmGraduate frmg = new frmGraduate();
                frmsc.Hide();
                frm1.Hide();
                frmg.Hide();
                Subject sub = new Subject();
                sub.ShowDialog();
            }catch(Exception)
            {

            }
           
        }

        private void btnScoreManagement_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                frmClass frmc = new frmClass();
                frmc.Hide();
                frmGraduate frmg = new frmGraduate();
                Form1 frm1 = new Form1();
                Subject sub = new Subject();
                frmg.Hide();
                frm1.Hide();
                sub.Hide();
                frmScore frmcs = new frmScore();
                frmcs.ShowDialog();
            }
                catch(Exception)
            {

            }
        }

        private void btnGraduate_Click(object sender, EventArgs e)
        {
            try
            {

           
            this.Hide();
                frmClass frmc = new frmClass();
                frmc.Hide();
                frmScore frmsc = new frmScore();
            Form1 frm1 = new Form1();
            Subject sub = new Subject();
            frmsc.Hide();
            frm1.Hide();
            sub.Hide();

            frmGraduate frmg = new frmGraduate();
            frmg.ShowDialog();
            }catch(Exception)
            {

            }
        }

        private void frmMenu_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                this.Hide();
                frmScore frmsc = new frmScore();
                Form1 frm1 = new Form1();
                Subject sub = new Subject();
                frmsc.Hide();
                frm1.Hide();
                sub.Hide();

                frmGraduate frmg = new frmGraduate();
                frmg.Hide();
                frmClass frmc = new frmClass();
                frmc.ShowDialog();
            }
            catch (Exception)
            {

            }
        }
    }
}
