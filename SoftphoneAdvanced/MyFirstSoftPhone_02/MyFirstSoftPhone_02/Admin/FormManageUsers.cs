using MyFirstSoftPhone_02.Pattern;
using Newtonsoft.Json;
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
        List<User> _UserOnlines = new List<User>();

        string IdClick = "";

        public FormManageUsers()
        {
            InitializeComponent();
            InitUsers();
        }


        public void InitUsers()
        {
            string json = @"{
         'Users': [
            {
            'id': 1,
            'username': 'tuhuuduc',
            'email': 'tuhuuduc01@gmail.com.vn',
            'IP': '192.168.1.3',
            'Port': 64852,
            'Display_Name': 'Hữu Đức',
            'Role_ID': 'ad',
            'Department_ID': 'Dev',
            'created_at': '2023-03-20 23:17:51',
            'updated_at': '2023-03-20 23:17:51',
            'Department_Name': 'Developer',
            'Role_Name': 'Admin'
            },
            {
            'id': 2,
            'username': 'dnduy',
            'email': 'dnduy@gmail.com.vn',
            'IP': '192.168.1.7',
            'Port': 57417,
            'Display_Name': 'Nhật Duy',
            'Role_ID': 'user',
            'Department_ID': 'QA',
            'created_at': '2023-03-20 23:17:51',
            'updated_at': '2023-03-20 23:17:51',
            'Department_Name': 'Quality Assurance',
            'Role_Name': 'user'
            },
{
            'id': 3,
            'username': 'dntruong',
            'email': 'dntruong@gmail.com.vn',
            'IP': '192.168.1.8',
            'Port': 57417,
            'Display_Name': 'Nhật Trường',
            'Role_ID': 'user',
            'Department_ID': 'IT',
            'created_at': '2023-03-21 23:17:51',
            'updated_at': '2023-03-21 23:17:51',
            'Department_Name': 'IT support',
            'Role_Name': 'user'
            },
{
            'id': 4,
            'username': 'vhtram',
            'email': 'vhtram@gmail.com.vn',
            'IP': '192.168.1.7',
            'Port': 57417,
            'Display_Name': 'Võ Huỳnh Trâm',
            'Role_ID': 'user',
            'Department_ID': 'PM',
            'created_at': '2023-03-23 23:17:51',
            'updated_at': '2023-03-23 23:17:51',
            'Department_Name': 'Project Manager',
            'Role_Name': 'user'
            }
            ]}";

            var data = JsonConvert.DeserializeObject<UserList>(json);
            _UserOnlines = data.Users;
            int i = 0;
            foreach (var u in _UserOnlines)
            {
                i++;
                //label username
                var label = new System.Windows.Forms.Label();
                panel_FormUsers.Controls.Add(label);
                label.AutoSize = true;
                label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                label.Location = new System.Drawing.Point(100, -45 + 50 * i);
                label.Name = "lblUsername" + u.username;
                label.Size = new System.Drawing.Size(251, 31);
                label.TabIndex = 3;
                label.Text = "User name: " + u.username;
                _userLabelUsernames.Add(label);

                //button delete
                var nguoidung = new System.Windows.Forms.Button();
                nguoidung.Location = new System.Drawing.Point(603, -45 + 50 * i);
                nguoidung.Name = u.username;
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
                nguoidung.Name = "info"+u.username;
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
                nguoidung.Name = "update" + u.username;
                nguoidung.Size = new System.Drawing.Size(27, 35);
                nguoidung.TabIndex = 1;
                nguoidung.UseVisualStyleBackColor = true;
                nguoidung.Image = global::MyFirstSoftPhone_02.Properties.Resources.update;
                nguoidung.Cursor = System.Windows.Forms.Cursors.Hand;
                panel_FormUsers.Controls.Add(nguoidung);
                _userButtonUpdates.Add(nguoidung);
                nguoidung.Click += new System.EventHandler(Update_Click);

                
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
            string tempUsername = (sender as Button).Name;
            DialogResult dialogResult = MessageBox.Show($"Bạn có chắc xóa username {tempUsername} không?", "Xóa người dùng", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //_userButtonDeletes.Remove((sender as Button));

                //foreach (var b in _userButtonInfos.ToArray())
                //    if (b.Name == "info" + IdClick)
                //        _userButtonInfos.Remove(b);

                //foreach (var b in _userButtonUpdates.ToArray())
                //    if (b.Name == "update" + IdClick)
                //        _userButtonUpdates.Remove(b);

                //foreach (var b in _userLabelUsernames.ToArray())
                //    if (b.Name == "lblUsername" + IdClick)
                //        _userLabelUsernames.Remove(b);
                //panel_FormUsers.Controls.Clear();
                //LoadUsers();
                MessageBox.Show($"Bạn đã xóa username {tempUsername}");
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            UpdateUser updateUser = null;
            string username = (sender as Button).Name.Substring(6, (sender as Button).Name.Length - 6);
            var u = _UserOnlines.SingleOrDefault(p => p.username == username);
            if (updateUser == null)
            {
                if (u != null)
                {
                    updateUser = new UpdateUser(u);
                    updateUser.ShowDialog();
                } 
                
            }
        }
        private void Info_Click(object sender, EventArgs e)
        {
            string username = (sender as Button).Name.Substring(4, (sender as Button).Name.Length - 4);
            var u = _UserOnlines.SingleOrDefault(p => p.username == username);
            string info =
                "======Thông Tin người dùng=====\n\n" +
                 $"ID: {u.id}\n\n" +
                 $"Username: {u.username}\n\n" +
                 $"Tên hiển thị: {u.Display_Name}\n\n" +
                 $"Bộ phận: {u.Department_Name}\n\n" +
                 $"Email: {u.email}\n\n" +
                 $"Địa chỉ IP: {u.IP}\n\n" +
                 $"Thời gian tạo: {u.created_at}\n\n" +
                 $"Thời gian cập nhật: {u.updated_at}\n";
            MessageBox.Show(info);
        }
    }
}
