
namespace MyFirstSoftPhone_02.Admin
{
    partial class FormMainAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainAdmin));
            this.panel_Control = new System.Windows.Forms.Panel();
            this.btnManageCall = new System.Windows.Forms.Button();
            this.btnManageUser = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.panel_Control.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Control
            // 
            this.panel_Control.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel_Control.Controls.Add(this.btnManageCall);
            this.panel_Control.Controls.Add(this.btnManageUser);
            this.panel_Control.Location = new System.Drawing.Point(0, 0);
            this.panel_Control.Name = "panel_Control";
            this.panel_Control.Size = new System.Drawing.Size(121, 435);
            this.panel_Control.TabIndex = 0;
            // 
            // btnManageCall
            // 
            this.btnManageCall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageCall.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnManageCall.FlatAppearance.BorderSize = 10;
            this.btnManageCall.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnManageCall.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageCall.Location = new System.Drawing.Point(3, 188);
            this.btnManageCall.Name = "btnManageCall";
            this.btnManageCall.Size = new System.Drawing.Size(109, 56);
            this.btnManageCall.TabIndex = 2;
            this.btnManageCall.Text = "Quản lý cuộc gọi";
            this.btnManageCall.UseVisualStyleBackColor = true;
            this.btnManageCall.Click += new System.EventHandler(this.btnManageCall_Click);
            // 
            // btnManageUser
            // 
            this.btnManageUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageUser.Location = new System.Drawing.Point(3, 84);
            this.btnManageUser.Name = "btnManageUser";
            this.btnManageUser.Size = new System.Drawing.Size(109, 61);
            this.btnManageUser.TabIndex = 1;
            this.btnManageUser.Text = "Quản lý người dùng";
            this.btnManageUser.UseVisualStyleBackColor = true;
            this.btnManageUser.Click += new System.EventHandler(this.btnManageUser_Click);
            // 
            // panelContent
            // 
            this.panelContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContent.Location = new System.Drawing.Point(127, 54);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(759, 381);
            this.panelContent.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(220, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(285, 33);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Quản lý người dùng";
            // 
            // panelTitle
            // 
            this.panelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTitle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelTitle.Controls.Add(this.btnAddUser);
            this.panelTitle.Controls.Add(this.lblTitle);
            this.panelTitle.Location = new System.Drawing.Point(127, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(759, 48);
            this.panelTitle.TabIndex = 3;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddUser.Image = global::MyFirstSoftPhone_02.Properties.Resources.addUser;
            this.btnAddUser.Location = new System.Drawing.Point(511, 0);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(53, 48);
            this.btnAddUser.TabIndex = 3;
            this.btnAddUser.UseVisualStyleBackColor = true;
            // 
            // FormMainAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 433);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panel_Control);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMainAdmin";
            this.Text = "Admin";
            this.panel_Control.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Control;
        private System.Windows.Forms.Button btnManageCall;
        private System.Windows.Forms.Button btnManageUser;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Button btnAddUser;
    }
}