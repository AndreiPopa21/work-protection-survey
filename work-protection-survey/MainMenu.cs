using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace work_protection_survey
{
    class MainMenu
    {
        private static Form menuForm;

        public static void SetForm(Form form)
        {
            menuForm = form;
        }
        public static void ExitApplication(object sender, EventArgs e)
        {
            //Exit application
            Application.Exit();
        }
        public static void MinimizeApplication(object sender, EventArgs e)
        {
            //Minimize application
            menuForm.WindowState = FormWindowState.Minimized;
        }
    }
}
