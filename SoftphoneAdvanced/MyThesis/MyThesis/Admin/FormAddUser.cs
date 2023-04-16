using MyFirstSoftPhone_02.Pattern;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstSoftPhone_02.Admin
{
    public partial class FormAddUser : Form
    {
        User _me;
        string _username = "";
        string _password = "";
        string _displayName = "";
        string _department = "";
        string _email = "";
        string _role = "";
        string flag = "them";
        public List<Department> _departments = new List<Department>();
        async System.Threading.Tasks.Task RunAsyncGetDepartment()
        {

            using (var client = new HttpClient())
            {
                // Gắn header
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("token", Global.token);

                // Gọi API
                var response = client.GetAsync($"http://192.168.1.211/api/admin/department").Result;


                // Đọc dữ liệu trả về
                string resultContent = response.Content.ReadAsStringAsync().Result;
                resultContent = "{\"departments\": " + resultContent + "}";
                var data = JsonConvert.DeserializeObject<ListDepartment>(resultContent);
                _departments = data.departments;
            }
        }

        public FormAddUser()
        {
            InitializeComponent();
            RunAsyncGetDepartment().Wait();
            foreach(var i in _departments)
            {
                this.cbxDepartment.Items.Add(i.Name);
            }
            Process();
        }

        

        public FormAddUser(User u, string update)
        {
            _me = u;
            flag = update;
            InitializeComponent();
            Process_user();

        }

        void Process()
        {
            cbxRole.Text = "Người dùng";
            cbxDepartment.Text = "---chọn bộ phận---";
            tbUsername.Focus();

        }

        void Process_user()
        {
            cbxRole.Text = _me.Role_Name;
            cbxDepartment.Text = _me.Department_Name;
            tbUsername.Text = _me.username;
            tbDisplayName.Text = _me.Display_Name;
            tbEmail.Text = _me.email;
            tbUsername.Enabled = false;
            tbPassword.Text = "@@@@@@@@@@@@";
            tbPassword.Enabled = false;
            if (flag == "thongtin") cbxDepartment.Enabled = false;
            if (flag == "thongtin") cbxRole.Enabled = false;
            if (flag == "thongtin") tbEmail.Enabled = false;
            if (flag == "thongtin") tbDisplayName.Enabled = false;
            if (flag == "thongtin") btnSave.Visible = false;

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
            else if (cbxDepartment.Text == "---chọn bộ phận---")
            {
                MessageBox.Show("Bạn chưa chọn bộ phận!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbxDepartment.Focus();
                return 0;
            }
            return 1;
        }


        async System.Threading.Tasks.Task RunAsyncPostUser()
        {
            var p = _departments.Find( o => o.Name == _department);
            string departmentID = p.Department_ID;
            var parameters = new Dictionary<string, string>();
            parameters["username"] = _username;
            parameters["password"] = _password;
            parameters["Display_Name"] = _displayName;
            parameters["Department_ID"] = departmentID;
            parameters["email"] = _email;
            parameters["Role_ID"] = _role;

   
            using (var client = new HttpClient())
            {
                // Gắn header
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("token", Global.token);

                // Gọi API
                var response = client.PostAsync($"http://192.168.1.211/api/admin/account", new FormUrlEncodedContent(parameters)).Result;

                // Đọc dữ liệu trả về
                string resultContent = response.Content.ReadAsStringAsync().Result;
                if (resultContent.Contains("successfully"))
                {
                    string info =
                    "======Thông Tin người dùng=====\n\n" +
                     $"Username: {_username}\n\n" +
                     $"Password: {_password}\n\n" +
                     $"Tên hiển thị: {_displayName}\n\n" +
                     $"Bộ phận: {_department}\n\n" +
                     $"Quyền: {_role}\n\n" +
                     $"Email: {_email}\n";
                    MessageBox.Show(info, "Thêm thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Username {_username} đã tồn tại trước đó!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }


        async System.Threading.Tasks.Task RunAsyncPutUserByAdmin()
        {
            var p = _departments.Find(o => o.Name == _department);
            string departmentID = p.Department_ID;
            var parameters = new Dictionary<string, string>();
            parameters["username"] = _username;
            parameters["Display_Name"] = _displayName;
            parameters["Department_ID"] = departmentID;
            parameters["email"] = _email;
            parameters["Role_ID"] = _role;
            parameters["method"] = "update";


            using (var client = new HttpClient())
            {
                // Gắn header
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("token", Global.token);

                // Gọi API
                var response = client.PostAsync($"http://192.168.1.211/api/admin/account", new FormUrlEncodedContent(parameters)).Result;

                // Đọc dữ liệu trả về
                string resultContent = response.Content.ReadAsStringAsync().Result;
                if (resultContent.Contains("successfully"))
                {
                    string info =
                    "======Thông Tin người dùng sau khi cập nhật=====\n\n" +
                     $"Username: {_username}\n\n" +
                     $"Tên hiển thị: {_displayName}\n\n" +
                     $"Bộ phận: {_department}\n\n" +
                     $"Quyền: {_role}\n\n" +
                     $"Email: {_email}\n";
                    MessageBox.Show(info, "Cập nhật thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Username {_username} không tồn tại trước đó!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (flag == "them")
            {
                if (CheckInfo() == 1)
                {
                    RunAsyncPostUser().Wait();
                    this.Dispose();
                }
            }
            else
            if (flag == "update")
                if (CheckInfo() == 1)
                {
                    RunAsyncPutUserByAdmin().Wait();
                    this.Dispose();
                }
            
        }

        private void btbUpdateDepartment_Click(object sender, EventArgs e)
        {
            FormUpdateDepartment f = null;
            if (f == null)
            {
                f = new FormUpdateDepartment(_departments);
                f.ShowDialog();
            }
        }
    }
}
