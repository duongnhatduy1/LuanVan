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
    public partial class FormManageUsers : Form
    {
        List<Label> _userLabelUsernames = new List<Label>();
        List<Button> _userButtonDeletes = new List<Button>();
        List<Button> _userButtonUpdates = new List<Button>();
        List<Button> _userButtonInfos = new List<Button>();
        string IdClick = "";

        public FormManageUsers()
        {
            InitializeComponent();
            InitUsers();
        }


        public void InitUsers()
        {
            for (int i = 1; i < 31; i++)
            {
                //button delete
                var nguoidung = new System.Windows.Forms.Button();
                nguoidung.Location = new System.Drawing.Point(603, -45 + 50 * i);
                nguoidung.Name = "delete"+i;
                nguoidung.Size = new System.Drawing.Size(35, 35);
                nguoidung.TabIndex = 1;
                nguoidung.UseVisualStyleBackColor = true;
                nguoidung.Image = global::MyFirstSoftPhone_02.Properties.Resources.delete;
                nguoidung.Cursor = System.Windows.Forms.Cursors.Hand;
                panel_FormUsers.Controls.Add(nguoidung);
                _userButtonDeletes.Add(nguoidung);
                nguoidung.Click += new System.EventHandler(Delete_Click);

                //button info
                nguoidung = new System.Windows.Forms.Button();
                nguoidung.Location = new System.Drawing.Point(531, -45 + 50 * i);
                nguoidung.Name = "info"+i;
                nguoidung.Size = new System.Drawing.Size(35, 35);
                nguoidung.TabIndex = 1;
                nguoidung.UseVisualStyleBackColor = true;
                nguoidung.Image = global::MyFirstSoftPhone_02.Properties.Resources.info;
                nguoidung.Cursor = System.Windows.Forms.Cursors.Hand;
                panel_FormUsers.Controls.Add(nguoidung);
                _userButtonInfos.Add(nguoidung);
                nguoidung.Click += new System.EventHandler(Info_Click);

                //button update
                nguoidung = new System.Windows.Forms.Button();
                nguoidung.Location = new System.Drawing.Point(570, -45 + 50 * i);
                nguoidung.Name = "update" + i;
                nguoidung.Size = new System.Drawing.Size(27, 35);
                nguoidung.TabIndex = 1;
                nguoidung.UseVisualStyleBackColor = true;
                nguoidung.Image = global::MyFirstSoftPhone_02.Properties.Resources.update;
                nguoidung.Cursor = System.Windows.Forms.Cursors.Hand;
                panel_FormUsers.Controls.Add(nguoidung);
                _userButtonUpdates.Add(nguoidung);
                nguoidung.Click += new System.EventHandler(Update_Click);

                //label username
                var label = new System.Windows.Forms.Label();
                panel_FormUsers.Controls.Add(label);
                label.AutoSize = true;
                label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                label.Location = new System.Drawing.Point(100, -45 + 50 * i);
                label.Name = "lblUsername" +i;
                label.Size = new System.Drawing.Size(251, 31);
                label.TabIndex = 3;
                label.Text = "User name: duongnhatduy "+ i;
                _userLabelUsernames.Add(label);
            }
        }
        public void LoadUsers()
        {
            int i = 0;
            foreach(var b in _userButtonDeletes)
            {
                i++;
                b.Location = new System.Drawing.Point(603, -45 + 50*i);
                panel_FormUsers.Controls.Add(b);
            }


            i = 0;
            foreach (var b in _userButtonUpdates)
            {
                i++;
                b.Location = new System.Drawing.Point(570, -45 + 50 * i);
                panel_FormUsers.Controls.Add(b);
            }

            i = 0;
            foreach (var b in _userButtonInfos)
            {
                i++;
                b.Location = new System.Drawing.Point(531, -45 + 50 * i);
                panel_FormUsers.Controls.Add(b);
            }

            i = 0;
            foreach (var b in _userLabelUsernames)
            {
                i++;
                b.Location = new System.Drawing.Point(100, -45 + 50 * i);
                panel_FormUsers.Controls.Add(b);
            }
        }

        private string GetUsername()
        {
            foreach (var b in _userLabelUsernames.ToArray())
                if (b.Name == "lblUsername" + IdClick)
                    return b.Text;
            return "";
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            IdClick = (sender as Button).Name.Substring(6, (sender as Button).Name.Length - 6);
            string tempUsername = GetUsername();
            DialogResult dialogResult = MessageBox.Show($"Bạn có chắc xóa {tempUsername} không?", "Xóa người dùng", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                _userButtonDeletes.Remove((sender as Button));

                foreach (var b in _userButtonInfos.ToArray())
                    if (b.Name == "info" + IdClick)
                        _userButtonInfos.Remove(b);

                foreach (var b in _userButtonUpdates.ToArray())
                    if (b.Name == "update" + IdClick)
                        _userButtonUpdates.Remove(b);

                foreach (var b in _userLabelUsernames.ToArray())
                    if (b.Name == "lblUsername" + IdClick)
                        _userLabelUsernames.Remove(b);
                panel_FormUsers.Controls.Clear();
                LoadUsers();
            }
            
            
            
        }

        private void Update_Click(object sender, EventArgs e)
        {
            IdClick = (sender as Button).Name.Substring(6, (sender as Button).Name.Length - 6);
            MessageBox.Show("Click on Update  " + GetUsername());
        }
        private void Info_Click(object sender, EventArgs e)
        {
            IdClick = (sender as Button).Name.Substring(4, (sender as Button).Name.Length - 4);
            MessageBox.Show("Click on Info " + GetUsername());
        }
    }
}
