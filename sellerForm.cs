using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using templet;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace project_sw_visual
{
    public partial class sellerForm : Form
    {
        public sellerForm()
        {
            InitializeComponent();
        }
        //open connection with the database
        SqlConnection Connection = new SqlConnection(@"Data Source=DESKTOP-5KFGSIE\SQLEXPRESS;Initial Catalog=hos;Integrated Security=True");

        private void populate()//fill the data grid view with all sellers in the seller table
        {
            Connection.Open();
            string query = "select*from sellerTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, Connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            SellerDGV.DataSource = ds.Tables[0];
            Connection.Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)//delete sellers from the seller table
        {
            //exception handeling if the user enter invalid value
            try
            {
                //check if the user enter the id of the seller the user want to delete
                if (SellerId.Text == "")//in case of not entering the data
                {
                    MessageBox.Show("Select the Seller to delete ");
                }
                else//in case of entering the data
                {
                    Connection.Open();
                    string query = "delete from sellerTable where sellerid=" + SellerId.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller deleted successfully");
                    Connection.Close();
                    populate();
                    //clear all textboxes
                    SellerId.Text = "";
                    SellerName.Text = "";
                    SellerAge.Text = "";
                    SellerPhone.Text = "";
                    SellerPassword.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditSeller_Click(object sender, EventArgs e)//edit the seller's information in the seller table
        {
            //exception handeling if the user enter invalid value
            try
            {
                //check if the user enter all required information
                if (SellerId.Text == "" || SellerName.Text == "" || SellerAge.Text == ""|| SellerPhone.Text == "" || SellerPassword.Text == "")//in case of not entering any of the data
                {
                    MessageBox.Show("Missing Information ");
                }
                else//in case of entering all the data
                {
                    Connection.Open();
                    string query = "update sellerTable set sellername='" + SellerName.Text + "',sellerage='" + SellerAge.Text + "',sellerphone='" + SellerPhone.Text + "',sellerpass='" + SellerPassword.Text + "'where sellerid=" + SellerId.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller updated successfully");
                    Connection.Close();
                    populate();
                    //clear all textboxes
                    SellerId.Text = "";
                    SellerName.Text = "";
                    SellerAge.Text = "";
                    SellerPhone.Text = "";
                    SellerPassword.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddSeller_Click(object sender, EventArgs e)//add a new seller to the seller table
        {
            //exception handeling if the user enter invalid value
            try
            {
                Connection.Open();
                string query = "insert into sellerTable values(" + SellerId.Text + ",'" + SellerName.Text + "'," + SellerAge.Text + ", " + SellerPhone.Text + ",'" + SellerPassword.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Seller added successfully");
                Connection.Close();
                populate();
                //clear all textboxes
                SellerId.Text = "";
                SellerName.Text = "";
                SellerAge.Text = "";
                SellerPhone.Text = "";
                SellerPassword.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Products_Click(object sender, EventArgs e)//give action to the lable making it hide the current form and show the product form
        {
            Exit prod = new Exit();
            prod.Show();
            this.Hide();
        }

        private void Categories_Click(object sender, EventArgs e)//give action to the lable making it hide the current form and show the category form
        {
            categoryform cat = new categoryform();
            cat.Show();
            this.Hide();
        }

        private void SellerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)//fill the textboxes with the selected rows
        {
            SellerId.Text = SellerDGV.SelectedRows[0].Cells[0].Value.ToString();
            SellerName.Text = SellerDGV.SelectedRows[0].Cells[1].Value.ToString();
            SellerAge.Text = SellerDGV.SelectedRows[0].Cells[2].Value.ToString();
            SellerPhone.Text = SellerDGV.SelectedRows[0].Cells[3].Value.ToString();
            SellerPassword.Text = SellerDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void sellerForm_Load(object sender, EventArgs e)//display the function when the form load
        {
            populate();
        }

        private void Exitlabel_Click(object sender, EventArgs e)//give action to the lable making it exit from the application
        {
            Application.Exit();
        }

        private void LogoutLable_Click(object sender, EventArgs e)//give action to the lable making it hide the current form and show the login form
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
    }
}
