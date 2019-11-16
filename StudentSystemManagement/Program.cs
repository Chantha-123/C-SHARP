using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentSystemManagement
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
         //    Application.Run(new Form1());
            //  Application.Run(new frmScore());
            //  Application.Run(new frmGraduate() );
            //   Application.Run(new frmGraduate());
            Application.Run(new frmLogin());
            //  // Application.Run(new Subject());
            //  Application.Run(new Form2());
           // Application.Run(new frmMenu());
          //  Application.Run(new frmClass());
         
        }
    }
}
