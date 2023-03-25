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
    public partial class FormManageServer : Form
    {
        List<Label> _UserOnlines = new List<Label>();
        List<Label> _UserOfflines = new List<Label>();

        public FormManageServer()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            for (int i = 1; i < 21; i++)
            {
                //user online
                var label = new System.Windows.Forms.Label();
                panelOnl.Controls.Add(label);
                label.AutoSize = true;
                label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                label.Location = new System.Drawing.Point(20, -20 + 30 * i);
                label.Name = "username: " + i;
                label.Size = new System.Drawing.Size(150, 20);
                label.TabIndex = 3;
                label.Text = "username: duongnhatduy " + i;
                _UserOnlines.Add(label);

                //user offline
                label = new System.Windows.Forms.Label();
                panelOff.Controls.Add(label);
                label.AutoSize = true;
                label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                label.Location = new System.Drawing.Point(20, -20 + 30 * i);
                label.Name = "usernameoff: " + i;
                label.Size = new System.Drawing.Size(150, 20);
                label.TabIndex = 3;
                label.Text = "username: tuhuuduc " + i;
                _UserOfflines.Add(label);
            }
        }

        private void btnStartServer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Server đã được bật!");
        }

        private void btnStopServer_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Bạn có chắc xóa muốn tắt Server không?", "Tắt Server", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Server đã tắt!");
            }
        }
    }
}
