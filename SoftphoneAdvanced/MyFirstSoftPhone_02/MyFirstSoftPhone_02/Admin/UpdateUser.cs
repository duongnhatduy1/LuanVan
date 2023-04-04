using MyFirstSoftPhone_02.Pattern;
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
    public partial class UpdateUser : Form
    {
        User _user;
        public UpdateUser(User u)
        {
            InitializeComponent();
            _user = u;
            LoadData();
        }

        private void LoadData()
        {
            tbUsername.Text = _user.username;
            tbDisplayname.Text = _user.Display_Name;
            tbDepartment.Text = _user.Department_ID;
            tbEmail.Text = _user.email;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Bạn có chắc muốn cập nhật thông tin username {_user.username} không?", "Cập nhật người dùng", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show($"Bạn đã cập nhật thành công username {_user.username}");
            }
        }
    }
}
