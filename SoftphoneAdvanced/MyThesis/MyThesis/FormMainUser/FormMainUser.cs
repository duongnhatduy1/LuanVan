using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using MyFirstSoftPhone_02.Admin;
using MyFirstSoftPhone_02.Handle_Message;
using MyFirstSoftPhone_02.HistoryCalls;
using MyFirstSoftPhone_02.Pattern;
using Newtonsoft.Json;
using Ozeki.Media;
using Ozeki.VoIP;

namespace MyFirstSoftPhone_02
{
    public partial class FormMainUser : Form
    {
        List<Label> _UserOnlineLabel = new List<Label>();
        List<Button> _ButtonsChat = new List<Button>();
        List<Button> _UserOnlineInfos = new List<Button>();
        List<User> _UserOnlines = new List<User>();
        public User _me;
        private UserInfo userInfo;
        private ISoftPhone softPhone;
        private IPhoneLine phoneLine;
        private RegState phoneLineInformation;
        private IPhoneCall call;
        private Microphone microphone = Microphone.GetDefaultDevice();
        private Speaker speaker = Speaker.GetDefaultDevice();
        MediaConnector connector = new MediaConnector();
        PhoneCallAudioSender mediaSender = new PhoneCallAudioSender();
        PhoneCallAudioReceiver mediaReceiver = new PhoneCallAudioReceiver();
        MP3StreamPlayback _mp3Player = new MP3StreamPlayback("../../resources/test.mp3");
        FormDirectCalling direct_Calling;
        public FormMessage formMessage;
        public event EventHandler<InstantMessage> IncomingMessage;
        private bool inComingCall;
        public string Receiver;
        public FormMainUser(User u)
        {
            _me = u;
            InitializeComponent();
            InitUseronline();
        }

        private void InitializeSoftPhone()
        {
            try
            {
                softPhone = SoftPhoneFactory.CreateSoftPhone(SoftPhoneFactory.GetLocalIP(), 5700, 5750);
                InvokeGUIThread(() => { lb_Log.Items.Add("Softphone created!"); });

                softPhone.IncomingCall += softPhone_inComingCall;

                SIPAccount sa = new SIPAccount(true, userInfo.UserName, userInfo.UserName, userInfo.UserName, userInfo.Password, userInfo.ServerIP, 5060);
                InvokeGUIThread(() => { lb_Log.Items.Add("SIP account logged!"); });

                phoneLine = softPhone.CreatePhoneLine(sa);
                phoneLine.RegistrationStateChanged += phoneLine_PhoneLineInformation;
                phoneLine.InstantMessaging.MessageReceived += mySoftphone_IncomingMessage;
                InvokeGUIThread(() => { lb_Log.Items.Add("Phoneline created."); });
                softPhone.RegisterPhoneLine(phoneLine);

                lbl_NumberToDial.Text = string.Empty;

                lbl_UserLogin.Text = "Hi : " + userInfo.UserName;

            }
            catch (Exception ex)
            {
                InvokeGUIThread(() => { lb_Log.Items.Add("Local IP error!"); });
            }
        }



        void mySoftphone_IncomingMessage(object sender, InstantMessage e)
        {
            //Console.WriteLine("\nMessage received from {0}: {1}", e.Sender, e.Content);
            int i = e.Sender.IndexOf("@");
            Receiver = e.Sender.Substring(0, i);

            var content = new System.Text.StringBuilder("");
            content.Append(Receiver);
            content.Append(": ");
            content.Append(e.Content);
            content.Append("\n");
            if (formMessage == null)
            {
                formMessage = new FormMessage(this, Receiver);
                formMessage.lblMessageInfo.Text = Receiver;
                InvokeGUIThread(() => { formMessage.lblMessage.Items.Add(content.ToString()); });
                InvokeGUIThread(() => { formMessage.ShowDialog(); });
            }
            if (formMessage != null) InvokeGUIThread(() => { formMessage.lblMessage.Items.Add(content.ToString()); });
        }


        private void DispatchAsync(Action action)
        {
            ThreadPool.QueueUserWorkItem(o => action());
        }

