using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Drawing;

namespace work_protection_survey
{
    class Login
    {
        private static Form loginForm;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public static void DragWindow(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(loginForm.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public static void SetForm(Form form)
        {
            loginForm = form;
        }
        public static void ExitApplication(object sender, EventArgs e)
        {
            //Exit application
            Application.Exit();
        }
        public static void MinimizeApplication(object sender, EventArgs e)
        {
            //Minimize application
            loginForm.WindowState = FormWindowState.Minimized;
        }
        public static void Connect(object sender, EventArgs e)
        {

        }
        public static void EmptyTextBox(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = "";
        }

        public static void FillDefaultText(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if(String.IsNullOrEmpty(tb.Text) || String.IsNullOrWhiteSpace(tb.Text))
            {
                switch (tb.Name)
                {
                    case "userTextBox":
                        tb.Text = "Utilizator";
                        break;
                    case "passwordTextBox":
                        tb.Text = "Parola";
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
