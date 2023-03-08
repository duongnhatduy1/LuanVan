namespace MyFirstSoftPhone_02
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
            this.lb_Log = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.DeleteAll = new System.Windows.Forms.Button();
            this.btn_PickUp = new System.Windows.Forms.Button();
            this.btn_HangUp = new System.Windows.Forms.Button();
            this.lbl_NumberToDial = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_Log
            // 
            this.lb_Log.FormattingEnabled = true;
            this.lb_Log.Location = new System.Drawing.Point(13, 13);
            this.lb_Log.Name = "lb_Log";
            this.lb_Log.Size = new System.Drawing.Size(321, 472);
            this.lb_Log.TabIndex = 0;
            this.lb_Log.SelectedIndexChanged += new System.EventHandler(this.lb_Log_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(387, 232);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 44);
            this.button3.TabIndex = 3;
            this.button3.Text = "1";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonKeyPadButton_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(510, 232);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 44);
            this.button4.TabIndex = 4;
            this.button4.Text = "2";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonKeyPadButton_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(633, 232);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 44);
            this.button5.TabIndex = 5;
            this.button5.Text = "3";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.buttonKeyPadButton_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(387, 282);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 42);
            this.button6.TabIndex = 6;
            this.button6.Text = "4";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.buttonKeyPadButton_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(510, 282);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 42);
            this.button7.TabIndex = 7;
            this.button7.Text = "5";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.buttonKeyPadButton_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(633, 282);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 42);
            this.button8.TabIndex = 8;
            this.button8.Text = "6";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.buttonKeyPadButton_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(387, 330);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 44);
            this.button9.TabIndex = 9;
            this.button9.Text = "7";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.buttonKeyPadButton_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(510, 330);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 44);
            this.button10.TabIndex = 10;
            this.button10.Text = "8";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.buttonKeyPadButton_Click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(633, 330);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 44);
            this.button11.TabIndex = 11;
            this.button11.Text = "9";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.buttonKeyPadButton_Click);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(510, 380);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 40);
            this.button12.TabIndex = 12;
            this.button12.Text = "0";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.buttonKeyPadButton_Click);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(387, 380);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 40);
            this.button13.TabIndex = 13;
            this.button13.Text = "*";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.buttonKeyPadButton_Click);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(633, 380);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 40);
            this.button14.TabIndex = 14;
            this.button14.Text = "#";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.buttonKeyPadButton_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Black;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(449, 443);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 35);
            this.buttonDelete.TabIndex = 17;
            this.buttonDelete.Text = "X";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonKeyDeleteButton_Click);
            // 
            // DeleteAll
            // 
            this.DeleteAll.BackColor = System.Drawing.Color.Black;
            this.DeleteAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteAll.ForeColor = System.Drawing.Color.White;
            this.DeleteAll.Location = new System.Drawing.Point(564, 443);
            this.DeleteAll.Name = "DeleteAll";
            this.DeleteAll.Size = new System.Drawing.Size(85, 35);
            this.DeleteAll.TabIndex = 18;
            this.DeleteAll.Text = "Clear";
            this.DeleteAll.UseVisualStyleBackColor = false;
            this.DeleteAll.Click += new System.EventHandler(this.buttonKeyDeleteAllButton_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 503);
            this.Controls.Add(this.DeleteAll);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.lbl_NumberToDial);
            this.Controls.Add(this.btn_PickUp);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_HangUp);
            this.Controls.Add(this.lb_Log);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Sip Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_Log;
        private System.Windows.Forms.Button btn_HangUp;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button btn_PickUp;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button DeleteAll;
        private System.Windows.Forms.TextBox lbl_NumberToDial;
    }
}
