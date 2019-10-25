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
                SendMessage(menuForm.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

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
        public static void FillDefaultText(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (String.IsNullOrEmpty(tb.Text) || String.IsNullOrWhiteSpace(tb.Text))
            {
                switch (tb.Name)
                {
                    case "firstNameTextBox":
                        tb.Text = "Prenume";
                        break;
                    case "lastNameTextBox":
                        tb.Text = "Nume";
                        break;
                    default:
                        break;
                }
            }
        }
        public static void EmptyTextBox(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            switch (tb.Name)
            {
                case "firstNameTextBox":
                    if (tb.Text.Equals("Nume"))
                        tb.Text = "";
                    break;
                case "lastNameTextBox":
                    if (tb.Text.Equals("Prenume"))
                        tb.Text = "";
                    break;
            }
        }

        public static void StartTest(object sender, EventArgs e)
        {
            MessageBox.Show("Start");
        }
    }
}