        private void StartDevices()
        {
            if (microphone != null)
            {
                microphone.Start();
                InvokeGUIThread(() => { lb_Log.Items.Add("Microphone Started."); });
            }

            if (speaker != null)
            {
                speaker.Start();
                InvokeGUIThread(() => { lb_Log.Items.Add("Speaker Started."); });
            }
        }


        private void StopDevices()
        {
            if (microphone != null)
            {
                microphone.Stop();
                InvokeGUIThread(() => { lb_Log.Items.Add("Microphone Stopped."); });
            }

            if (speaker != null)
            {
                speaker.Stop();
                InvokeGUIThread(() => { lb_Log.Items.Add("Speaker Stopped."); });
            }
        }


        private void ConnectMedia()
        {
            if (microphone != null)
            {
                connector.Connect(microphone, mediaSender);
            }

            if (speaker != null)
            {
                connector.Connect(mediaReceiver, speaker);
            }
        }

        private void DisconnectMedia()
        {
            if (microphone != null)
            {
                connector.Disconnect(microphone, mediaSender);
            }

            if (speaker != null)
            {
                connector.Disconnect(mediaReceiver, speaker);
            }
        }


        private void InvokeGUIThread(Action action)
        {
            Invoke(action);
        }

        private void StartMP3()
        {
            connector.Connect(_mp3Player, speaker);
            _mp3Player.Start();
            speaker.Start();

        }

        private void StopMP3()
        {
            connector.Disconnect(_mp3Player, speaker);
            if (_mp3Player != null) _mp3Player.Stop();
        }

        private void softPhone_inComingCall(object sender, VoIPEventArgs<IPhoneCall> e)
        {
            InvokeGUIThread(() => { lb_Log.Items.Add("Incoming call from: " + e.Item.CallID.ToString()); });
            StartMP3();
            call = e.Item;
            WireUpCallEvents();
            inComingCall = true;
            direct_Calling = new FormDirectCalling(this);
            direct_Calling.lbl_CallerName.Text = e.Item.OtherParty.DisplayName;
            direct_Calling.ShowDialog();
        }


        private void phoneLine_PhoneLineInformation(object sender, RegistrationStateChangedArgs e)
        {
            phoneLineInformation = e.State;
            InvokeGUIThread(() =>
                {
                    if (phoneLineInformation == RegState.RegistrationSucceeded)
                    {
                        lb_Log.Items.Add("Registration succeeded - Online");
                        //string vnString = Encoding.Unicode.GetString(Encoding.Default.GetBytes("Xin chào, đây là một chuỗi Tiếng Việt!"));
                        //lb_Log.Items.Add(vnString);
                    }
                    else
                    {
                        lb_Log.Items.Add("Not registered - Offline: " + phoneLineInformation.ToString());
                    }
                });
        }


        private void call_CallStateChanged(object sender, CallStateChangedArgs e)
        {
            InvokeGUIThread(() => { lb_Log.Items.Add("Callstate changed." + e.State.ToString()); });

            if (e.State == CallState.Answered)
            {
                StartDevices();

                mediaReceiver.AttachToCall(call);
                mediaSender.AttachToCall(call);

                InvokeGUIThread(() => { lb_Log.Items.Add("Call started."); });
            }

            if (e.State.IsCallEnded() == true)
            {

                StopDevices();

                mediaReceiver.Detach();
                mediaSender.Detach();

                WireDownCallEvents();

                call = null;
                InvokeGUIThread(() => { lb_Log.Items.Add("Call ended."); });
            }
        }


        private void WireUpCallEvents()
        {
            call.CallStateChanged += (call_CallStateChanged);
        }

        private void WireDownCallEvents()
        {
            call.CallStateChanged -= (call_CallStateChanged);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeSoftPhone();
        }


        private void buttonKeyPadButton_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;

            if (call != null) { return; }

            if (btn == null) return;

            lbl_NumberToDial.Text += btn.Text.Trim();
        }

        private void buttonKeyDeleteButton_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;

            if (call != null) { return; }

