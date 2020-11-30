using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BBQ_SHOP
{
    public partial class order_details : Form
    {
        //string strCon = "Server=localhost;Initial Catalog=BBQ_Shop;Integrated Security=true";
        string strCon = "Data Source=DESKTOP-UMVM4JB\\SQLEXPRESS;Initial Catalog=BBQ_Shop;Integrated Security=SSPI";
        int orderno;
        public order_details()
        {
            InitializeComponent();
        }

        public void filldata()          //Populating Data from the product Data Base to the Grid View Table in the Form 
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            SqlConnection con = new SqlConnection(strCon);
            string query = "Select * from [dbo].[sales] WHERE sales_id='"+id_text.Text+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            //Variable Declarations
            string id = "", date = "", price = "", userid = "";
            while (rdr.Read())
            {
                id = rdr["sales_id"].ToString();
                date= rdr["sales_date"].ToString();
                price = rdr["price"].ToString();
                userid = rdr["user_id"].ToString();
                dataGridView1.Rows.Add(id, date, price, userid);
            }
            con.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            main_menu_bbqshop obj = new main_menu_bbqshop();
            obj.Show();
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // DETAILS
            filldata();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void order_details_Load(object sender, EventArgs e)
        {

        }
    }
}
