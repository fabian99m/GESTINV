using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.Login;

namespace GESTINV
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);       
            Login l = new Login();
            do
            {
                l.ShowDialog();
                if (l.DialogResult == DialogResult.OK)
                {
                    Application.Run(new Form1());
                }
                else if (l.DialogResult == DialogResult.No)
                {
                    Application.Run(new Form1(1));
                   
                }
                else if (l.DialogResult == DialogResult.Cancel)
                {
                    Application.Exit();
                }
                
            } while (l.DialogResult == DialogResult.Retry);
            l.Dispose();

        }
    }
}
