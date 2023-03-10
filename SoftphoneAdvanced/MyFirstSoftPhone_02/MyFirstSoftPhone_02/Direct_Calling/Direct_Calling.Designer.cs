namespace MyFirstSoftPhone_02
{
    partial class Direct_Calling
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Direct_Calling));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_PickUp = new System.Windows.Forms.Button();
            this.btn_HangUp = new System.Windows.Forms.Button();
            this.lbl_StatusCall = new System.Windows.Forms.Label();
            this.lbl_CallerName = new System.Windows.Forms.Label();
            this.lbl_CallerDepartment = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(51, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(413, 155);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_PickUp
            // 
            this.btn_PickUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_PickUp.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PickUp.Image = global::MyFirstSoftPhone_02.Properties.Resources.pickup;
            this.btn_PickUp.Location = new System.Drawing.Point(99, 188);
            this.btn_PickUp.Name = "btn_PickUp";
            this.btn_PickUp.Size = new System.Drawing.Size(70, 65);
            this.btn_PickUp.TabIndex = 17;
            this.btn_PickUp.UseVisualStyleBackColor = false;
            this.btn_PickUp.Click += new System.EventHandler(this.btn_PickUp_Click);
            // 
            // btn_HangUp
            // 
            this.btn_HangUp.BackColor = System.Drawing.Color.Red;
            this.btn_HangUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HangUp.Image = global::MyFirstSoftPhone_02.Properties.Resources.hangup;
            this.btn_HangUp.Location = new System.Drawing.Point(342, 188);
            this.btn_HangUp.Name = "btn_HangUp";
            this.btn_HangUp.Size = new System.Drawing.Size(66, 65);
            this.btn_HangUp.TabIndex = 16;
            this.btn_HangUp.UseVisualStyleBackColor = false;
            this.btn_HangUp.Click += new System.EventHandler(this.btn_HangUp_Click);
            // 
            // lbl_StatusCall
            // 
            this.lbl_StatusCall.AutoSize = true;
            this.lbl_StatusCall.BackColor = System.Drawing.Color.White;
            this.lbl_StatusCall.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StatusCall.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_StatusCall.Location = new System.Drawing.Point(183, 116);
            this.lbl_StatusCall.Name = "lbl_StatusCall";
            this.lbl_StatusCall.Size = new System.Drawing.Size(137, 25);
            this.lbl_StatusCall.TabIndex = 18;
            this.lbl_StatusCall.Text = "is calling you";
            this.lbl_StatusCall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_CallerName
            // 
            this.lbl_CallerName.AutoSize = true;
            this.lbl_CallerName.BackColor = System.Drawing.Color.White;
            this.lbl_CallerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CallerName.Location = new System.Drawing.Point(200, 27);
            this.lbl_CallerName.Name = "lbl_CallerName";
            this.lbl_CallerName.Size = new System.Drawing.Size(120, 25);
            this.lbl_CallerName.TabIndex = 19;
            this.lbl_CallerName.Text = "callerName";
            this.lbl_CallerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_CallerDepartment
            // 
            this.lbl_CallerDepartment.AutoSize = true;
            this.lbl_CallerDepartment.BackColor = System.Drawing.Color.White;
            this.lbl_CallerDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CallerDepartment.Location = new System.Drawing.Point(163, 71);
            this.lbl_CallerDepartment.Name = "lbl_CallerDepartment";
            this.lbl_CallerDepartment.Size = new System.Drawing.Size(175, 25);
            this.lbl_CallerDepartment.TabIndex = 20;
            this.lbl_CallerDepartment.Text = "callerDepartment";
            this.lbl_CallerDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Direct_Calling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 283);
            this.Controls.Add(this.lbl_CallerDepartment);
            this.Controls.Add(this.lbl_CallerName);
            this.Controls.Add(this.lbl_StatusCall);
            this.Controls.Add(this.btn_PickUp);
            this.Controls.Add(this.btn_HangUp);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Direct_Calling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Controll_Calling";
            this.Load += new System.EventHandler(this.Direct_Calling_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_PickUp;
        private System.Windows.Forms.Button btn_HangUp;
        private System.Windows.Forms.Label lbl_StatusCall;
        public System.Windows.Forms.Label lbl_CallerName;
        private System.Windows.Forms.Label lbl_CallerDepartment;
        private System.Windows.Forms.Timer timer;
    }
}