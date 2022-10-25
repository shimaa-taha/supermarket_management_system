using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using templet;
using System.Data.SqlClient;

namespace project_sw_visual
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public static string SellerName = "";
        public static string AdminName = "";
        //make a connection with the database
        SqlConnection Connection = new SqlConnection(@"Data Source=DESKTOP-5KFGSIE\SQLEXPRESS;Initial Catalog=hos;Integrated Security=True");
       
        private void ExitLable_Click(object sender, EventArgs e)//give action to the lable making it exit from the application
        {
            Application.Exit();
        }
        private void ClearLable_Click(object sender, EventArgs e)//empty the textboxes (clear them)
        {
            UserNameTb.Text = "";
            PasswordTb.Text = "";
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //check if the user enter the username and the password 
            if (UserNameTb.Text == "" || PasswordTb.Text == "")//in case of not entering any thing in textboxes
            {
                MessageBox.Show("Enter The UserName And Password");
            }
            else //in case of filling the textboxes
            {
                //check if the user select a role from the combobox
                if (RoleCb.SelectedIndex > -1)//in case of selecting a role
                {
                    
                    if (RoleCb.SelectedItem.ToString() == "ADMIN")//in case of selecting the Admin role
                    {
                        Connection.Open();
                        SqlDataAdapter sda = new SqlDataAdapter("Select count(8) from AdminTable where AdminName ='" + UserNameTb.Text + "'and AdminPass ='" + PasswordTb.Text + "'", Connection);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        //check if the username and the password are right
                        if (dt.Rows[0][0].ToString() == "1")//in case of they are right
                        {
                            //open the category form for the admin
                            AdminName = UserNameTb.Text;
                            categoryform category = new categoryform();
                            category.Show();
                            this.Hide();
                            Connection.Close();
                        }
                        else//in case of one of them is wrong or both  
                        {
                            MessageBox.Show("Wrong UserName or Passwoed");
                        }
                        Connection.Close();
                    }
                    else //in case of selecting the seller role
                    {
                        
                        Connection.Open();
                        SqlDataAdapter sda = new SqlDataAdapter("Select count(8) from sellerTable where sellername ='" + UserNameTb.Text + "'and sellerpass ='" + PasswordTb.Text + "'", Connection);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        //check if the username and the password are right
                        if (dt.Rows[0][0].ToString() == "1")//in case of they are right
                        {
                            //open the selling form for the seller
                            SellerName = UserNameTb.Text;
                            SellingForm sell = new SellingForm();
                            sell.Show();
                            this.Hide();
                            Connection.Close();
                        }
                        else//in case of one of them is wrong or both  
                        {
                            MessageBox.Show("Wrong UserName or Passwoed");
                        }
                        Connection.Close();
                    }
                }
                else//in case of not selectig a role
                {
                    MessageBox.Show("Select a Role");
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
