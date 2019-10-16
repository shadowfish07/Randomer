using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 随机器_new
{
    public partial class frm_main : Form
    {
        NumRandomer nr = new NumRandomer(1,40);
        public frm_main()
        {
            InitializeComponent();
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            nr.SetPrintTo(lbl_num);
        }

        private void btn_command_Click(object sender, EventArgs e)
        {
            int.TryParse(txt_min_num.Text, out int min);
            int.TryParse(txt_max_num.Text, out int max);
            nr.Min = min;
            nr.Max = max;
            if (btn_command.Text=="开始")
            {
                btn_command.Text = "停止";
                nr.Start();
            }
            else
            {
                btn_command.Text = "开始";
                
                nr.Stop();
            }
        }

        private void txt_min_num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != 8)
                e.Handled = true ;
        }

        private void txt_max_num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