            if (btn == null) return;
            var len = lbl_NumberToDial.Text.Length;
            if (len > 0)
            {
                lbl_NumberToDial.Text = lbl_NumberToDial.Text.Substring(0, len - 1);
            }

        }


        private void buttonKeyDeleteAllButton_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;

            if (call != null) { return; }

            if (btn == null) return;
            lbl_NumberToDial.Text = "";
            lbl_NumberToDial.Focus();
            //Direct_Calling direct_Calling = new Direct_Calling(this);
            //this.Visible = false;
            //this.Owner.Enabled = false;

        }
        public void btn_PickUp_Click(object sender, EventArgs e)
        {
            if (inComingCall)
            {
                inComingCall = false;
                StopMP3();
                ConnectMedia();
                call.Answer();

                InvokeGUIThread(() => { lb_Log.Items.Add("Call accepted."); });
                return;
            }


            if (call != null)
            {
                return;
            }

            if (phoneLineInformation != RegState.RegistrationSucceeded)
            {
                InvokeGUIThread(() => { lb_Log.Items.Add("Registration Failed!"); });
                return;
            }

            string callee = "";
            if ((sender as Button).Name.Substring(0, 4) == "call")
                callee = (sender as Button).Name.Substring(4, (sender as Button).Name.Length - 4);
            else
                callee = lbl_NumberToDial.Text;

            call = softPhone.CreateCallObject(phoneLine, callee);
            WireUpCallEvents();
            ConnectMedia();
            call.Start();
            
            direct_Calling = new FormDirectCalling(this);
            direct_Calling.lbl_CallerName.Text = callee;
            direct_Calling.ShowDialog();
                
            
        }

        public void btn_HangUp_Click(object sender, EventArgs e)
        {
            StopMP3();
            DisconnectMedia();

            if (call != null)
            {
                if (inComingCall && call.CallState == CallState.Ringing)
                {
                    call.Reject();
                    InvokeGUIThread(() => { lb_Log.Items.Add("Call rejected."); });
                }
                else
                {
                    call.HangUp();
                    inComingCall = false;
                    InvokeGUIThread(() => { lb_Log.Items.Add("Call hanged up."); });
                }

                call = null;
            }

            lbl_NumberToDial.Text = string.Empty;

        }

        private void lb_Log_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_NumberToDial_Click(object sender, EventArgs e)
        {

        }

        public void SendMessage(InstantMessage message)
        {
            phoneLine.InstantMessaging.SendMessage(message);
        }

        async System.Threading.Tasks.Task RunAsyncGetUserOnlines()
        {

            using (var client = new HttpClient())
            {
                // Gắn header
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("token", Global.token);

                // Gọi API
                var response = client.GetAsync($"http://192.168.1.211/api/account").Result;


                // Đọc dữ liệu trả về
                string resultContent = response.Content.ReadAsStringAsync().Result;
                resultContent = "{\"Users\": " + resultContent + "}";
                var data = JsonConvert.DeserializeObject<UserList>(resultContent);
                _UserOnlines = data.Users;
            }
        }
        public void InitUseronline()
        {
            RunAsyncGetUserOnlines().Wait();
            int i = 0;
            foreach (var u in _UserOnlines)
            {
                //button info
                i++;
                var nguoidung = new System.Windows.Forms.Button();
                nguoidung.Location = new System.Drawing.Point(160, -30 + 40 * i);
                nguoidung.Name = "info" + u.username;
                nguoidung.Size = new System.Drawing.Size(37, 35);
                nguoidung.TabIndex = 1;
                nguoidung.UseVisualStyleBackColor = true;
                nguoidung.Image = global::MyFirstSoftPhone_02.Properties.Resources.info;
                nguoidung.Cursor = System.Windows.Forms.Cursors.Hand;
                panel_online.Controls.Add(nguoidung);
                nguoidung.Click += new System.EventHandler(Info_Click);

                //label username online
                var label = new System.Windows.Forms.Label();
                panel_online.Controls.Add(label);
                label.AutoSize = true;
                label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                label.Location = new System.Drawing.Point(5, -22 + 40 * i);
                label.Name = "lblUsername" + u.username;
                label.Size = new System.Drawing.Size(75, 25);
                label.TabIndex = 3;
                label.Text = u.username;

                //button chat
                nguoidung = new System.Windows.Forms.Button();
                nguoidung.Location = new System.Drawing.Point(200, -30 + 40 * i);
                nguoidung.Name = label.Text;
                nguoidung.Size = new System.Drawing.Size(37, 35);
                nguoidung.TabIndex = 1;
                nguoidung.UseVisualStyleBackColor = true;
                nguoidung.Image = global::MyFirstSoftPhone_02.Properties.Resources.chat;
                nguoidung.Cursor = System.Windows.Forms.Cursors.Hand;
                panel_online.Controls.Add(nguoidung);
                nguoidung.Click += new System.EventHandler(btnChat_Click_Online);

                //button call
                nguoidung = new System.Windows.Forms.Button();
                nguoidung.Location = new System.Drawing.Point(240, -30 + 40 * i);
                nguoidung.Name = "call"+label.Text;
                nguoidung.Size = new System.Drawing.Size(37, 35);
                nguoidung.TabIndex = 1;
                nguoidung.UseVisualStyleBackColor = true;
                nguoidung.Image = global::MyFirstSoftPhone_02.Properties.Resources.call;
                nguoidung.Cursor = System.Windows.Forms.Cursors.Hand;
                panel_online.Controls.Add(nguoidung);
                nguoidung.Click += new System.EventHandler(btn_PickUp_Click);
            }
        }

        private void btnChat_Click(object sender, EventArgs e)
        {
            if (formMessage == null)
            {
                Receiver = tbInputToChat.Text.Trim();
                formMessage = new FormMessage(this, tbInputToChat.Text);
                formMessage.lblMessageInfo.Text = tbInputToChat.Text;
                //InvokeGUIThread(() => { formMessage.ShowDialog(); });
                formMessage.ShowDialog();
            }
        }

        private void btnChat_Click_Online(object sender, EventArgs e)
        {
            if (formMessage == null)
            {
                formMessage = new FormMessage(this, (sender as Button).Name);
                Receiver = (sender as Button).Name;
                formMessage.lblMessageInfo.Text = (sender as Button).Name;
                InvokeGUIThread(() => { formMessage.ShowDialog(); });
            }
        }

        private void Info_Click(object sender, EventArgs e)
        {
            string username = (sender as Button).Name.Substring(4, (sender as Button).Name.Length - 4);
            var u = _UserOnlines.SingleOrDefault(p => p.username == username);
            string info = 
                 $"Username: {u.username}\n\n" +
                 $"Tên hiển thị: {u.Display_Name}\n\n" +
                 $"Bộ phận: {u.Department_Name}\n";


            //IdClick = (sender as Button).Name.Substring(4, (sender as Button).Name.Length - 4);
            MessageBox.Show(info, "Thông tin người dùng", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAddUser addUser = null;
            if (addUser == null)
            {
                {
                    addUser = new FormAddUser(_me, "thongtin");
                    addUser.Text = "Thông tin người dùng";
                    addUser.ShowDialog();
                }
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            FormChangePassword formChangePassword = null;
            if (formChangePassword == null)
            {
                {
                    formChangePassword = new FormChangePassword();
                    formChangePassword.ShowDialog();
                }
            }
        }

        private void btnHistoryCall_Click(object sender, EventArgs e)
        {
            FormCallsHistory formHistory = null;
            if (formHistory == null)
            {
                {
                    formHistory = new FormCallsHistory(_me);
                    formHistory.ShowDialog();
                }
            }
        }

        async System.Threading.Tasks.Task RunAsyncPostLogout()
        {
            var parameters = new Dictionary<string, string>();
            parameters["token"] = Global.token;
            

            using (var client = new HttpClient())
            {
                // Gắn header
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // Gọi API
                var response = client.PostAsync($"http://192.168.1.211/api/logout", new FormUrlEncodedContent(parameters)).Result;

                // Đọc dữ liệu trả về
                //string resultContent = response.Content.ReadAsStringAsync().Result;
            }
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Bạn có chắc muốn thoát chương trình không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                RunAsyncPostLogout().Wait();
                this.Hide();    //Hide the Old Form
                FormLogin l = new FormLogin();
                l.ShowDialog();
                this.Close();    //Close the Old Form
            }
        }

        private void FormMainUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnLogout_Click(sender, e);
        }
    }
}
