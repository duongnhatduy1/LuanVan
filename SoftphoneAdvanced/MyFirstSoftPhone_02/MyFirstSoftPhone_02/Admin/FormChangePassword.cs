using MyFirstSoftPhone_02.Pattern;
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
    public partial class FormChangePassword : Form
    {
        private string _old, _new, _again;
        public FormChangePassword()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        int CheckInfo()
        {
            _old = tbOld.Text.Trim();
            _new = tbNew.Text.Trim();
            _again = tbAgain.Text.Trim();
            if (_old.Length<6)
            {
                MessageBox.Show("Mật khẩu cũ không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbOld.Focus();
                return 0;
            }
            else if (_new.Length < 6)
            {
                MessageBox.Show("Mât khẩu tối thiểu 6 ký tự!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbNew.Focus();
                return 0;
            }
            else if (_again != _new)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbAgain.Focus();
                return 0;
            }
            
            return 1;
        }

        async System.Threading.Tasks.Task RunAsyncPostChangePassword()
        {
            var parameters = new Dictionary<string, string>();
            parameters["token"] = Global.token;
            parameters["oldpassword"] = _old;
            parameters["newPassword"] = _new;
            parameters["rePassword"] = _again;

            using (var client = new HttpClient())
            {
                // Gắn header
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // Gọi API
                var response = client.PostAsync($"http://192.168.1.211/api/changePassword", new FormUrlEncodedContent(parameters)).Result;

                // Đọc dữ liệu trả về
                string resultContent = response.Content.ReadAsStringAsync().Result;
                if (resultContent.Contains("successfully"))
                {
                    MessageBox.Show("Đổi mật khẩu thành công", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Mã khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckInfo() == 1)
            {
                RunAsyncPostChangePassword().Wait();
                this.Dispose();
            }

        }
    }
}
