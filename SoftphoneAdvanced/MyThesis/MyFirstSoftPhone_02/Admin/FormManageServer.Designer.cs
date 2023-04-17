
namespace MyFirstSoftPhone_02.Admin
{
    partial class FormManageServer
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
            this.btnStartServer = new System.Windows.Forms.Button();
            this.btnStopServer = new System.Windows.Forms.Button();
            this.lblOnl = new System.Windows.Forms.Label();
            this.lblOff = new System.Windows.Forms.Label();
            this.panelOnl = new System.Windows.Forms.Panel();
            this.panelOff = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnStartServer
            // 
            this.btnStartServer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnStartServer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartServer.ForeColor = System.Drawing.Color.White;
            this.btnStartServer.Location = new System.Drawing.Point(630, 211);
            this.btnStartServer.Name = "btnStartServer";
            this.btnStartServer.Size = new System.Drawing.Size(147, 52);
            this.btnStartServer.TabIndex = 0;
            this.btnStartServer.Text = "Start Server";
            this.btnStartServer.UseVisualStyleBackColor = false;
            this.btnStartServer.Click += new System.EventHandler(this.btnStartServer_Click);
            // 
            // btnStopServer
            // 
            this.btnStopServer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStopServer.BackColor = System.Drawing.Color.Red;
            this.btnStopServer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStopServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopServer.ForeColor = System.Drawing.Color.White;
            this.btnStopServer.Location = new System.Drawing.Point(630, 299);
            this.btnStopServer.Name = "btnStopServer";
            this.btnStopServer.Size = new System.Drawing.Size(147, 52);
            this.btnStopServer.TabIndex = 1;
            this.btnStopServer.Text = "Stop Server";
            this.btnStopServer.UseVisualStyleBackColor = false;
            this.btnStopServer.Click += new System.EventHandler(this.btnStopServer_Click);
            // 
            // lblOnl
            // 
            this.lblOnl.AutoSize = true;
            this.lblOnl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOnl.Location = new System.Drawing.Point(0, 95);
            this.lblOnl.Name = "lblOnl";
            this.lblOnl.Size = new System.Drawing.Size(189, 25);
            this.lblOnl.TabIndex = 2;
            this.lblOnl.Text = "Username online";
            // 
            // lblOff
            // 
            this.lblOff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblOff.AutoSize = true;
            this.lblOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOff.Location = new System.Drawing.Point(0, 299);
            this.lblOff.Name = "lblOff";
            this.lblOff.Size = new System.Drawing.Size(190, 25);
            this.lblOff.TabIndex = 3;
            this.lblOff.Text = "Username offline";
            // 
            // panelOnl
            // 
            this.panelOnl.AutoScroll = true;
            this.panelOnl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelOnl.Location = new System.Drawing.Point(207, 12);
            this.panelOnl.Name = "panelOnl";
            this.panelOnl.Size = new System.Drawing.Size(386, 206);
            this.panelOnl.TabIndex = 4;
            // 
            // panelOff
            // 
            this.panelOff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelOff.AutoScroll = true;
            this.panelOff.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelOff.Location = new System.Drawing.Point(207, 244);
            this.panelOff.Name = "panelOff";
            this.panelOff.Size = new System.Drawing.Size(386, 194);
            this.panelOff.TabIndex = 5;
            // 
            // FormManageServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStopServer);
            this.Controls.Add(this.panelOff);
            this.Controls.Add(this.panelOnl);
            this.Controls.Add(this.lblOff);
            this.Controls.Add(this.lblOnl);
            this.Controls.Add(this.btnStartServer);
            this.Name = "FormManageServer";
            this.Text = "FormManageServer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartServer;
        private System.Windows.Forms.Button btnStopServer;
        private System.Windows.Forms.Label lblOnl;
        private System.Windows.Forms.Label lblOff;
        private System.Windows.Forms.Panel panelOnl;
        private System.Windows.Forms.Panel panelOff;
    }
}