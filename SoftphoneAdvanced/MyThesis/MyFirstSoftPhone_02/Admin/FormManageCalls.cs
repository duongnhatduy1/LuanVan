using MyFirstSoftPhone_02.Pattern;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
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
        List<InfoCall> _InfoCalls = new List<InfoCall>();
        SoundPlayer _Sound;

        string IdClick = "";
        

        async System.Threading.Tasks.Task RunAsyncGetSessionByADmin()
        {

            using (var client = new HttpClient())
            {
                // Gắn header
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("token", Global.token);

                // Gọi API
                var response = client.GetAsync($"http://{Global.ServerInfo}/api/session").Result;


                // Đọc dữ liệu trả về
                string resultContent = response.Content.ReadAsStringAsync().Result;
                resultContent = "{\"CallInfoLists\": " + resultContent + "}";
                var data = JsonConvert.DeserializeObject<CallInfoList>(resultContent);
                _InfoCalls = data.CallInfoLists;
            }
        }

        public FormManageCalls()
        {
            InitializeComponent();
            RunAsyncGetSessionByADmin().Wait();
            InitCalls();
        }


        public void InitCalls()
        {
            int i = 0;
            foreach (var u in _InfoCalls)
            {
                i++;
                //button listen
                var nguoidung = new System.Windows.Forms.Button();
                nguoidung.Location = new System.Drawing.Point(570, -45 + 50 * i);
                nguoidung.Name = u.Content + " " + u.Call_ID;
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
                label.Name = "lblCall_ID" + u.Call_ID;
                label.Size = new System.Drawing.Size(251, 31);
                label.TabIndex = 3;
                label.Text = u.Call_ID;
                _CallLabelCallID.Add(label);

                //button info
                nguoidung = new System.Windows.Forms.Button();
                nguoidung.Location = new System.Drawing.Point(531, -45 + 50 * i);
                nguoidung.Name = "info" + label.Name;
                nguoidung.Size = new System.Drawing.Size(35, 35);
                nguoidung.TabIndex = 1;
                nguoidung.UseVisualStyleBackColor = true;
                nguoidung.Image = global::MyFirstSoftPhone_02.Properties.Resources.info;
                nguoidung.Cursor = System.Windows.Forms.Cursors.Hand;
                panel_FormCalls.Controls.Add(nguoidung);
                _CallButtonInfos.Add(nguoidung);
                nguoidung.Click += new System.EventHandler(Info_Click);

                //button delete
                nguoidung = new System.Windows.Forms.Button();
                nguoidung.Location = new System.Drawing.Point(611, -45 + 50 * i);
                nguoidung.Name = u.Call_ID;
                nguoidung.Size = new System.Drawing.Size(35, 35);
                nguoidung.TabIndex = 1;
                nguoidung.UseVisualStyleBackColor = true;
                nguoidung.Image = global::MyFirstSoftPhone_02.Properties.Resources.delete;
                nguoidung.Cursor = System.Windows.Forms.Cursors.Hand;
                panel_FormCalls.Controls.Add(nguoidung);
                _CallButtonDeletes.Add(nguoidung);
                nguoidung.Click += new System.EventHandler(Delete_Click);
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

        async System.Threading.Tasks.Task RunAsyncDeleteSessionByAdmin(string u)
        {
            var parameters = new Dictionary<string, string>();
            parameters["Call_ID"] = u;
            parameters["method"] = "delete";
            using (var client = new HttpClient())
            {
                // Gắn header
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("token", Global.token);

                // Gọi API
                var response = client.PostAsync($"http://{Global.ServerInfo}/api/session", new FormUrlEncodedContent(parameters)).Result;

                // Đọc dữ liệu trả về
                string resultContent = response.Content.ReadAsStringAsync().Result;
                if (resultContent.Contains("successfully"))
                {

                    MessageBox.Show($"Đã xóa Call_ID: {u}", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xóa không thành công, vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string tempCallID = (sender as Button).Name;
            DialogResult dialogResult = MessageBox.Show($"Bạn có chắc xóa Call_ID {tempCallID} không?", "Xóa cuộc gọi", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                RunAsyncDeleteSessionByAdmin(tempCallID).Wait();
                RunAsyncGetSessionByADmin().Wait();
                InitCalls();
            }
        }

        private void Listen_Click(object sender, EventArgs e)
        {
            string temp = (sender as Button).Name;
            int pos = temp.IndexOf(" ");
            string url = temp.Substring(0, pos);
            string fileName = temp.Substring(pos + 1, temp.Length - pos - 1);
            fileName = "../../sound/" + fileName + ".wav";

            if (!File.Exists(fileName))
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile(url, fileName);
                }

            if (_Sound != null) _Sound.Stop();

            if ((sender as Button).TabIndex == 3)
            {
                (sender as Button).Image = global::MyFirstSoftPhone_02.Properties.Resources.listen;
                if (_Sound != null) _Sound.Stop();
                (sender as Button).TabIndex = 1;
                return;
            }
            var o = _CallButtonListens.Find(a => a.TabIndex == 3);
            if (o != null)
            {
                o.TabIndex = 1;
                o.Image = global::MyFirstSoftPhone_02.Properties.Resources.listen;
            }


            (sender as Button).Image = global::MyFirstSoftPhone_02.Properties.Resources.nolisten;
            (sender as Button).TabIndex = 3;
            using (_Sound = new SoundPlayer(fileName))
            {
                _Sound.Play();
            }
            
        }
        private void Info_Click(object sender, EventArgs e)
        {
            string CallID = (sender as Button).Name.Substring(14, (sender as Button).Name.Length - 14);
            var u = _InfoCalls.SingleOrDefault(p => p.Call_ID == CallID);
            string info = $"Call-ID : {u.Call_ID}\n\n" +
                          $"Nguoi goi: {u.Caller_detail.Display_Name}\n\n" +
                          $"Nguoi nghe: {u.Callee_detail.Display_Name}\n\n" +
                          $"Cuộc gọi bắt đầu lúc : {u.Time_Start}\n\n" +
                          $"Cuộc gọi kết thúc lúc: {u.Time_End}\n";

            MessageBox.Show(info, "Thông tin cuộc gọi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
