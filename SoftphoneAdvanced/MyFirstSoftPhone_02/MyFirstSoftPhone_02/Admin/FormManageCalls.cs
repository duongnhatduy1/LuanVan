using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstSoftPhone_02.Admin
{
    public partial class FormManageCalls : Form
    {
        List<Label> _CallLabelCallID = new List<Label>();
        List<Button> _CallButtonDeletes = new List<Button>();
        List<Button> _CallButtonListens = new List<Button>();
        List<Button> _CallButtonInfos = new List<Button>();
        string IdClick = "";

        public FormManageCalls()
        {
            InitializeComponent();
            InitCalls();
        }


        public void InitCalls()
        {
            for (int i = 1; i < 21; i++)
            {
                //button delete
                var nguoidung = new System.Windows.Forms.Button();
                nguoidung.Location = new System.Drawing.Point(611, -45 + 50 * i);
                nguoidung.Name = "delete" + i;
                nguoidung.Size = new System.Drawing.Size(35, 35);
                nguoidung.TabIndex = 1;
                nguoidung.UseVisualStyleBackColor = true;
                nguoidung.Image = global::MyFirstSoftPhone_02.Properties.Resources.delete;
                nguoidung.Cursor = System.Windows.Forms.Cursors.Hand;
                panel_FormCalls.Controls.Add(nguoidung);
                _CallButtonDeletes.Add(nguoidung);
                nguoidung.Click += new System.EventHandler(Delete_Click);

                //button info
                nguoidung = new System.Windows.Forms.Button();
                nguoidung.Location = new System.Drawing.Point(531, -45 + 50 * i);
                nguoidung.Name = "info" + i;
                nguoidung.Size = new System.Drawing.Size(35, 35);
                nguoidung.TabIndex = 1;
                nguoidung.UseVisualStyleBackColor = true;
                nguoidung.Image = global::MyFirstSoftPhone_02.Properties.Resources.info;
                nguoidung.Cursor = System.Windows.Forms.Cursors.Hand;
                panel_FormCalls.Controls.Add(nguoidung);
                _CallButtonInfos.Add(nguoidung);
                nguoidung.Click += new System.EventHandler(Info_Click);

                //button listen
                nguoidung = new System.Windows.Forms.Button();
                nguoidung.Location = new System.Drawing.Point(570, -45 + 50 * i);
                nguoidung.Name = "listen" + i;
                nguoidung.Size = new System.Drawing.Size(35, 35);
                nguoidung.TabIndex = 1;
                nguoidung.UseVisualStyleBackColor = true;
                nguoidung.Image = global::MyFirstSoftPhone_02.Properties.Resources.listen;
                nguoidung.Cursor = System.Windows.Forms.Cursors.Hand;
                panel_FormCalls.Controls.Add(nguoidung);
                _CallButtonListens.Add(nguoidung);
                nguoidung.Click += new System.EventHandler(Listen_Click);

                //label Call-ID
                var label = new System.Windows.Forms.Label();
                panel_FormCalls.Controls.Add(label);
                label.AutoSize = true;
                label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                label.Location = new System.Drawing.Point(100, -45 + 50 * i);
                label.Name = "lblCall_ID" + i;
                label.Size = new System.Drawing.Size(251, 31);
                label.TabIndex = 3;
                label.Text = "Call_ID: abcdefghijklmnop" + i;
                _CallLabelCallID.Add(label);
            }
        }
        public void LoadCalls()
        {
            int i = 0;
            foreach (var b in _CallButtonDeletes)
            {
                i++;
                b.Location = new System.Drawing.Point(611, -45 + 50 * i);
                panel_FormCalls.Controls.Add(b);
            }


            i = 0;
            foreach (var b in _CallButtonListens)
            {
                i++;
                b.Location = new System.Drawing.Point(570, -45 + 50 * i);
                panel_FormCalls.Controls.Add(b);
            }

            i = 0;
            foreach (var b in _CallButtonInfos)
            {
                i++;
                b.Location = new System.Drawing.Point(531, -45 + 50 * i);
                panel_FormCalls.Controls.Add(b);
            }

            i = 0;
            foreach (var b in _CallLabelCallID)
            {
                i++;
                b.Location = new System.Drawing.Point(100, -45 + 50 * i);
                panel_FormCalls.Controls.Add(b);
            }
        }

        private string GetCall_ID()
        {
            foreach (var b in _CallLabelCallID.ToArray())
                if (b.Name == "lblCall_ID" + IdClick)
                    return b.Text;
            return "";
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            IdClick = (sender as Button).Name.Substring(6, (sender as Button).Name.Length - 6);
            string tempCallname = GetCall_ID();
            DialogResult dialogResult = MessageBox.Show($"Bạn có chắc xóa {tempCallname} không?", "Xóa cuộc gọi", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                _CallButtonDeletes.Remove((sender as Button));

                foreach (var b in _CallButtonInfos.ToArray())
                    if (b.Name == "info" + IdClick)
                        _CallButtonInfos.Remove(b);

                foreach (var b in _CallButtonListens.ToArray())
                    if (b.Name == "listen" + IdClick)
                        _CallButtonListens.Remove(b);

                foreach (var b in _CallLabelCallID.ToArray())
                    if (b.Name == "lblCall_ID" + IdClick)
                        _CallLabelCallID.Remove(b);
                panel_FormCalls.Controls.Clear();
                LoadCalls();
            }



        }

        private void Listen_Click(object sender, EventArgs e)
        {
            IdClick = (sender as Button).Name.Substring(6, (sender as Button).Name.Length - 6);
            MessageBox.Show("Click on listen  " + GetCall_ID());
        }
        private void Info_Click(object sender, EventArgs e)
        {
            IdClick = (sender as Button).Name.Substring(4, (sender as Button).Name.Length - 4);
            MessageBox.Show("Click on Info " + GetCall_ID());
        }
    }
}
