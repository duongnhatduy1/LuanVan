namespace MyFirstSoftPhone_02
{
    partial class Form_CallManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_CallManagement));
            this.lb_Log = new System.Windows.Forms.ListBox();
            this.btn_Num1 = new System.Windows.Forms.Button();
            this.btn_Num2 = new System.Windows.Forms.Button();
            this.btn_Num3 = new System.Windows.Forms.Button();
            this.btn_Num4 = new System.Windows.Forms.Button();
            this.btn_Num5 = new System.Windows.Forms.Button();
            this.btn_Num6 = new System.Windows.Forms.Button();
            this.btn_Num7 = new System.Windows.Forms.Button();
            this.btn_Num8 = new System.Windows.Forms.Button();
            this.btn_Num9 = new System.Windows.Forms.Button();
            this.btn_Num0 = new System.Windows.Forms.Button();
            this.btn_NumStar = new System.Windows.Forms.Button();
            this.btn_NumSharp = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_DeleteAll = new System.Windows.Forms.Button();
            this.lbl_NumberToDial = new System.Windows.Forms.TextBox();
            this.lbl_UserLogin = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_PickUp = new System.Windows.Forms.Button();
            this.btn_HangUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Log
            // 
            this.lb_Log.FormattingEnabled = true;
            this.lb_Log.Location = new System.Drawing.Point(13, 78);
            this.lb_Log.Name = "lb_Log";
            this.lb_Log.Size = new System.Drawing.Size(321, 407);
            this.lb_Log.TabIndex = 0;
            this.lb_Log.SelectedIndexChanged += new System.EventHandler(this.lb_Log_SelectedIndexChanged);
            // 
            // btn_Num1
            // 
            this.btn_Num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Num1.Location = new System.Drawing.Point(387, 232);
            this.btn_Num1.Name = "btn_Num1";
            this.btn_Num1.Size = new System.Drawing.Size(75, 44);
            this.btn_Num1.TabIndex = 3;
            this.btn_Num1.Text = "1";
            this.btn_Num1.UseVisualStyleBackColor = true;
            this.btn_Num1.Click += new System.EventHandler(this.buttonKeyPadButton_Click);
            // 
            // btn_Num2
            // 
            this.btn_Num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Num2.Location = new System.Drawing.Point(510, 232);
            this.btn_Num2.Name = "btn_Num2";
            this.btn_Num2.Size = new System.Drawing.Size(75, 44);
            this.btn_Num2.TabIndex = 4;
            this.btn_Num2.Text = "2";
            this.btn_Num2.UseVisualStyleBackColor = true;
            this.btn_Num2.Click += new System.EventHandler(this.buttonKeyPadButton_Click);
            // 
            // btn_Num3
            // 
            this.btn_Num3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Num3.Location = new System.Drawing.Point(633, 232);
            this.btn_Num3.Name = "btn_Num3";
            this.btn_Num3.Size = new System.Drawing.Size(75, 44);
            this.btn_Num3.TabIndex = 5;
            this.btn_Num3.Text = "3";
            this.btn_Num3.UseVisualStyleBackColor = true;
            this.btn_Num3.Click += new System.EventHandler(this.buttonKeyPadButton_Click);
            // 
            // btn_Num4
            // 
            this.btn_Num4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Num4.Location = new System.Drawing.Point(387, 282);
            this.btn_Num4.Name = "btn_Num4";
            this.btn_Num4.Size = new System.Drawing.Size(75, 42);
            this.btn_Num4.TabIndex = 6;
            this.btn_Num4.Text = "4";
            this.btn_Num4.UseVisualStyleBackColor = true;
            this.btn_Num4.Click += new System.EventHandler(this.buttonKeyPadButton_Click);
            // 
            // btn_Num5
            // 
            this.btn_Num5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Num5.Location = new System.Drawing.Point(510, 282);
            this.btn_Num5.Name = "btn_Num5";
            this.btn_Num5.Size = new System.Drawing.Size(75, 42);
            this.btn_Num5.TabIndex = 7;
            this.btn_Num5.Text = "5";
            this.btn_Num5.UseVisualStyleBackColor = true;
            this.btn_Num5.Click += new System.EventHandler(this.buttonKeyPadButton_Click);
            // 
            // btn_Num6
            // 
            this.btn_Num6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Num6.Location = new System.Drawing.Point(633, 282);
            this.btn_Num6.Name = "btn_Num6";
            this.btn_Num6.Size = new System.Drawing.Size(75, 42);
            this.btn_Num6.TabIndex = 8;
            this.btn_Num6.Text = "6";
            this.btn_Num6.UseVisualStyleBackColor = true;
            this.btn_Num6.Click += new System.EventHandler(this.buttonKeyPadButton_Click);
            // 
            // btn_Num7
            // 
            this.btn_Num7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Num7.Location = new System.Drawing.Point(387, 330);
            this.btn_Num7.Name = "btn_Num7";
            this.btn_Num7.Size = new System.Drawing.Size(75, 44);
            this.btn_Num7.TabIndex = 9;
            this.btn_Num7.Text = "7";
            this.btn_Num7.UseVisualStyleBackColor = true;
            this.btn_Num7.Click += new System.EventHandler(this.buttonKeyPadButton_Click);
            // 
            // btn_Num8
            // 
            this.btn_Num8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Num8.Location = new System.Drawing.Point(510, 330);
            this.btn_Num8.Name = "btn_Num8";
            this.btn_Num8.Size = new System.Drawing.Size(75, 44);
            this.btn_Num8.TabIndex = 10;
            this.btn_Num8.Text = "8";
            this.btn_Num8.UseVisualStyleBackColor = true;
            this.btn_Num8.Click += new System.EventHandler(this.buttonKeyPadButton_Click);
            // 
            // btn_Num9
            // 
            this.btn_Num9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Num9.Location = new System.Drawing.Point(633, 330);
            this.btn_Num9.Name = "btn_Num9";
            this.btn_Num9.Size = new System.Drawing.Size(75, 44);
            this.btn_Num9.TabIndex = 11;
            this.btn_Num9.Text = "9";
            this.btn_Num9.UseVisualStyleBackColor = true;
            this.btn_Num9.Click += new System.EventHandler(this.buttonKeyPadButton_Click);
            // 
            // btn_Num0
            // 
            this.btn_Num0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Num0.Location = new System.Drawing.Point(510, 380);
            this.btn_Num0.Name = "btn_Num0";
            this.btn_Num0.Size = new System.Drawing.Size(75, 40);
            this.btn_Num0.TabIndex = 12;
            this.btn_Num0.Text = "0";
            this.btn_Num0.UseVisualStyleBackColor = true;
            this.btn_Num0.Click += new System.EventHandler(this.buttonKeyPadButton_Click);
            // 
            // btn_NumStar
            // 
            this.btn_NumStar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NumStar.Location = new System.Drawing.Point(387, 380);
            this.btn_NumStar.Name = "btn_NumStar";
            this.btn_NumStar.Size = new System.Drawing.Size(75, 40);
            this.btn_NumStar.TabIndex = 13;
            this.btn_NumStar.Text = "*";
            this.btn_NumStar.UseVisualStyleBackColor = true;
            this.btn_NumStar.Click += new System.EventHandler(this.buttonKeyPadButton_Click);
            // 
            // btn_NumSharp
            // 
            this.btn_NumSharp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NumSharp.Location = new System.Drawing.Point(633, 380);
            this.btn_NumSharp.Name = "btn_NumSharp";
            this.btn_NumSharp.Size = new System.Drawing.Size(75, 40);
            this.btn_NumSharp.TabIndex = 14;
            this.btn_NumSharp.Text = "#";
            this.btn_NumSharp.UseVisualStyleBackColor = true;
            this.btn_NumSharp.Click += new System.EventHandler(this.buttonKeyPadButton_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.Black;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.Location = new System.Drawing.Point(449, 443);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 35);
            this.btn_Delete.TabIndex = 17;
            this.btn_Delete.Text = "X";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.buttonKeyDeleteButton_Click);
            // 
            // btn_DeleteAll
            // 
            this.btn_DeleteAll.BackColor = System.Drawing.Color.Black;
            this.btn_DeleteAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteAll.ForeColor = System.Drawing.Color.White;
            this.btn_DeleteAll.Location = new System.Drawing.Point(564, 443);
            this.btn_DeleteAll.Name = "btn_DeleteAll";
            this.btn_DeleteAll.Size = new System.Drawing.Size(85, 35);
            this.btn_DeleteAll.TabIndex = 18;
            this.btn_DeleteAll.Text = "Clear";
            this.btn_DeleteAll.UseVisualStyleBackColor = false;
            this.btn_DeleteAll.Click += new System.EventHandler(this.buttonKeyDeleteAllButton_Click);
            // 
            // lbl_NumberToDial
            // 
            this.lbl_NumberToDial.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_NumberToDial.BackColor = System.Drawing.Color.White;
            this.lbl_NumberToDial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_NumberToDial.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NumberToDial.Location = new System.Drawing.Point(433, 61);
            this.lbl_NumberToDial.Name = "lbl_NumberToDial";
            this.lbl_NumberToDial.Size = new System.Drawing.Size(246, 40);
            this.lbl_NumberToDial.TabIndex = 16;
            this.lbl_NumberToDial.Text = "label1";
            // 
            // lbl_UserLogin
            // 
            this.lbl_UserLogin.AutoEllipsis = true;
            this.lbl_UserLogin.AutoSize = true;
            this.lbl_UserLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_UserLogin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_UserLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserLogin.ForeColor = System.Drawing.Color.Green;
            this.lbl_UserLogin.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            this.lbl_UserLogin.Location = new System.Drawing.Point(67, 21);
            this.lbl_UserLogin.Name = "lbl_UserLogin";
            this.lbl_UserLogin.Size = new System.Drawing.Size(87, 24);
            this.lbl_UserLogin.TabIndex = 19;
            this.lbl_UserLogin.Text = "Unknown";
            this.lbl_UserLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Image = global::MyFirstSoftPhone_02.Properties.Resources.Person1;
            this.button1.Location = new System.Drawing.Point(13, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 50);
            this.button1.TabIndex = 20;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_PickUp
            // 
            this.btn_PickUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_PickUp.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PickUp.Image = global::MyFirstSoftPhone_02.Properties.Resources.pickup;
            this.btn_PickUp.Location = new System.Drawing.Point(408, 128);
            this.btn_PickUp.Name = "btn_PickUp";
            this.btn_PickUp.Size = new System.Drawing.Size(70, 65);
            this.btn_PickUp.TabIndex = 15;
            this.btn_PickUp.UseVisualStyleBackColor = false;
            this.btn_PickUp.Click += new System.EventHandler(this.btn_PickUp_Click);
            // 
            // btn_HangUp
            // 
            this.btn_HangUp.BackColor = System.Drawing.Color.Red;
            this.btn_HangUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HangUp.Image = global::MyFirstSoftPhone_02.Properties.Resources.hangup;
            this.btn_HangUp.Location = new System.Drawing.Point(633, 128);
            this.btn_HangUp.Name = "btn_HangUp";
            this.btn_HangUp.Size = new System.Drawing.Size(66, 65);
            this.btn_HangUp.TabIndex = 2;
            this.btn_HangUp.UseVisualStyleBackColor = false;
            this.btn_HangUp.Click += new System.EventHandler(this.btn_HangUp_Click);
            // 
            // Form_CallManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 503);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_UserLogin);
            this.Controls.Add(this.btn_DeleteAll);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.lbl_NumberToDial);
            this.Controls.Add(this.btn_PickUp);
            this.Controls.Add(this.btn_NumSharp);
            this.Controls.Add(this.btn_NumStar);
            this.Controls.Add(this.btn_Num0);
            this.Controls.Add(this.btn_Num9);
            this.Controls.Add(this.btn_Num8);
            this.Controls.Add(this.btn_Num7);
            this.Controls.Add(this.btn_Num6);
            this.Controls.Add(this.btn_Num5);
            this.Controls.Add(this.btn_Num4);
            this.Controls.Add(this.btn_Num3);
            this.Controls.Add(this.btn_Num2);
            this.Controls.Add(this.btn_Num1);
            this.Controls.Add(this.btn_HangUp);
            this.Controls.Add(this.lb_Log);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_CallManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sip Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_Log;
        private System.Windows.Forms.Button btn_HangUp;
        private System.Windows.Forms.Button btn_Num1;
        private System.Windows.Forms.Button btn_Num2;
        private System.Windows.Forms.Button btn_Num3;
        private System.Windows.Forms.Button btn_Num4;
        private System.Windows.Forms.Button btn_Num5;
        private System.Windows.Forms.Button btn_Num6;
        private System.Windows.Forms.Button btn_Num7;
        private System.Windows.Forms.Button btn_Num8;
        private System.Windows.Forms.Button btn_Num9;
        private System.Windows.Forms.Button btn_Num0;
        private System.Windows.Forms.Button btn_NumStar;
        private System.Windows.Forms.Button btn_NumSharp;
        private System.Windows.Forms.Button btn_PickUp;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_DeleteAll;
        private System.Windows.Forms.TextBox lbl_NumberToDial;
        private System.Windows.Forms.Label lbl_UserLogin;
        private System.Windows.Forms.Button button1;
    }
}
