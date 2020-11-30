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
    public partial class order : Form
    {
        List<Products> carts = new List<Products>();
        public order()
        {
            InitializeComponent();
        }
        //string strCon = "Server=localhost;Initial Catalog=BBQ_Shop;Integrated Security=true";
        string strCon = "Data Source=DESKTOP-UMVM4JB\\SQLEXPRESS;Initial Catalog=BBQ_Shop;Integrated Security=SSPI";
        public void filldata()          //Populating Data from the product Data Base to the Grid View Table in the Form 
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            SqlConnection con = new SqlConnection(strCon);
            SqlCommand cmd = new SqlCommand("Select * from product", con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            //Variable Declarations
            string id = "", name = "", details = "", price = "";
            while (rdr.Read())
            {
                id = rdr["product_id"].ToString();
                name = rdr["product_name"].ToString();
                details = rdr["product_details"].ToString();
                price = rdr["price"].ToString();
                dataGridView1.Rows.Add(id, name, details, price);
            }
            con.Close();
            //clear_Fields();
        }
        private void order_Load(object sender, EventArgs e)
        {
            filldata();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            QTY.Visible = true;
            QTY.Value = 1;
            int index = e.RowIndex;                                    // Fetching data from the selected index
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            ID_Box.Text = selectedRow.Cells[0].Value.ToString();
            Name_Box.Text = selectedRow.Cells[1].Value.ToString();
            Details_Box.Text = selectedRow.Cells[2].Value.ToString();
            Price_Box.Text = selectedRow.Cells[3].Value.ToString();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            main_menu_bbqshop obj = new main_menu_bbqshop();
            obj.Show();
            this.Visible = false;
        }
        public void set_Cart(List<Products> carted)
        {
            carts = carted;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            cart obj = new cart();
            obj.set_Cart(carts);
            obj.Show();
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = ID_Box.Text;
            string name = Name_Box.Text;
            string details = Details_Box.Text;
            int qty = Int32.Parse(QTY.Value.ToString());
            int price = (Int32.Parse(Price_Box.Text) * qty);
            Products obj = new Products();
            int index = -1;
            for (int i = 0; i < carts.Count; i++)
            {
                if (carts[i].Name == name) // checks if the added element is already in the list
                {
                    index = i;
                    break;
                }
            }
            if (index == -1) // if the element is not present in the list , it is registered as a new element
            {
                obj.Name = name;
                obj.Price = price;
                obj.Qty = qty;
                obj.Details = details;
                carts.Add(obj);
            }
            else
            {                               // if the element is already in the list then quantity of the element in incremented
                qty += carts[index].Qty;
                price += carts[index].Price;
                carts.RemoveAt(index);

                obj.Name = name;
                obj.Price = price;
                obj.Qty = qty;
                obj.Details = details;
                carts.Add(obj);
            }
            QTY.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
