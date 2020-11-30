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
    public partial class profit_loss : Form
    {
        //string strCon = "Server=localhost;Initial Catalog=BBQ_Shop;Integrated Security=true";
        string strCon = "Data Source=DESKTOP-UMVM4JB\\SQLEXPRESS;Initial Catalog=BBQ_Shop;Integrated Security=SSPI";
        public profit_loss()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            owner_menu obj = new owner_menu();
            obj.Show();
            this.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void profit_loss_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            SqlConnection con = new SqlConnection(strCon);
            SqlCommand cmd = new SqlCommand("Select * from profit_loss", con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            //Variable Declarations
            string id = "", value = "", S_Date = "", E_Date = "";
            while (rdr.Read())
            {
                id = rdr["p_f_id"].ToString();
                value = rdr["p_L_value"].ToString();
                S_Date = rdr["start_date"].ToString();
                E_Date = rdr["end_date"].ToString();
                dataGridView1.Rows.Add(id, value, S_Date, E_Date);
            }
            con.Close();
        }
    }
}
