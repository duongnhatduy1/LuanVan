using MyFirstSoftPhone_02.Pattern;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
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

        string IdClick = "";
        string json = @"{ 'CallInfoLists' :
        [ {
        'Call_ID': 'afdsklfkdsfhk',
        'Caller_Username': 'tuhuuduc',
        'Callee_Username': 'dnduy',
        'Time_Start': '2023-03-22 09:04:01',
        'Time_End': '2023-03-22 09:04:55',
        'Content': 'https://drive.google.com/uc?export=view&id=11C5HuWQkQ_jU7k6_uWNRC5c0PlanpS8p',
        'Caller_detail': {
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
        'Callee_detail': {
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
        'Call_Detail':
            {
                'Call_ID': 'afdsklfkdsfhk',
                'Source_IP': '192.168.1.7',
                'Source_Port': 64049,
                'Destination_IP': '192.168.1.7',
                'Destination_Port': 57417,
                'Sdp_Port': 8080
            }
       
    },
    {
        'Call_ID': '12345678910',
        'Caller_Username': '12345678910',
        'Callee_Username': '12345678910',
        'Time_Start': '2023-03-22 09:04:01',
        'Time_End': '2023-03-22 09:04:55',
        'Content': 'https://drive.google.com/uc?export=view&id=1T5sKSx8_bomCAfT_TXryqjeZoUj3jycG',
        'Caller_detail': {
            'id': 1,
            'username': '12345678910',
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
        'Callee_detail': {
            'id': 2,
            'username': '12345678910',
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
        'Call_Detail':
            {
                'Call_ID': '12345678910',
                'Source_IP': '192.168.1.7',
                'Source_Port': 64049,
                'Destination_IP': '192.168.1.7',
                'Destination_Port': 57417,
                'Sdp_Port': 8080
            }
       
    },
    {
        'Call_ID': 'abcdefgh',
        'Caller_Username': 'abcdefgh',
        'Callee_Username': 'abcdefgh',
        'Time_Start': '2023-03-22 09:04:01',
        'Time_End': '2023-03-22 09:04:55',
        'Content': 'https://drive.google.com/uc?export=view&id=1ILYHY0BWAmarparZwjwfkDKh2Y4wTgfy',
        'Caller_detail': {
            'id': 1,
            'username': 'abcdefgh',
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
        'Callee_detail': {
            'id': 2,
            'username': 'abcdefgh',
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
        'Call_Detail':
            {
                'Call_ID': 'abcdefgh',
                'Source_IP': '192.168.1.7',
                'Source_Port': 64049,
                'Destination_IP': '192.168.1.7',
                'Destination_Port': 57417,
                'Sdp_Port': 8080
            }
       
    }]}";

        public FormManageCalls()
        {
            InitializeComponent();
            var data = JsonConvert.DeserializeObject<CallInfoList>(json);
            _InfoCalls = data.CallInfoLists;
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
                nguoidung.Name = u.Content;
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
        private void Delete_Click(object sender, EventArgs e)
        {
            string tempCallID = (sender as Button).Name;
            DialogResult dialogResult = MessageBox.Show($"Bạn có chắc xóa Call_ID {tempCallID} không?", "Xóa cuộc gọi", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //_CallButtonDeletes.Remove((sender as Button));

                //foreach (var b in _CallButtonInfos.ToArray())
                //    if (b.Name == "info" + IdClick)
                //        _CallButtonInfos.Remove(b);

                //foreach (var b in _CallButtonListens.ToArray())
                //    if (b.Name == "listen" + IdClick)
                //        _CallButtonListens.Remove(b);

                //foreach (var b in _CallLabelCallID.ToArray())
                //    if (b.Name == "lblCall_ID" + IdClick)
                //        _CallLabelCallID.Remove(b);
                //panel_FormCalls.Controls.Clear();
                //LoadCalls();
                //viet code get cuộc gọi mới
                MessageBox.Show($"Bạn đã xóa Call-ID {tempCallID}");
            }
        }

        private void Listen_Click(object sender, EventArgs e)
        {
            string url = (sender as Button).Name;
            SoundPlayer Sound = new SoundPlayer(url);
            //InfoCall data = JsonConvert.DeserializeObject<InfoCall>(json);
            if ((sender as Button).TabIndex == 3)
            {
                (sender as Button).Image = global::MyFirstSoftPhone_02.Properties.Resources.listen;
                Sound.Stop();
                (sender as Button).TabIndex = 1;
                return;
            }
            foreach (var u in _CallButtonListens.ToArray())
            {
                u.TabIndex = 1;
                u.Image = global::MyFirstSoftPhone_02.Properties.Resources.listen;
            }
            (sender as Button).TabIndex = 3;
            (sender as Button).Image = global::MyFirstSoftPhone_02.Properties.Resources.nolisten;
            Sound.Play();
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
