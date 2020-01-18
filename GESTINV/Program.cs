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
                    Application.Run(new Vista());
                }
                else if (l.DialogResult == DialogResult.No)
                {
                    Application.Run(new Vista(1));
                   
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
