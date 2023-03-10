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
        private int TimeCall = 0;
        private Form_CallManagement form_CallManagement;
        public Direct_Calling(Form_CallManagement f)
        {
            form_CallManagement = f;
            InitializeComponent();
        }

        private void btn_PickUp_Click(object sender, EventArgs e)
        {
            form_CallManagement.btn_PickUp_Click(sender,e);
            timer.Start();
            

        }

        private void btn_HangUp_Click(object sender, EventArgs e)
        {
            timer.Stop();
            form_CallManagement.btn_HangUp_Click(sender, e);
            this.Close();
            TimeCall = 0;
        }

        private void Direct_Calling_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private string pad(int n)
        {
            if (n<10) return "0";
            return "";
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            
            int hour, min, sec;
            TimeCall++;
            hour = TimeCall / 3600;
            min = (TimeCall - hour*3600) / 60;
            sec = TimeCall % 60;
            lbl_StatusCall.Text = $"{pad(hour)}{hour.ToString()} : {pad(min)}{min.ToString()} : {pad(sec)}{sec.ToString()}";
        }
    }
}
