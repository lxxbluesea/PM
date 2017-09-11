using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProjectManagement
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Forms.Project.ProjectList pl = new Forms.Project.ProjectList();
            if (pl.ShowDialog() == DialogResult.OK)
            {
                MainFrame mf;
                if (pl.ProjectCount > 0)
                {
                    mf = new MainFrame(pl.CurrentProject);
                }
                else
                {
                    mf = new MainFrame();
                }
                Application.Run(mf);
                //Application.Run(new MainFrame());

            }

        }
    }
}
