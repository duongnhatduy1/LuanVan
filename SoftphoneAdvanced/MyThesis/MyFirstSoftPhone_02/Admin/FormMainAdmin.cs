using MyFirstSoftPhone_02.Pattern;
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

namespace MyFirstSoftPhone_02.Admin
{
    public partial class FormMainAdmin : Form
    {
        private Form CurrentFormChild;
        private FormManageUsers formManageUsers;
        private FormManageCalls formManageCalls;
        private FormManageServer formManageServer;


        public FormMainAdmin()
        {
            InitializeComponent();
            //panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            //if (formManageUsers == null)
            //{
            //    formManageUsers = new FormManageUsers();
            //}
            //OpenChildForm(formManageUsers);

        }

       public void OpenChildForm(Form childForm)
        {
            CurrentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContent.Controls.Add(childForm);
            panelContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public void RefreshManageUser()
        {
            formManageUsers = new FormManageUsers(this);
            OpenChildForm(formManageUsers);
            lblTitle.Text = "Quản lý người dùng";
            panelTitle.Controls.Add(btnAddUser);
            panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
        }
        private void btnManageUser_Click(object sender, EventArgs e)
        {
            RefreshManageUser();
        }

        private void btnManageCall_Click(object sender, EventArgs e)
        {
            if (formManageCalls == null)
            {
                formManageCalls = new FormManageCalls();
            }
            OpenChildForm(formManageCalls);
            lblTitle.Text = "Quản lý cuộc gọi";
            panelTitle.Controls.Remove(btnAddUser);
            panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
        }

        private void btnManageServer_Click(object sender, EventArgs e)
        {
            if (formManageServer == null)
            {
                formManageServer = new FormManageServer();
            }
            formManageServer.RunAsyncGetUser().Wait();
            formManageServer.Init();
            OpenChildForm(formManageServer);
            lblTitle.Text = "Quản lý Server";
            panelTitle.Controls.Remove(btnAddUser);
            panelTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            FormAddUser adduser = null;
            if (adduser == null)
            {
                {
                    adduser = new FormAddUser(this);
                    adduser.ShowDialog();
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
                var response = client.PostAsync($"http://{Global.ServerInfo}/api/logout", new FormUrlEncodedContent(parameters)).Result;

                // Đọc dữ liệu trả về
                //string resultContent = response.Content.ReadAsStringAsync().Result;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Bạn có chắc muốn thoát chương trình không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();    //Hide the Old Form
                this.Close();    //Close the Old Form
            }
        }

        private void FormMainAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            RunAsyncPostLogout().Wait();
            this.Hide();    //Hide the Old Form
            FormLogin l = new FormLogin();
            l.ShowDialog();
            this.Close();    //Close the Old Form
        }
    }
}
