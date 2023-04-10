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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstSoftPhone_02.HistoryCalls
{
    public partial class FormCallsHistory : Form
    {
        User _me;
        List<InfoCall> _history = new List<InfoCall>();
        List<Label> _CallLabelCallID = new List<Label>();
        List<Button> _CallButtonDeletes = new List<Button>();
        List<Button> _CallButtonListens = new List<Button>();
        SoundPlayer _Sound;
        public FormCallsHistory(User u)
        {
            _me = u;
            InitializeComponent();
            FakeData();
            LoadData();
        }

        void FakeData()
        {
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
            var data = JsonConvert.DeserializeObject<CallInfoList>(json);
            _history = data.CallInfoLists;
        }



        private void LoadData()
        {
            int i = 0; //for (int j = 1; j<=10; j++)
            foreach (var u in _history)
            {
                i++;
                //button listen
                var nguoidung = new System.Windows.Forms.Button();
                nguoidung.Location = new System.Drawing.Point(400, -57 + 100 * i);
                nguoidung.Name = u.Content + " " + u.Call_ID;
                nguoidung.Size = new System.Drawing.Size(35, 35);
                nguoidung.TabIndex = 1;
                nguoidung.UseVisualStyleBackColor = true;
                nguoidung.Image = global::MyFirstSoftPhone_02.Properties.Resources.listen;
                nguoidung.Cursor = System.Windows.Forms.Cursors.Hand;
                panelHistory.Controls.Add(nguoidung);
                _CallButtonListens.Add(nguoidung);
                nguoidung.Click += new System.EventHandler(Listen_Click);
                

                //label Call-ID
                var label = new System.Windows.Forms.Label();
                panelHistory.Controls.Add(label);
                label.AutoSize = true;
                label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                label.Location = new System.Drawing.Point(20, -80 + 100 * i);
                label.Name = "lblCall_ID" + u.Call_ID;
                label.Size = new System.Drawing.Size(251, 80);
                label.BackColor = System.Drawing.Color.Lime;
                label.TabIndex = 3;
                label.Text = $"Call-ID: {u.Call_ID}\nNgười gọi: {u.Caller_detail.Display_Name}\n" +
                    $"Thời gian gọi: {u.Time_Start}\nThời gian kết thúc: {u.Time_End}";
                _CallLabelCallID.Add(label);


                //button delete
                nguoidung = new System.Windows.Forms.Button();
                nguoidung.Location = new System.Drawing.Point(441, -57 + 100 * i);
                nguoidung.Name = u.Call_ID;
                nguoidung.Size = new System.Drawing.Size(35, 35);
                nguoidung.TabIndex = 1;
                nguoidung.UseVisualStyleBackColor = true;
                nguoidung.Image = global::MyFirstSoftPhone_02.Properties.Resources.delete;
                nguoidung.Cursor = System.Windows.Forms.Cursors.Hand;
                panelHistory.Controls.Add(nguoidung);
                _CallButtonDeletes.Add(nguoidung);
                nguoidung.Click += new System.EventHandler(Delete_Click);
            }



        }


        private void Delete_Click(object sender, EventArgs e)
        {
            string tempCallID = (sender as Button).Name;
            DialogResult dialogResult = MessageBox.Show($"Bạn có chắc xóa Call_ID {tempCallID} không?", "Xóa cuộc gọi", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show($"Bạn đã xóa Call-ID {tempCallID}");
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
                using (WebClient client = new WebClient()) { 
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (_Sound != null) _Sound.Stop();
            this.Dispose();
        }
    }
}
