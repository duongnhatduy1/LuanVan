using System.Drawing;
using System.Windows.Forms;
namespace MyFirstSoftPhone_02
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.lbl_Login = new System.Windows.Forms.Label();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.tb_ServerIP = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Login = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_Username
            // 
            this.tb_Username.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.tb_Username, "tb_Username");
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_Username_KeyDown);
            // 
            // lbl_Login
            // 
            resources.ApplyResources(this.lbl_Login, "lbl_Login");
            this.lbl_Login.ForeColor = System.Drawing.Color.Red;
            this.lbl_Login.Name = "lbl_Login";
            // 
            // tb_Password
            // 
            this.tb_Password.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.tb_Password, "tb_Password");
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_Password_KeyDown);
            // 
            // tb_ServerIP
            // 
            this.tb_ServerIP.AllowDrop = true;
            this.tb_ServerIP.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.tb_ServerIP, "tb_ServerIP");
            this.tb_ServerIP.Name = "tb_ServerIP";
            this.tb_ServerIP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_ServerIP_KeyDown);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Image = global::MyFirstSoftPhone_02.Properties.Resources.loginlbl1;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Login.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btn_Login.FlatAppearance.BorderSize = 10;
            resources.ApplyResources(this.btn_Login, "btn_Login");
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Blue;
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // FormLogin
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_ServerIP);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.lbl_Login);
            this.Controls.Add(this.tb_Username);
            this.Name = "FormLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tb_Username;
        private Label lbl_Login;
        private TextBox tb_Password;
        private Button btn_Login;
        private TextBox tb_ServerIP;
        private Button button1;
        private TextBox textBox1;
    }
}