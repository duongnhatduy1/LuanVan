using MyFirstSoftPhone_02.Pattern;
using Newtonsoft.Json;
using Ozeki.VoIP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstSoftPhone_02.Handle_Message
{
    public partial class FormMessage : Form
    {
        private Form_CallManagement form_CallManagement;
        private static InstantMessage _messageToSend;
        private static string receiver = "";
        private List<Pattern.Message> _listMessage = new List<Pattern.Message>();
        string json = @"{ 'Messages':
    [
    {
        'M_ID': '1680105068-4483911398f94b72582b95bdd03ba781',
        'content': 'hello',
        'Time_send': '2023-03-29 22:51:08',
        'Type': 'Text',
        'Sender_Username': 'dnduy',
        'Receiver_Username': 'tuhuuduc'
    },
    {
        'M_ID': '1679928298-fff7aff3dae098e6df8b85639da4a2e0',
        'content': 'oh',
        'Time_send': '2023-03-27 21:44:58',
        'Type': 'Text',
        'Sender_Username': 'tuhuuduc',
        'Receiver_Username': 'dnduy'
    },
    {
    'M_ID': '1679927962-4483911398f94b72582b95bdd03ba781',
        'content': 'https://drive.google.com/uc?export=view&id=1Vxf_cbyEdW78qZJJWeVVC3AZBOBsgItG',
        'Time_send': '2023-03-27 21:39:00',
        'Type': 'File',
        'Sender_Username': 'dnduy',
        'Receiver_Username': 'tuhuuduc'
    },
    {
    'M_ID': '1679927994-fff7aff3dae098e6df8b85639da4a2e0',
        'content': 'gì mạy',
        'Time_send': '2023-03-27 21:39:00',
        'Type': 'Text',
        'Sender_Username': 'tuhuuduc',
        'Receiver_Username': 'dnduy'
    },
    {
    'M_ID': '1679928053-fff7aff3dae098e6df8b85639da4a2e0',
        'content': 'gởi gì đó',
        'Time_send': '2023-03-27 21:39:00',
        'Type': 'Text',
        'Sender_Username': 'tuhuuduc',
        'Receiver_Username': 'dnduy'
    },
    {
    'M_ID': '1679928077-4483911398f94b72582b95bdd03ba781',
        'content': 'certificate',
        'Time_send': '2023-03-27 21:39:00',
        'Type': 'Text',
        'Sender_Username': 'dnduy',
        'Receiver_Username': 'tuhuuduc'
    },
    {
    'M_ID': '1679501903-4483911398f94b72582b95bdd03ba781',
        'content': 'asdsads',
        'Time_send': '2023-03-22 23:17:00',
        'Type': 'Text',
        'Sender_Username': 'dnduy',
        'Receiver_Username': 'tuhuuduc'
    },
    {
    'M_ID': '1679501935-4483911398f94b72582b95bdd03ba781',
        'content': 'https://drive.google.com/uc?export=view&id=1pxD82ZkMLsDb_noTJEZuEJjy37khXbhX',
        'Time_send': '2023-03-22 23:17:00',
        'Type': 'File',
        'Sender_Username': 'dnduy',
        'Receiver_Username': 'tuhuuduc'
    },
    {
    'M_ID': '1679503043-4483911398f94b72582b95bdd03ba781',
        'content': 'https://drive.google.com/uc?export=view&id=1ObZ5XjASITBLco1Wwtx0c1iLJAewip68',
        'Time_send': '2023-03-22 23:17:00',
        'Type': 'File',
        'Sender_Username': 'dnduy',
        'Receiver_Username': 'tuhuuduc'
    },
    {
    'M_ID': '1679503085-4483911398f94b72582b95bdd03ba781',
        'content': 'https://drive.google.com/uc?export=view&id=1LjHELawGT3ynMKdNKGDpTIr0TWBQ1Wkg',
        'Time_send': '2023-03-22 23:17:00',
        'Type': 'File',
        'Sender_Username': 'dnduy',
        'Receiver_Username': 'tuhuuduc'
    }
]}";
        
    public FormMessage(Form_CallManagement f)
        {
            form_CallManagement = f;
            InitializeComponent();
            this.KeyPreview = true;
            var data = JsonConvert.DeserializeObject<ListMessage>(json);
            _listMessage = data.Messages;
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

        

        private void button1_Click(object sender, EventArgs e)
        {
            string content = tbMessage.Text.Trim();
            if (content != "")
            {
                var messageToSend = new InstantMessage(form_CallManagement.Receiver, content);
                form_CallManagement.SendMessage(messageToSend);
                //lblMessage.Text += Login.userInfo.UserName+": "+ content + "\n";
                lblMessage.Items.Add(form_CallManagement._me.username + ": " + content);
            }
            tbMessage.Text = "";
            tbMessage.Focus();
        }

        private void FormMessage_FormClosed(object sender, FormClosedEventArgs e)
        {
            form_CallManagement.formMessage = null;
        }

        private void tbMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                button1_Click(sender, e);
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
