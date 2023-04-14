using MyFirstSoftPhone_02.Admin;
using MyFirstSoftPhone_02.Handle_Message;
using MyFirstSoftPhone_02.Pattern;
using Newtonsoft.Json;
using odm.core;
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

namespace MyFirstSoftPhone_02
{
    public partial class Login : Form
    {
        public static UserInfo userInfo;
        public User _me;
        string userName, password, serverIP;
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


        async System.Threading.Tasks.Task RunAsync()
        {
            userName = tb_Username.Text.Trim();
            password = tb_Password.Text.Trim();
            serverIP = tb_ServerIP.Text.Trim();
            //Pattern.Login login = new Pattern.Login(userName, password);
            //string json = JsonConvert.SerializeObject(login);
            var parameters = new Dictionary<string, string>();
            parameters["username"] = userName;
            parameters["password"] = password;
            Pattern.Login login = new Pattern.Login(userName, password);
            using (var client = new HttpClient())
            {
                // Gắn header
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                
                // Gọi API
                var response = client.PostAsync("http://192.168.1.211/api/login", new FormUrlEncodedContent(parameters)).Result;


                // Đọc dữ liệu trả về
                string resultContent = response.Content.ReadAsStringAsync().Result;
                UserRespone m = JsonConvert.DeserializeObject<UserRespone>(resultContent);
                _me = m.user;
                
                Global.success = m.success;
                if (Global.success)
                {
                    Global.token = m.token;
                    Global.role = m.user.Role_Name;
                }
            }
        }
        private void  btn_Login_Click(object sender, EventArgs e)
        {
            

            
            RunAsync().Wait();

            if (!Global.success)
            {
                MessageBox.Show("Invalid user name or password or server IP", "UnAuthorized",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            };
            //UserInfo userInfo = new UserInfo(userName, password, serverIP);
            if (Global.role == "Admin")
            {
                this.Hide();    //Hide the Old Form
                FormMainAdmin formMainAdmin = new FormMainAdmin();
                formMainAdmin.ShowDialog();
                this.Close();    //Close the Old Form
            }
            else
            if (Global.role == "user")
            {
                this.Hide();    //Hide the Old Form
                Form_CallManagement form_CallManagement = new Form_CallManagement(_me);
                form_CallManagement.ShowDialog();    //Show the New Form
                this.Close();    //Close the Old Form
            }
            
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
