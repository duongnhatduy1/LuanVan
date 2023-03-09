using System.Drawing;
using System.Windows.Forms;
namespace MyFirstSoftPhone_02
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.lbl_Login = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.lbl_ServerIP = new System.Windows.Forms.Label();
            this.tb_ServerIP = new System.Windows.Forms.TextBox();
            this.btn_Registry = new System.Windows.Forms.Button();
            this.btn_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_Username
            // 
            resources.ApplyResources(this.tb_Username, "tb_Username");
            this.tb_Username.Name = "tb_Username";
            // 
            // lbl_Login
            // 
            resources.ApplyResources(this.lbl_Login, "lbl_Login");
            this.lbl_Login.Name = "lbl_Login";
            // 
            // lbl_Username
            // 
            resources.ApplyResources(this.lbl_Username, "lbl_Username");
            this.lbl_Username.Name = "lbl_Username";
            // 
            // lbl_Password
            // 
            resources.ApplyResources(this.lbl_Password, "lbl_Password");
            this.lbl_Password.Name = "lbl_Password";
            // 
            // tb_Password
            // 
            resources.ApplyResources(this.tb_Password, "tb_Password");
            this.tb_Password.Name = "tb_Password";
            // 
            // lbl_ServerIP
            // 
            resources.ApplyResources(this.lbl_ServerIP, "lbl_ServerIP");
            this.lbl_ServerIP.Name = "lbl_ServerIP";
            // 
            // tb_ServerIP
            // 
            this.tb_ServerIP.AllowDrop = true;
            resources.ApplyResources(this.tb_ServerIP, "tb_ServerIP");
            this.tb_ServerIP.Name = "tb_ServerIP";
            // 
            // btn_Registry
            // 
            this.btn_Registry.BackColor = System.Drawing.Color.White;
            this.btn_Registry.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            resources.ApplyResources(this.btn_Registry, "btn_Registry");
            this.btn_Registry.Image = global::MyFirstSoftPhone_02.Properties.Resources.reset1;
            this.btn_Registry.Name = "btn_Registry";
            this.btn_Registry.UseVisualStyleBackColor = false;
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.White;
            this.btn_Login.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btn_Login.FlatAppearance.BorderSize = 10;
            resources.ApplyResources(this.btn_Login, "btn_Login");
            this.btn_Login.Image = global::MyFirstSoftPhone_02.Properties.Resources.Login1;
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.tb_ServerIP);
            this.Controls.Add(this.btn_Registry);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.lbl_ServerIP);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.lbl_Login);
            this.Controls.Add(this.tb_Username);
            this.Name = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tb_Username;
        private Label lbl_Login;
        private Label lbl_Username;
        private Label lbl_Password;
        private TextBox tb_Password;
        private Label lbl_ServerIP;
        private Button btn_Login;
        private Button btn_Registry;
        private TextBox tb_ServerIP;
    }
}