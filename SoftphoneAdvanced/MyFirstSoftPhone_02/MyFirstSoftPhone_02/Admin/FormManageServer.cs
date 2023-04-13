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
    public partial class FormManageServer : Form
    {
        List<Label> _UserOnlines = new List<Label>();
        List<Label> _UserOfflines = new List<Label>();
        List<UserStatus> _onlines = new List<UserStatus>();
        List<UserStatus> _offlines = new List<UserStatus>();
//        string json = @"
//{
//    'online': [
//        {
//            'username': 'dnduy',
//            'IP': '192.168.1.4'
//        }
//    ],
//    'offline': [
//        {
//            'username': 'duc',
//            'IP': ''
//        },
//        {
//            'username': 'username',
//            'IP': null
//        }
//    ]
//}
//";


        async System.Threading.Tasks.Task RunAsync()
        {
            
            using (var client = new HttpClient())
            {
                // Gắn header
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("token", Global.token);

                // Gọi API
                var response = client.GetAsync("http://192.168.1.211/api/activity").Result;


                // Đọc dữ liệu trả về
                string resultContent = response.Content.ReadAsStringAsync().Result;
                var data = JsonConvert.DeserializeObject<ListUserStatus>(resultContent);
                _onlines = data.online;
                _offlines = data.offline;
            }
        }
        public FormManageServer()
        {
            InitializeComponent();
            RunAsync().Wait();
            Init();
        }

        public void Init()
        {
            int i = 0;
            foreach (var u in _onlines)
            {
                //user online
                i++;
                var label = new System.Windows.Forms.Label();
                panelOnl.Controls.Add(label);
                label.AutoSize = true;
                label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                label.Location = new System.Drawing.Point(20, -20 + 30 * i);
                label.Name = u.username;
                label.Size = new System.Drawing.Size(150, 20);
                label.TabIndex = 3;
                label.Text = $"username: {u.username}";
                _UserOnlines.Add(label);
            }
            i = 0;
            foreach (var u in _offlines) {
                //user offline
                i++;
                var label = new System.Windows.Forms.Label();
                panelOff.Controls.Add(label);
                label.AutoSize = true;
                label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                label.Location = new System.Drawing.Point(20, -20 + 30 * i);
                label.Name = u.username;
                label.Size = new System.Drawing.Size(150, 20);
                label.TabIndex = 3;
                label.Text = $"username: {u.username}";
                _UserOfflines.Add(label);
            }
        }

        private void btnStartServer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Server đã được bật!");
        }

        private void btnStopServer_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Bạn có chắc xóa muốn tắt Server không?", "Tắt Server", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Server đã tắt!");
            }
        }
    }
}
