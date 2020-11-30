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
    public partial class employee : Form
    {
        public employee()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            owner_menu obj = new owner_menu();
            obj.Show();
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            search_button obj = new search_button();
            obj.Show();
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            search_button obj = new search_button();
            obj.Show();
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            search_button obj = new search_button();
            obj.Show();
            this.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            view_employee_details obj = new view_employee_details();
            obj.Show();
            this.Visible = false;
        }
    }
}
