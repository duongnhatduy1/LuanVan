﻿
namespace MyFirstSoftPhone_02.Admin
{
    partial class FormManageCalls
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
            this.panel_FormCalls = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel_FormCalls
            // 
            this.panel_FormCalls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_FormCalls.AutoScroll = true;
            this.panel_FormCalls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel_FormCalls.Location = new System.Drawing.Point(1, 0);
            this.panel_FormCalls.Name = "panel_FormCalls";
            this.panel_FormCalls.Size = new System.Drawing.Size(795, 451);
            this.panel_FormCalls.TabIndex = 1;
            // 
            // FormManageCalls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_FormCalls);
            this.Name = "FormManageCalls";
            this.Text = "FormManageCalls";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_FormCalls;
    }
}