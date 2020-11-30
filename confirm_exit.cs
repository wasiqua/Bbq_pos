using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBQ_SHOP
{
    public partial class confirm_exit : Form
    {
        public confirm_exit()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            welcome obj = new welcome();
            obj.Show();
            this.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
