using MyFirstSoftPhone_02.Pattern;
using Newtonsoft.Json;
using Ozeki.VoIP;
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

namespace MyFirstSoftPhone_02.Handle_Message
{
    public partial class FormMessage : Form
    {
        private FormMainUser formMainUser;
        private static InstantMessage _messageToSend;
        private static string receiver = "";
        private List<Pattern.Message> _listMessage = new List<Pattern.Message>();
        

        async System.Threading.Tasks.Task RunAsyncGetMessages()
        {

            using (var client = new HttpClient())
            {
                // Gắn header
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("token", Global.token);

                // Gọi API
                var response = client.GetAsync($"http://{Global.ServerInfo}/api/message?with={receiver}").Result;


                // Đọc dữ liệu trả về
                string resultContent = response.Content.ReadAsStringAsync().Result;
                resultContent = "{\"Messages\": " + resultContent + "}";
                var data = JsonConvert.DeserializeObject<ListMessage>(resultContent);
                _listMessage = data.Messages;
            }
        }
        public FormMessage(FormMainUser f, string r)
        {
            receiver = r;
            formMainUser = f;
            InitializeComponent();
            this.KeyPreview = true;
            RunAsyncGetMessages().Wait();
            if (_listMessage.Count > 0)
            {
                foreach (var m in _listMessage)
                {
                    lblMessage.Items.Add($"[{m.Time_send}] {m.Sender_Username}: {m.content}\n");
                }
            }
        }
    


        

        //private static string GetMessage()
        //{
        //    Console.Write("Message to {0}: ", receiver);
        //    return Console.ReadLine();
        //}

        

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            string content = tbMessage.Text.Trim();
            if (content != "")
            {
                var messageToSend = new InstantMessage(formMainUser.Receiver, content);
                formMainUser.SendMessage(messageToSend);
                //lblMessage.Text += Login.userInfo.UserName+": "+ content + "\n";
                lblMessage.Items.Add(formMainUser._me.username + ": " + content);
            }
            tbMessage.Text = "";
            tbMessage.Focus();
        }

        private void FormMessage_FormClosed(object sender, FormClosedEventArgs e)
        {
            formMainUser.formMessage = null;
        }

        private void tbMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                btnSendMessage_Click(sender, e);
                tbMessage.Text = "";
            }
            

        }

        private void tbMessage_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbMessage.Text = "";
            }
        }
    }
}
