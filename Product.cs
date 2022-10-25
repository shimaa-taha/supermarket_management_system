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
using project_sw_visual;

namespace templet
{
    public partial class Exit : Form
    {
        public Exit()
        {
            InitializeComponent();
        }
        //open connection with the database
        SqlConnection Connection = new SqlConnection(@"Data Source=DESKTOP-5KFGSIE\SQLEXPRESS;Initial Catalog=hos;Integrated Security=True");
        private void FillCombo()//this method will bind the combobox with the database(product table)
        {
            Connection.Open();
            SqlCommand cmd = new SqlCommand("select catname from categoryTable", Connection);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("catname", typeof(string));
            dt.Load(rdr);
            CategoryCb.ValueMember = "catname";
            CategoryCb.DataSource = dt;
            Connection.Close();
        }
        private void populate()//fill the data grid view with all items in the category table
        {
            Connection.Open();
            string query = "select*from ProductTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, Connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProdDGV.DataSource = ds.Tables[0];
            Connection.Close();
        }
        private void Exit_Load(object sender, EventArgs e)//display the two functions when the form load
        {
            FillCombo();
            populate();
        }

        private void AddButton_Click(object sender, EventArgs e)//add a new product to the product table
        {
            //exception handeling if the user enter invalid value
            try
            {
                Connection.Open();
                string query = "insert into ProductTable values(" + ProductId.Text + ",'" + ProductName.Text + "'," + ProductQuantity.Text + ", " + ProductPrice.Text + ",'" + CategoryCb.SelectedValue.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, Connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product added successfully");
                Connection.Close();
                populate();
                //clear all textboxes
                ProductId.Text = "";
                ProductName.Text = "";
                ProductQuantity.Text = "";
                ProductPrice.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ProdDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)//fill the textboxes with the selected rows
        {
            ProductId.Text =ProdDGV.SelectedRows[0].Cells[0].Value.ToString();
            ProductName.Text = ProdDGV.SelectedRows[0].Cells[1].Value.ToString();
            ProductQuantity.Text = ProdDGV.SelectedRows[0].Cells[2].Value.ToString();
            ProductPrice.Text = ProdDGV.SelectedRows[0].Cells[3].Value.ToString();
            CategoryCb.SelectedValue = ProdDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void DeleteButton_Click(object sender, EventArgs e)//delete product from the product table
        {
            //exception handeling if the user enter invalid value
            try
            {
                //check if the user enter the id of the product the user want to delete
                if (ProductId.Text == "")//in case of not entering the data
                {
                    MessageBox.Show("Select the product to delete ");
                }
                else//in case of entering the data
                {
                    Connection.Open();
                    string query = "delete from ProductTable where productid=" + ProductId.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product deleted successfully");
                    Connection.Close();
                    populate();
                    //clear all textboxes
                    ProductId.Text = "";
                    ProductName.Text = "";
                    ProductQuantity.Text = "";
                    ProductPrice.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void EditButton_Click(object sender, EventArgs e)//edit the products in the product table
        {
            //exception handeling if the user enter invalid value
            try
            {
                //check if the user enter all required information
                if (ProductId.Text == "" || ProductName.Text == "" || ProductQuantity.Text == "" || ProductPrice.Text == "" || CategoryCb.SelectedValue.ToString() == "")//in case of not entering any of the data
                {
                    MessageBox.Show("Missing Information ");
                }
                else//in case of entering all the data
                {
                    Connection.Open();
                    string query = "update ProductTable set productnames='" + ProductName.Text + "',prodQty='" + ProductQuantity.Text + "',prodPrice='" + ProductPrice.Text + "',prodCat='" + CategoryCb.SelectedValue.ToString() + "'where productid=" + ProductId.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product updated successfully");
                    Connection.Close();
                    populate();
                    //clear all textboxes
                    ProductId.Text = "";
                    ProductName.Text = "";
                    ProductQuantity.Text = "";
                    ProductPrice.Text = "";//combobox
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Categories_Click(object sender, EventArgs e)//give action to the lable making it hide the current form and show the category form
        {
            categoryform cat = new categoryform();
            cat.Show();
            this.Hide();
        }
        private void Sellerslabel_Click(object sender, EventArgs e)//give action to the lable making it hide the current form and show the seller form
        {
            this.Hide();
            sellerForm seller = new sellerForm();
            seller.Show();
        }
        private void Logoutlabel_Click(object sender, EventArgs e)//give action to the lable making it hide the current form and show the login form
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
        private void Exitlabel_Click(object sender, EventArgs e)//give action to the lable making it exit from the application
        {
            Application.Exit();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            populate();
        }
    }
}
