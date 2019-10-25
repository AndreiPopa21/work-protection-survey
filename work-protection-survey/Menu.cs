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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            MainMenu.SetForm(this);
            SetClickEvents();
            SetMouseDownEvents();
        }

        private void SetClickEvents()
        {
            exitButton.Click += MainMenu.ExitApplication;
            minimizeButton.Click += MainMenu.MinimizeApplication;
        }

        private void SetMouseDownEvents()
        {
            this.MouseDown += MainMenu.DragWindow;
            topbarPanel.MouseDown += MainMenu.DragWindow;
            bottombarPanel.MouseDown += MainMenu.DragWindow;
            copyrightsLabel.MouseDown += MainMenu.DragWindow;
            startLabel.MouseDown += MainMenu.DragWindow;
        }

        private void copyrightsLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
