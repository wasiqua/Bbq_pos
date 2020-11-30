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
    public partial class owner_menu : Form
    {
        public owner_menu()
        {
            InitializeComponent();
        }

        private void product_button_Click(object sender, EventArgs e)
        {
           product_records obj = new product_records();
            obj.Show();
            this.Visible = false;
        }

        private void emp_button_Click(object sender, EventArgs e)
        {
            search_button obj = new search_button();
            obj.Show();
            this.Visible = false;
        }

        private void sales_details_button_Click(object sender, EventArgs e)
        {
            profit_loss obj = new profit_loss();
            obj.Show();
            this.Visible = false;
        }

        private void emp_details_button_Click(object sender, EventArgs e)
        {
            login_label obj = new login_label();
            obj.Show();
            this.Visible = false;

        }
    }
}
