﻿
namespace MyFirstSoftPhone_02.Admin
{
    partial class FormManageUsers
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
            this.panel_FormUsers = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel_FormUsers
            // 
            this.panel_FormUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_FormUsers.AutoScroll = true;
            this.panel_FormUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel_FormUsers.Location = new System.Drawing.Point(2, 1);
            this.panel_FormUsers.Name = "panel_FormUsers";
            this.panel_FormUsers.Size = new System.Drawing.Size(813, 448);
            this.panel_FormUsers.TabIndex = 1;
            // 
            // FormManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 450);
            this.Controls.Add(this.panel_FormUsers);
            this.Name = "FormManageUsers";
            this.Text = "FormManageUsers";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_FormUsers;
    }
}