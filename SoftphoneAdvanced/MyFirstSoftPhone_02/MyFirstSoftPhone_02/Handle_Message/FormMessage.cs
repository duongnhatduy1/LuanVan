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
            this.KeyPreview = true;
        }


        

        private static string GetMessage()
        {
            Console.Write("Message to {0}: ", receiver);
            return Console.ReadLine();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            string content = tbMessage.Text.Trim();
            if (content != "")
            {
                var messageToSend = new InstantMessage(form_CallManagement.Receiver, content);
                form_CallManagement.SendMessage(messageToSend);
                //lblMessage.Text += Login.userInfo.UserName+": "+ content + "\n";
                lblMessage.Items.Add(Login.userInfo.UserName + ": " + content);
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
