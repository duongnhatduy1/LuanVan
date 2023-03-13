using MyFirstSoftPhone_02.Handle_Message;
using MyFirstSoftPhone_02.Pattern;
using odm.core;
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

namespace MyFirstSoftPhone_02
{
    public partial class Login : Form
    {
        public static UserInfo userInfo;
        public Login()
        {
            InitializeComponent();
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                MessageBox.Show("The Caps Lock key is ON.");
            }
        }
        public bool CheckLogin(UserInfo u)
        {
            userInfo = u;
            return true;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            String userName = tb_Username.Text.Trim();
            String password = tb_Password.Text.Trim();
            String serverIP = tb_ServerIP.Text.Trim();
            UserInfo userInfo = new UserInfo(userName, password, serverIP);
            if (CheckLogin(userInfo))
            {
                this.Hide();    //Hide the Old Form
                Form_CallManagement form_CallManagement = new Form_CallManagement(userInfo);
                form_CallManagement.ShowDialog();    //Show the New Form
                this.Close();    //Close the Old Form
            }
            else
            {
                MessageBox.Show("Invalid user name or password or server IP", "UnAuthorized",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
        }

        private void btn_Registry_Click(object sender, EventArgs e)
        {
            tb_Username.Text = "";
            tb_ServerIP.Text = "";
            tb_Password.Text = "";
            tb_Username.Focus();
        }


        //private void btn_Registry_Click(object sender, EventArgs e)
        //{
        //    Register registry = new Register(); // Instantiate a Registry object.
        //    this.Hide();    //Hide the Old Form
        //    registry.ShowDialog();    //Show the New Form
        //    this.Close();    //Close the Old Form
        //}
    }
}
