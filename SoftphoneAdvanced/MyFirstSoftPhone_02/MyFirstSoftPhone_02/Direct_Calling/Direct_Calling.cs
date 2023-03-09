using MyFirstSoftPhone_02.Pattern;
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
    public partial class Direct_Calling : Form
    {
        private Form_CallManagement form_CallManagement;
        public Direct_Calling(Form_CallManagement f)
        {
            form_CallManagement = f;
            InitializeComponent();
        }

        private void btn_PickUp_Click(object sender, EventArgs e)
        {
            form_CallManagement.btn_PickUp_Click(sender,e);
        }

        private void btn_HangUp_Click(object sender, EventArgs e)
        {
            form_CallManagement.btn_HangUp_Click(sender, e);
            this.Close();
        }
    }
}
