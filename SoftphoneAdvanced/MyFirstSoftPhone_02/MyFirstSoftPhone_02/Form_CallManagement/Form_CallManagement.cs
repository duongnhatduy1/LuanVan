using System;
using System.Windows.Forms;
using MyFirstSoftPhone_02.Pattern;
using Ozeki.Media;
using Ozeki.VoIP;

namespace MyFirstSoftPhone_02
{
    public partial class Form_CallManagement : Form
    {
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

        private bool inComingCall;

        public Form_CallManagement(UserInfo u)
        {
            userInfo = u;
            InitializeComponent();
            
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
                InvokeGUIThread(() => { lb_Log.Items.Add("Phoneline created."); });
                softPhone.RegisterPhoneLine(phoneLine);

                lbl_NumberToDial.Text = string.Empty;

                lbl_UserLogin.Text = "Hi : "+ userInfo.UserName;

            }
            catch (Exception ex)
            {
                InvokeGUIThread(() => { lb_Log.Items.Add("Local IP error!"); });
            }
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
            InvokeGUIThread(() => { lb_Log.Items.Add("Incoming call from: " + e.Item.DialInfo.ToString()); });
            StartMP3();
            call = e.Item;
            WireUpCallEvents();
            inComingCall = true;

            //Form_CallManagement fCopy = new Form_CallManagement(this.userInfo);
            //this.Hide();    //Hide the Old Form
            Direct_Calling direct_Calling = new Direct_Calling(this);
            //this.Visible = false;
            //this.Owner.Enabled = false;
            direct_Calling.ShowDialog();
            //Show the New Form
            //this.Visible = false;
            //this.Close();    //Close the Old Form
        }


        private void phoneLine_PhoneLineInformation(object sender, RegistrationStateChangedArgs e)
        {
            phoneLineInformation = e.State;
            InvokeGUIThread(() =>
                {
                    if (phoneLineInformation == RegState.RegistrationSucceeded)
                    {
                        lb_Log.Items.Add("Registration succeeded - Online");
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
            Direct_Calling direct_Calling = new Direct_Calling(this);
            //this.Visible = false;
            //this.Owner.Enabled = false;
            direct_Calling.ShowDialog();

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

            call = softPhone.CreateCallObject(phoneLine, lbl_NumberToDial.Text);
            WireUpCallEvents();
            ConnectMedia();
            call.Start();
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


    }
}
