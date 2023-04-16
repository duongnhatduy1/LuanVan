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
    public partial class FormUpdateDepartment : Form
    {
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


        async System.Threading.Tasks.Task RunAsyncPostDepartment()
        {
            var parameters = new Dictionary<string, string>();
            parameters["Department_ID"] = tbDepartmentID.Text.Trim();
            parameters["Name"] = tbDepartmentName.Text.Trim();
            using (var client = new HttpClient())
            {
                // Gắn header
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("token", Global.token);

                // Gọi API
                var response = client.PostAsync($"http://192.168.1.211/api/admin/department", new FormUrlEncodedContent(parameters)).Result;

                // Đọc dữ liệu trả về
                string resultContent = response.Content.ReadAsStringAsync().Result;
                if (resultContent.Contains("successfully"))
                {
                    RunAsyncGetDepartment().Wait();
                    //in lại dữ liệu
                    string padding = "------------------------------>";
                    lblContent.Items.Clear();
                    foreach (var m in _departments)
                    {
                        lblContent.Items.Add($"{m.Department_ID,25}   {padding}   {m.Name}\n");
                    }
                    MessageBox.Show("Thêm bộ phận thành công", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Mã bộ phận đã tồn tại trước đó!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        async System.Threading.Tasks.Task RunAsyncPutDepartment()
        {
            var parameters = new Dictionary<string, string>();
            parameters["Department_ID"] = tbDepartmentID.Text.Trim();
            parameters["Name"] = tbDepartmentName.Text.Trim();
            parameters["method"] = "update";
            using (var client = new HttpClient())
            {
                // Gắn header
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("token", Global.token);

                // Gọi API
                var response = client.PostAsync($"http://192.168.1.211/api/admin/department", new FormUrlEncodedContent(parameters)).Result;

                // Đọc dữ liệu trả về
                string resultContent = response.Content.ReadAsStringAsync().Result;
                if (resultContent.Contains("successfully"))
                {
                    RunAsyncGetDepartment().Wait();
                    //in lại dữ liệu
                    string padding = "------------------------------>";
                    lblContent.Items.Clear();
                    foreach (var m in _departments)
                    {
                        lblContent.Items.Add($"{m.Department_ID,25}   {padding}   {m.Name}\n");
                    }
                    MessageBox.Show("Chỉnh sửa bộ phận thành công", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Mã bộ phận không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        public FormUpdateDepartment(List<Department> d)
        {
            string padding = "------------------------------>";
            _departments = d;
            InitializeComponent();
            foreach (var m in _departments)
            {
                lblContent.Items.Add($"{m.Department_ID,25}   {padding}   {m.Name}\n");
            }
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (cbxOption.Text == "Thêm")
            {
                RunAsyncPostDepartment().Wait();
            }
            else
            {
                RunAsyncPutDepartment().Wait();
            }
        }
    }
}
