using MyFirstSoftPhone_02.Pattern;
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
        public FormMessage(Form_CallManagement f)
        {
            form_CallManagement = f;
            InitializeComponent();
        }


        

        private static string GetMessage()
        {
            Console.Write("Message to {0}: ", receiver);
            return Console.ReadLine();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            string content = tbMessage.Text;
            var messageToSend = new InstantMessage(form_CallManagement.Receiver, content);
            form_CallManagement.SendMessage(messageToSend);
            tbMessage.Text = "";
            tbMessage.Focus();
            lblMessage.Text += Login.userInfo.UserName+": "+ content + "\n";
        }

        private void FormMessage_FormClosed(object sender, FormClosedEventArgs e)
        {
            form_CallManagement.formMessage = null;
        }
    }
}
