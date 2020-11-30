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
    public partial class cart : Form
    {
        private List<Products> carts = new List<Products>();
        //string strCon = "Server=localhost;Initial Catalog=BBQ_Shop;Integrated Security=true";
        string strCon = "Data Source=DESKTOP-UMVM4JB\\SQLEXPRESS;Initial Catalog=BBQ_Shop;Integrated Security=SSPI";
        public cart()
        {
            InitializeComponent();
        }
        public void set_Cart(List<Products> carted)
        {
            carts = carted;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            main_menu_bbqshop obj = new main_menu_bbqshop();
            obj.Show();
            this.Visible = false;
        }
        int total = 0;
        public void filldata()
        {
            string name;
            int qty;
            int price;
            if (carts.Count > 0)
            {
                for (int i = 0; i < carts.Count; i++)
                {
                    name = carts[i].Name;
                    qty = carts[i].Qty;
                    price = carts[i].Price;
                    dataGridView1.Rows.Add(name, qty, price);
                    total += price;
                }
                Total_Box.Text = total.ToString();
               
   
            }
            else
                Total_Box.Text = "0";

        }
        private void cancel_edit_order_Load(object sender, EventArgs e)
        {
            filldata();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string query1 = "INSERT INTO [dbo].[sales] (sales_date, price,user_id) ";
            string query2 = "VALUES (\'" + now.ToShortDateString() + "\', " + total.ToString() + ", " + 2 +");";
            SqlConnection con = new SqlConnection(strCon);
            try
            {
                SqlCommand cmd = new SqlCommand((query1 + query2), con);
                con.Open();
                int Result = cmd.ExecuteNonQuery();
                MessageBox.Show("Order Confirmed");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Confirming Order : " + ex);
            }
            finally
            {
                con.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            order obj = new order();
            obj.set_Cart(carts);
            obj.Show();
            this.Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;                                    // Fetching data from the selected index
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
     //       id_text.Text = selectedRow.Cells[0].Value.ToString();
            name_text.Text = selectedRow.Cells[0].Value.ToString();
            price_text.Text = selectedRow.Cells[1].Value.ToString();
           quantity.Text = selectedRow.Cells[2].Value.ToString();
           // filldata1();
        }

        //public void filldata1()          //Populating Data from the product Data Base to the Grid View Table in the Form 
        //{
        //    dataGridView1.Rows.Clear();
        //    dataGridView1.Refresh();
        //    SqlConnection con = new SqlConnection(strCon);
        //    SqlCommand cmd = new SqlCommand("Select * from [dbo].[sales]", con);
        //    con.Open();
        //    SqlDataReader rdr = cmd.ExecuteReader();
        //    //Variable Declarations
        //    string id = "", name = "",price = "", detail = "";
        //    while (rdr.Read())
        //    {
        //        //id_t = rdr["user_id"].ToString();
        //        //name_text.Text = rdr["user_name"].ToString();
        //        //price_text.Text = rdr["user_password"].ToString();
        //        //quantity.Text = rdr["salary"].ToString();
        //        dataGridView1.Rows.Add(id, name, price, detail);
        //        con.Close();
        //    }
        //}
           // con.Close();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DataGridViewRow selRow = Cart_List.Rows[index];             //get the data from the selected row
            //string name_update = selRow.Cells[0].Value.ToString();
            //int new_Quantity_Var = Int32.Parse(NewQuantity.Value.ToString()); // stores the new quantity to be updated.
            //int singleunit = 0, diff = 0;
            //for (int i = 0; i < cart.Count; i++)
            //{
            //    if (cart[i].name == name_update && new_Quantity_Var != cart[i].quantity)        //if the selected item has a new quantity value
            //    {
            //        singleunit = cart[i].price / cart[i].quantity;                      //get the price of single item
            //        if (new_Quantity_Var > cart[i].quantity)
            //        {
            //            diff = new_Quantity_Var - cart[i].quantity;     //if the new quantity is greater then increments the price
            //            cart[i].price += (diff * singleunit);
            //        }
            //        else
            //        {
            //            diff = cart[i].quantity - new_Quantity_Var; //if the new quantity is less then decrements the price
            //            cart[i].price -= (diff * singleunit);
            //        }
            //        cart[i].quantity = new_Quantity_Var;            //updates the quantity
            //        Cart_List.Rows.Clear();
            //        Cart_List.Refresh();                    //refresh the grid view table
            //        filldata();                     //insert all updated items in the table
            //    }
            //}
            //Quantity_Label.Hide();
            //NewQuantity.Hide();
            //Remove_button.Hide();
            //Update_button.Hide();
       
        }
    }
}
