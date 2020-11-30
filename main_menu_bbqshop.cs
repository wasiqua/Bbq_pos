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
    public partial class main_menu_bbqshop : Form
    {
        public main_menu_bbqshop()
        {
            InitializeComponent();
        }

        private void starter_button_Click(object sender, EventArgs e)
        {
            order ap = new order();
            ap.Show();
            this.Visible = false;
        }

        private void maincourse_button_Click(object sender, EventArgs e)
        {
            order_details obj = new order_details();
            obj.Show();
            this.Visible = false;
        }

        private void deserts_button_Click(object sender, EventArgs e)
        {
            cart obj = new cart();
            obj.Show();
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            waste_food obj = new waste_food();
            obj.Show();
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           login_label obj = new login_label();
            obj.Show();
            this.Visible = false;
        }
    }
}
