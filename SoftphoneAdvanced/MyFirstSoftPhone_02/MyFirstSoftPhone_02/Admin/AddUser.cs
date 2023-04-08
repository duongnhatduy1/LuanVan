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
    public partial class AddUser : Form
    {
        User _me;
        string _username = "";
        string _password = "";
        string _displayName = "";
        string _department = "";
        string _email = "";
        string _role = "";
        public AddUser()
        {
            InitializeComponent();
            Process();
        }

        public AddUser(User u)
        {
            _me = u;
            InitializeComponent();
            Process_user();
        }

        void Process()
        {
            cbxRole.Text = "Người dùng";
            cbxDepartment.Text = "Kế toán";
            tbUsername.Focus();

        }

        void Process_user()
        {
            cbxRole.Text = _me.Role_Name;
            cbxDepartment.Text = _me.Department_Name;
            tbUsername.Text = _me.username;
            tbDisplayName.Text = _me.Display_Name;
            tbEmail.Text = _me.email;
            cbxRole.Enabled = false;
            tbUsername.Enabled = false;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        int CheckInfo()
        {
            _username = tbUsername.Text.Trim();
            _password = tbPassword.Text.Trim();
            _email = tbEmail.Text.Trim();
            _displayName = tbDisplayName.Text.Trim();
            _role = cbxRole.Text.ToString();
            _department = cbxDepartment.Text.ToString();
            if (_username == "")
            {
                MessageBox.Show("Bạn phải điền Username!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbUsername.Focus();
                return 0;
            }
            else if (_password.Length < 5) 
            {
                MessageBox.Show("Mât khẩu tối thiểu 6 ký tự!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbPassword.Focus();
                return 0;
            }
            else if (_displayName == "")
            {
                MessageBox.Show("Tên hiển thị không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbDisplayName.Focus();
                return 0;
            }
            else if (_email == "")
            {
                MessageBox.Show("Email không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbEmail.Focus();
                return 0;
            }
            return 1;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckInfo() == 1)
            {
                string info =
                "======Thông Tin người dùng=====\n\n" +
                 $"Username: {_username}\n\n" +
                 $"Password: {_password}\n\n" +
                 $"Tên hiển thị: {_displayName}\n\n" +
                 $"Bộ phận: {_department}\n\n" +
                 $"Quyền: {_role}\n\n" +
                 $"Email: {_email}\n";

                MessageBox.Show(info);
                this.Dispose();
            }
        }
    }
}
