﻿namespace work_protection_survey
{
    partial class MenuForm
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
            this.topbarPanel = new System.Windows.Forms.Panel();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.topbarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topbarPanel
            // 
            this.topbarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.topbarPanel.Controls.Add(this.minimizeButton);
            this.topbarPanel.Location = new System.Drawing.Point(0, 0);
            this.topbarPanel.Name = "topbarPanel";
            this.topbarPanel.Size = new System.Drawing.Size(800, 32);
            this.topbarPanel.TabIndex = 0;
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeButton.ForeColor = System.Drawing.Color.White;
            this.minimizeButton.Location = new System.Drawing.Point(660, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(70, 32);
            this.minimizeButton.TabIndex = 2;
            this.minimizeButton.Text = "_";
            this.minimizeButton.UseVisualStyleBackColor = false;
            // 
            // exitButton
            // 
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(730, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(70, 32);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.topbarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.topbarPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topbarPanel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button minimizeButton;
    }
}