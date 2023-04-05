using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            if (formManageUsers == null)
            {
                formManageUsers = new FormManageUsers();
            }
            OpenChildForm(formManageUsers);
        }

       private void OpenChildForm(Form childForm)
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

        private void btnManageUser_Click(object sender, EventArgs e)
        {
            if (formManageUsers == null)
            {
                formManageUsers = new FormManageUsers();
            }
            OpenChildForm(formManageUsers);
            lblTitle.Text = "Quản lý người dùng";
            panelTitle.Controls.Add(btnAddUser);
            panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
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
            OpenChildForm(formManageServer);
            lblTitle.Text = "Quản lý Server";
            panelTitle.Controls.Remove(btnAddUser);
            panelTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddUser addUser = null;
            if (addUser == null)
            {
                {
                    addUser = new AddUser();
                    addUser.ShowDialog();
                }
            }
        }
    }
}
