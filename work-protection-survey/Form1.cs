using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace work_protection_survey
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            Login.SetForm(this);
            SetClickEvents();
            SetMouseDownEvents();
        }

        private void SetMouseDownEvents()
        {
            this.MouseDown += Login.DragWindow;
            topbarPanel.MouseDown += Login.DragWindow;
            conectareLabel.MouseDown += Login.DragWindow;
            userPicture.MouseDown += Login.DragWindow;
            lockPicture.MouseDown += Login.DragWindow;
        }
        private void SetClickEvents()
        {
            exitButton.Click += Login.ExitApplication;
            minimizeButton.Click += Login.MinimizeApplication;
            connectButton.Click += Login.Connect;
            userTextBox.Click += Login.EmptyTextBox;
            passwordTextBox.Click += Login.EmptyTextBox;
            userTextBox.MouseLeave += Login.FillDefaultText;
            passwordTextBox.MouseLeave += Login.FillDefaultText;
        }
    }
}
