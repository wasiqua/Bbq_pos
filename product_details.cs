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
    public partial class product_details : Form
    {
        public product_details()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            owner_menu obj = new owner_menu();
            obj.Show();
            this.Visible= false;

        }
    }
}
