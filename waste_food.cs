using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBQ_SHOP
{
    public partial class waste_food : Form
    {
        //string strCon = "Server=localhost;Initial Catalog=BBQ_Shop;Integrated Security=true";
        string strCon = "Data Source=DESKTOP-UMVM4JB\\SQLEXPRESS;Initial Catalog=BBQ_Shop;Integrated Security=SSPI";
        public waste_food()
        {
            InitializeComponent();
        }

        private void waste_food_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            main_menu_bbqshop obj = new main_menu_bbqshop();
            obj.Show();
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query1 = "INSERT INTO [dbo].[waste] ([product_id],[details]) ";
            string query2 = "VALUES (\'" + textBox1.Text + "\', \'" + richTextBox1.Text + "\' );";
            SqlConnection con = new SqlConnection(strCon);
            try
            {
                SqlCommand cmd = new SqlCommand((query1 + query2), con);
                con.Open();
                int Result = cmd.ExecuteNonQuery();
                MessageBox.Show("ADDED");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error In Inserting Data : " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
