namespace work_protection_survey
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.topbarPanel = new System.Windows.Forms.Panel();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.conectareLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.userUnderline = new System.Windows.Forms.Panel();
            this.passwordUnderline = new System.Windows.Forms.Panel();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.userPicture = new System.Windows.Forms.PictureBox();
            this.lockPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lockPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // topbarPanel
            // 
            this.topbarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.topbarPanel.Location = new System.Drawing.Point(0, 0);
            this.topbarPanel.Name = "topbarPanel";
            this.topbarPanel.Size = new System.Drawing.Size(550, 32);
            this.topbarPanel.TabIndex = 0;
            // 
            // minimizeButton
            // 
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeButton.ForeColor = System.Drawing.Color.White;
            this.minimizeButton.Location = new System.Drawing.Point(480, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(70, 32);
            this.minimizeButton.TabIndex = 1;
            this.minimizeButton.Text = "X";
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // exitButton
            // 
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(410, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(70, 32);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "_";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // conectareLabel
            // 
            this.conectareLabel.AutoSize = true;
            this.conectareLabel.Font = new System.Drawing.Font("Verdana", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conectareLabel.ForeColor = System.Drawing.Color.White;
            this.conectareLabel.Location = new System.Drawing.Point(32, 97);
            this.conectareLabel.Name = "conectareLabel";
            this.conectareLabel.Size = new System.Drawing.Size(482, 46);
            this.conectareLabel.TabIndex = 3;
            this.conectareLabel.Text = "Conectare administrator";
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(190, 398);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(170, 50);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Conectare";
            this.loginButton.UseVisualStyleBackColor = false;
            // 
            // userUnderline
            // 
            this.userUnderline.BackColor = System.Drawing.Color.White;
            this.userUnderline.Location = new System.Drawing.Point(155, 261);
            this.userUnderline.Name = "userUnderline";
            this.userUnderline.Size = new System.Drawing.Size(250, 2);
            this.userUnderline.TabIndex = 5;
            // 
            // passwordUnderline
            // 
            this.passwordUnderline.BackColor = System.Drawing.Color.White;
            this.passwordUnderline.Location = new System.Drawing.Point(155, 344);
            this.passwordUnderline.Name = "passwordUnderline";
            this.passwordUnderline.Size = new System.Drawing.Size(250, 2);
            this.passwordUnderline.TabIndex = 6;
            // 
            // userTextBox
            // 
            this.userTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.userTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.userTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userTextBox.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTextBox.ForeColor = System.Drawing.Color.White;
            this.userTextBox.Location = new System.Drawing.Point(168, 232);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(225, 28);
            this.userTextBox.TabIndex = 7;
            this.userTextBox.Text = "Utilizator";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.passwordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.White;
            this.passwordTextBox.Location = new System.Drawing.Point(168, 313);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(225, 28);
            this.passwordTextBox.TabIndex = 8;
            this.passwordTextBox.Text = "Parola";
            // 
            // userPicture
            // 
            this.userPicture.Image = ((System.Drawing.Image)(resources.GetObject("userPicture.Image")));
            this.userPicture.Location = new System.Drawing.Point(104, 230);
            this.userPicture.Name = "userPicture";
            this.userPicture.Size = new System.Drawing.Size(34, 38);
            this.userPicture.TabIndex = 9;
            this.userPicture.TabStop = false;
            // 
            // lockPicture
            // 
            this.lockPicture.Image = ((System.Drawing.Image)(resources.GetObject("lockPicture.Image")));
            this.lockPicture.Location = new System.Drawing.Point(104, 313);
            this.lockPicture.Name = "lockPicture";
            this.lockPicture.Size = new System.Drawing.Size(34, 38);
            this.lockPicture.TabIndex = 10;
            this.lockPicture.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(550, 500);
            this.Controls.Add(this.lockPicture);
            this.Controls.Add(this.userPicture);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.passwordUnderline);
            this.Controls.Add(this.userUnderline);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.conectareLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.topbarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lockPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topbarPanel;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label conectareLabel;
        public System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Panel userUnderline;
        private System.Windows.Forms.Panel passwordUnderline;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.PictureBox userPicture;
        private System.Windows.Forms.PictureBox lockPicture;
    }
}

