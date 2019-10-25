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
        private static readonly string hash = "ed9e5e06101846de5a9ff71685e51bc3";

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
            Control.ControlCollection controls = loginForm.Controls;
            foreach(Control c in controls)
            {
                if(c is TextBox && c.Name.Equals("passwordTextBox"))
                {
                    string s = ((TextBox)c).Text;
                    //MessageBox.Show(CreateMD5(s));
                    if (CreateMD5(s).Equals(hash))
                    {
                      /*  MessageBox.Show("Felicitari, te-ai conectat",
                            "Conexiune reusita",MessageBoxButtons.OK);*/
                        MenuForm mf = new MenuForm();
                        mf.Show();
                        loginForm.Hide();
                       
                    }
                    else
                    {
                        MessageBox.Show("Nu ai introdus parola corecta", "Conectare esuata",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                }
            }
        }
        public static void EmptyTextBox(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            switch (tb.Name)
            {
                case "userTextBox":
                    if (tb.Text.Equals("Utilizator"))
                        tb.Text = "";
                    break;
                case "passwordTextBox":
                    if (tb.Text.Equals("Parola"))
                        tb.Text = "";
                    break;
            }     
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
        public static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }
        public static void RobotFill(Control c)
        {
            ((TextBox)c).Text = "origami";
        }
    
        public static void HighlightUnderline(object sender, EventArgs e) { ((Panel)sender).ForeColor = Color.YellowGreen;}
        public static void UnhighlightUnderline(object sender, EventArgs e) { ((Panel)sender).ForeColor= Color.White; }
    }
}
