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
    public partial class product : Form
    {
        public product()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            owner_menu obj = new owner_menu();
            obj.Show();
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            product_records obj = new product_records();
            obj.Show();
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            product_records obj = new product_records();
            obj.Show();
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            product_records obj = new product_records();
            obj.Show();
            this.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            product_details obj = new product_details();
            obj.Show();
            this.Visible = false;
        }
    }
}
