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
    public partial class search_button : Form
    {
        SqlConnection con ,con3;
        string con2;
        public search_button()
        {
            InitializeComponent();
            //con = new SqlConnection("Server=localhost;Initial Catalog=BBQ_Shop;Integrated Security=true");
            con = new SqlConnection("Data Source=DESKTOP-UMVM4JB\\SQLEXPRESS;Initial Catalog=BBQ_Shop;Integrated Security=SSPI");

            //con2 = "Server=localhost;Initial Catalog=BBQ_Shop;Integrated Security=true";
            con2 = "Data Source=DESKTOP-UMVM4JB\\SQLEXPRESS;Initial Catalog=BBQ_Shop;Integrated Security=SSPI";

            //con3 = new SqlConnection("Server=localhost;Initial Catalog=BBQ_Shop;Integrated Security=true");
            con3 = new SqlConnection("Data Source=DESKTOP-UMVM4JB\\SQLEXPRESS;Initial Catalog=BBQ_Shop;Integrated Security=SSPI");
        }
        public void clear_Fields()      //Clearing Fields of the forms
        {
            name_text.Text = "";
            sal_text.Text = "";
            pass_text.Text = "";
        //    Phone_Box.Text = "";
        //    Address_Box.Text = "";
        //    Salary_Box.Text = "";
        //    Designation_Box.Text = "";
        //    Shift_Box.Text = "";
        //
        }
        //string strCon = "Server=localhost;Initial Catalog=BBQ_Shop;Integrated Security=true";
        string strCon = "Data Source=DESKTOP-UMVM4JB\\SQLEXPRESS;Initial Catalog=BBQ_Shop;Integrated Security=SSPI";

        public void filldata()          //Populating Data from the product Data Base to the Grid View Table in the Form 
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            SqlConnection con = new SqlConnection(strCon);
            SqlCommand cmd = new SqlCommand("Select * from [dbo].[user]", con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            //Variable Declarations
            string id = "", name = "", password = "", salary = "";
            while (rdr.Read())
            {
                id = rdr["user_id"].ToString();
                name = rdr["user_name"].ToString();
                password = rdr["user_password"].ToString();
                salary = rdr["salary"].ToString();
                dataGridView1.Rows.Add(id, name, password, salary);
            }
            con.Close();
            //clear_Fields();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;                                    // Fetching data from the selected index
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            id_text.Text = selectedRow.Cells[0].Value.ToString();
            name_text.Text= selectedRow.Cells[1].Value.ToString();
            pass_text.Text = selectedRow.Cells[2].Value.ToString();
            sal_text.Text = selectedRow.Cells[3].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            owner_menu obj = new owner_menu();
            obj.Show();
            this.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // update
            //validate_Fields()
            if (true)//Validation of Given Fields before updating in the database
            {
                string query1 = "Update [dbo].[user] SET user_name = \'" + name_text.Text + "\', user_password = \'" + pass_text.Text + "\', salary = \'" + sal_text.Text + "\'";
                // string query2 = "Emp_Address = \'" + Address_Box.Text + "\', Emp_Salary = " + Salary_Box.Text + ", Emp_Designation = \'" + Designation_Box.Text + "\', Emp_Shift = \'" + Shift_Box.Text + "\'";
                string query2 = " WHERE user_id = " + id_text.Text + " ;";
                SqlConnection con = new SqlConnection(con2);
                try
                {
                    SqlCommand cmd = new SqlCommand((query1  + query2), con);
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

        private void button4_Click(object sender, EventArgs e)
        { //INSERT
            //validate_Fields()
            if (true)
            { /*
               * INSERT INTO [dbo].[user]
           ([user_name]
           ,[user_password]
           ,[salary])
     VALUES
           (<user_name, varchar(250),>
           ,<user_password, varchar(20),>
           ,<salary, int,>)
               */
                string query1 = "INSERT INTO [dbo].[user] ([user_name],[user_password],[salary]) ";
                string query2 = "VALUES (\'" + name_text.Text + "\', \'" + pass_text.Text + "\', \'" + sal_text.Text + "\');";
                SqlConnection con = new SqlConnection(con2);
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

        private void button3_Click(object sender, EventArgs e)
        {
            //DELETE

            if (id_text.Text != "")
            {
                SqlConnection con = new SqlConnection(strCon);
                try
                {
                    con.Open(); //Open Connection  
                    SqlCommand cmd = new SqlCommand("DELETE FROM [dbo].[user] WHERE user_id = " + id_text.Text + " ;", con);
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

        private void employee_records_Load(object sender, EventArgs e)
        {
            filldata();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
