
namespace MyFirstSoftPhone_02.Admin
{
    partial class FormUpdateDepartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUpdateDepartment));
            this.lblContent = new System.Windows.Forms.ListBox();
            this.tbDepartmentID = new System.Windows.Forms.TextBox();
            this.tbDepartmentName = new System.Windows.Forms.TextBox();
            this.cbxOption = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblContent
            // 
            this.lblContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblContent.BackColor = System.Drawing.Color.White;
            this.lblContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblContent.HorizontalScrollbar = true;
            this.lblContent.ItemHeight = 18;
            this.lblContent.Location = new System.Drawing.Point(29, 32);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(718, 310);
            this.lblContent.TabIndex = 5;
            // 
            // tbDepartmentID
            // 
            this.tbDepartmentID.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbDepartmentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDepartmentID.Location = new System.Drawing.Point(174, 364);
            this.tbDepartmentID.Multiline = true;
            this.tbDepartmentID.Name = "tbDepartmentID";
            this.tbDepartmentID.Size = new System.Drawing.Size(187, 29);
            this.tbDepartmentID.TabIndex = 4;
            // 
            // tbDepartmentName
            // 
            this.tbDepartmentName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbDepartmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDepartmentName.Location = new System.Drawing.Point(174, 413);
            this.tbDepartmentName.Multiline = true;
            this.tbDepartmentName.Name = "tbDepartmentName";
            this.tbDepartmentName.Size = new System.Drawing.Size(308, 29);
            this.tbDepartmentName.TabIndex = 6;
            // 
            // cbxOption
            // 
            this.cbxOption.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbxOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxOption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cbxOption.FormattingEnabled = true;
            this.cbxOption.Items.AddRange(new object[] {
            "Thêm",
            "Sửa"});
            this.cbxOption.Location = new System.Drawing.Point(422, 364);
            this.cbxOption.Name = "cbxOption";
            this.cbxOption.Size = new System.Drawing.Size(98, 33);
            this.cbxOption.TabIndex = 11;
            this.cbxOption.Text = "Thêm";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 413);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tên bộ phận";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mã bộ phận";
            // 
            // btnAction
            // 
            this.btnAction.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAction.BackColor = System.Drawing.Color.Brown;
            this.btnAction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAction.ForeColor = System.Drawing.Color.Yellow;
            this.btnAction.Location = new System.Drawing.Point(592, 390);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(117, 37);
            this.btnAction.TabIndex = 14;
            this.btnAction.Text = "Thực hiện";
            this.btnAction.UseVisualStyleBackColor = false;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // FormUpdateDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxOption);
            this.Controls.Add(this.tbDepartmentName);
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.tbDepartmentID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormUpdateDepartment";
            this.Text = "Cập nhật bộ phận";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox lblContent;
        private System.Windows.Forms.TextBox tbDepartmentID;
        private System.Windows.Forms.TextBox tbDepartmentName;
        private System.Windows.Forms.ComboBox cbxOption;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAction;
    }
}