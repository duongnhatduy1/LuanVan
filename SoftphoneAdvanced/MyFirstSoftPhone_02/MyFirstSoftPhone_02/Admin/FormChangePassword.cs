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
    public partial class FormChangePassword : Form
    {
        private string _old, _new, _again;
        public FormChangePassword()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        int CheckInfo()
        {
            _old = tbOld.Text.Trim();
            _new = tbNew.Text.Trim();
            _again = tbAgain.Text.Trim();
            if (_old.Length<6)
            {
                MessageBox.Show("Mật khẩu cũ không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbOld.Focus();
                return 0;
            }
            else if (_new.Length < 6)
            {
                MessageBox.Show("Mât khẩu tối thiểu 6 ký tự!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbNew.Focus();
                return 0;
            }
            else if (_again != _new)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbAgain.Focus();
                return 0;
            }
            
            return 1;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckInfo() == 1) MessageBox.Show($"Mật khẩu mới: {_new}");
        }
    }
}
