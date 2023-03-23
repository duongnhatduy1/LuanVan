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
    public partial class FormManageUsers : Form
    {
        List<Button> _userButtons = new List<Button>();
        public FormManageUsers()
        {
            InitializeComponent();
            InitUsers();
        }


        public void InitUsers()
        {
            for (int i = 1; i < 10; i++)
            {
                var nguoidung2 = new System.Windows.Forms.Button();
                nguoidung2.Location = new System.Drawing.Point(376, 77 + 50 * i);
                nguoidung2.Name = $"nguoidung{i}";
                nguoidung2.Size = new System.Drawing.Size(85, 20);
                nguoidung2.TabIndex = 1;
                nguoidung2.Text = $"nguoidung{i}";
                nguoidung2.UseVisualStyleBackColor = true;
                panel_FormUsers.Controls.Add(nguoidung2);
                _userButtons.Add(nguoidung2);
                nguoidung2.Click += new System.EventHandler(nguoidung_Click);
            }
        }
        public void LoadUsers()
        {
            int i = 0;
            foreach(var b in _userButtons)
            {
                i++;
                b.Location = new System.Drawing.Point(376, 77+50*i);
                panel_FormUsers.Controls.Add(b);
            }
        }

        private void nguoidung_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Click on " + (sender as Button).Text);
            _userButtons.Remove((sender as Button));
            panel_FormUsers.Controls.Clear();
            LoadUsers();
            
        }
    }
}
