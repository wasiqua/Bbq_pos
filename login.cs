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
using System.Data;
//using System.Data.SqlClient.SqlException;


namespace BBQ_SHOP
{
    public partial class login_label : Form
    {
        //string strCon = "Server=localhost;Initial Catalog=BBQ_Shop;Integrated Security=true";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public login_label()
        {
            InitializeComponent();
            //con = new SqlConnection("Server=localhost;Initial Catalog=BBQ_Shop;Integrated Security=SSPI");
            con = new SqlConnection("Data Source=DESKTOP-UMVM4JB\\SQLEXPRESS;Initial Catalog=BBQ_Shop;Integrated Security=SSPI");
            
        }
       
        private void login_button_Click(object sender, EventArgs e)
        {
            //string user_name = name_text.Text;
            //string pass = pass_text.Text;
            //cmd = new SqlCommand();
            //con.Open();
            //cmd.Connection = con;
            //cmd.CommandText="select * from user where user_name='"+ name_text.Text '" and user_password='" +pass_text.Text ";

        //  SqlDataAdapter sda = new SqlDataAdapter("select count(*) from owner_user where id='" + name_text.Text + "'and password ='" + pass_text + "' ",strCon);
         ////   int temp =Convert.ToInt16(id_text);
         //   //DataTable dta = new DataTable();
         //   //sda.Fill(dta);

         //   //if(dta.Rows.Count==1)
         //   //{
           
           
            //}

            if (comboBox1.Text == "OWNER")
            {


           //     SqlConnection con = new SqlConnection(@"Data Source=USER;Initial Catalog=admin;Integrated Security=True"); // making connection   
                SqlDataAdapter sda1 = new SqlDataAdapter("SELECT COUNT(*) FROM owner WHERE owner_name='" + name_text.Text + "' AND password='" + pass_text.Text + "'", con);
                /* in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. */
                DataTable dt1 = new DataTable(); //this is creating a virtual table  
                sda1.Fill(dt1);
                if (dt1.Rows[0][0].ToString() == "1")
                {
                    owner_menu qwe = new owner_menu();
                    qwe.Show();
                    this.Visible = false;
                 //   /* I have made a new page called home page. If the user is successfully authenticated then the form will be moved to the next form */
                 //   this.Hide();
                 //   new home().Show();
                }
                else
                    MessageBox.Show("Invalid username or password");  
  
                
                



            }

        else if (comboBox1.Text == "USER")
        
            {
                //main_menu_bbqshop obj2 = new main_menu_bbqshop();
                //obj2.Show();
                //this.Visible = false;            
            try
            {
                //-----------------------------------------------------------
                //     SqlConnection con = new SqlConnection(@"Data Source=USER;Initial Catalog=admin;Integrated Security=True"); // making connection   
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM [dbo].[user] WHERE user_name ='" + name_text.Text + "' AND user_password ='" + pass_text.Text + "'", con);
                /* in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. */
                DataTable dt = new DataTable(); //this is creating a virtual table  
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    main_menu_bbqshop obj1 = new main_menu_bbqshop();
                    obj1.Show();
                    this.Visible = false;
                    //   /* I have made a new page called home page. If the user is successfully authenticated then the form will be moved to the next form */
                    //   this.Hide();
                    //   new home().Show();
                }
                else
                    MessageBox.Show("Invalid username or password");               
        }       

                  catch(Exception ex)
        {
             MessageBox.Show(ex.Message);
         }
         
               
               //--------------------------------------------------------------
              
            
           
           
           }

            else
            {
                MessageBox.Show("select an option");
            }
                
         //       string own = "select owner_name,password from owner where owner_name='" + name_text.Text + "'and password ='" + pass_text + "' ";
         //       SqlDataAdapter sda1 = new SqlDataAdapter();
         //       DataTable dta = new DataTable();
         //      sda1.Fill(dta);



         //         if (dta.Rows.Count==1)
         //                  {
         //                              owner_menu ap = new owner_menu();
         //                               ap.Show();
         //                                  this.Visible = false;
         //                     }
         //         else
         //         {
         //             MessageBox.Show("Wrong ID OR Password");
         //         }

            
            
         //   }
         //   else if(comboBox1.Text=="EMPLOYEE")
         //   {
         //       if (name_text.Text == "emp" && pass_text.Text == "12345")
         //         {
         //            main_menu_bbqshop ap = new main_menu_bbqshop();
         //               ap.Show();
         //               this.Visible = false;
         //            }
         //       else
         //       {
         //           MessageBox.Show("Wrong ID OR Password");
         //       }

         //   }
            
          
           
         //   else
         //   {
         //       MessageBox.Show("Wrong ID OR Password");
         //   }

        // //   {
        //        this.Hide();
        //        owner_menu m = new owner_menu();
        //        m.Show();
        //        this.Hide();
        ////    }
            
        }

        public int id { get; set; }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        int flag = 0, flag2 = 0;
        private void pass_text_TextChanged(object sender, EventArgs e)
        {
            if (Control.IsKeyLocked(Keys.CapsLock) && flag == 0)
            {
                MessageBox.Show("The Caps Lock key is ON.");
                flag++;
            }
        }

        private void name_text_TextChanged(object sender, EventArgs e)
        {
            if (Control.IsKeyLocked(Keys.CapsLock) && flag2 == 0)
            {
                MessageBox.Show("The Caps Lock key is ON.");
                flag2++;
            }
        }

        private void login_label_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            confirm_exit ce = new confirm_exit();
            ce.Show();
            this.Visible = false;

        }
    }
}
