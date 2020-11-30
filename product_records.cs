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
    public partial class product_records : Form
    {
        SqlConnection con;
        //string strCon = "Server=localhost;Initial Catalog=BBQ_Shop;Integrated Security=true";
        string strCon = "Data Source=DESKTOP-UMVM4JB\\SQLEXPRESS;Initial Catalog=BBQ_Shop;Integrated Security=SSPI";

        public product_records()
        {
            InitializeComponent();
            //con = new SqlConnection("Server=localhost;Initial Catalog=BBQ_Shop;Integrated Security=true");
            con = new SqlConnection("Data Source=DESKTOP-UMVM4JB\\SQLEXPRESS;Initial Catalog=BBQ_Shop;Integrated Security=SSPI");


        }
        public void clear_Fields()      //Clearing Fields of the forms
        {
            name_text.Text = "";
            price_text.Text = "";
            details_text.Text = "";
        }

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
        }
        
            
            private void button2_Click(object sender, EventArgs e)
        {
            owner_menu obj = new owner_menu();
            obj.Show();
            this.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // ADDED

            if (true)
            { 
               
                string query1 = "INSERT INTO [dbo].[product] ([product_name],[product_details],[price]) ";
                string query2 = "VALUES (\'" + name_text.Text + "\', \'" + details_text.Text + "\', \'" +price_text.Text + "\');";
                SqlConnection con = new SqlConnection(strCon);
                try
                {
                    SqlCommand cmd = new SqlCommand((query1 + query2), con);
                    con.Open();
                    int Result = cmd.ExecuteNonQuery();
                    MessageBox.Show("ADDED");
                    clear_Fields();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error In Inserting Data : " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
                 filldata();
            }


        }

        private void details_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void price_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;                                    // Fetching data from the selected index
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            id_text.Text = selectedRow.Cells[0].Value.ToString();
            name_text.Text = selectedRow.Cells[1].Value.ToString();
           details_text.Text = selectedRow.Cells[2].Value.ToString();
            price_text.Text = selectedRow.Cells[3].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void product_records_Load(object sender, EventArgs e)
        {
            filldata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // UPDATE

            if (true)//Validation of Given Fields before updating in the database
            {
                string query1 = "Update [dbo].[product] SET product_name = \'" + name_text.Text + "\', product_details = \'" + details_text.Text + "\', price = \'" + price_text.Text + "\'";
                // string query2 = "Emp_Address = \'" + Address_Box.Text + "\', Emp_Salary = " + Salary_Box.Text + ", Emp_Designation = \'" + Designation_Box.Text + "\', Emp_Shift = \'" + Shift_Box.Text + "\'";
                string query2 = " WHERE product_id = " + id_text.Text + " ;";
                SqlConnection con = new SqlConnection(strCon);
                try
                {
                    SqlCommand cmd = new SqlCommand((query1 + query2), con);
                    con.Open();
                    int Result = cmd.ExecuteNonQuery();
                    MessageBox.Show("UPDATED");
                }
                catch (Exception ex)
                {
                    //handle excpetion
                    MessageBox.Show(ex.Message);

                }
                finally
                {
                    con.Close();
                }
                filldata();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //DELETE

            if (id_text.Text != "")
            {
                SqlConnection con = new SqlConnection(strCon);
                try
                {
                    con.Open(); //Open Connection  
                    SqlCommand cmd = new SqlCommand("DELETE FROM [dbo].[product] WHERE product_id = " + id_text.Text + " ;", con);
                    int Result = cmd.ExecuteNonQuery(); // Execute Query for deleting all rows selected from DataGridView  
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close(); // Close Connection  
                }
                filldata();
            }
        }

        private void id_text_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
