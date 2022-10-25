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
using templet;

namespace project_sw_visual
{
    public partial class categoryform : Form
    {
        public categoryform()
        {
            InitializeComponent();
        }
        //open connection with the database
        SqlConnection Connection = new SqlConnection(@"Data Source=DESKTOP-5KFGSIE\SQLEXPRESS;Initial Catalog=hos;Integrated Security=True");
        private void populate()//fill the data grid view with all items in the category table
        {
            Connection.Open();
            string query = "select*from categoryTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, Connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CatDGV.DataSource = ds.Tables[0];
            Connection.Close();
        }
        private void categoryform_Load(object sender, EventArgs e)//display the function when the form load
        {
            populate();
        }
        private void CatDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)//fill the textboxes with the selected rows
        {  
            CategoryId.Text = CatDGV.SelectedRows[0].Cells[0].Value.ToString();
            CategoryName.Text = CatDGV.SelectedRows[0].Cells[1].Value.ToString();
            CategoryDescription.Text = CatDGV.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void Delete_Click(object sender, EventArgs e)//delete items from the category table
        {
            //exception handeling if the user enter invalid value
            try
            {
                //check if the user enter the id of the item the user want to delete
                if (CategoryId.Text == "")//in case of not entering the data
                {
                    MessageBox.Show("Select the category to delete ");
                }
                else//in case of entering the data
                {
                    Connection.Open();
                    string query = "delete from categoryTable where catid=" + CategoryId.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category deleted successfully");
                    Connection.Close();
                    populate();
                    //clear all textboxes
                    CategoryId.Text = "";
                    CategoryName.Text = "";
                    CategoryDescription.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Edit_Click_1(object sender, EventArgs e)//edit the items in the category table
        {
            //exception handeling if the user enter invalid value
            try
            {
                //check if the user enter all required information
                if (CategoryId.Text == "" || CategoryName.Text == "" || CategoryDescription.Text == "")//in case of not entering any of the data
                {
                    MessageBox.Show("Missing Information ");
                }
                else//in case of entering all the data
                {
                    Connection.Open();
                    string query = "update categoryTable set catname='" + CategoryName.Text + "',catdesc='" + CategoryDescription.Text + "'where catid=" + CategoryId.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category updated successfully");
                    Connection.Close();
                    populate();
                    //clear all textboxes
                    CategoryId.Text = "";
                    CategoryName.Text = "";
                    CategoryDescription.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Add_Click(object sender, EventArgs e)//add a new category to the category table
        {
            //exception handeling if the user enter invalid value
            try
            {
                Connection.Open();
                string query = "insert into categoryTable values(" + CategoryId.Text + ",'" + CategoryName.Text + "','" + CategoryDescription.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("category added successfully");
                Connection.Close();
                populate();
                //clear all textboxes
                CategoryId.Text = "";
                CategoryName.Text = "";
                CategoryDescription.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Exitlabel_Click(object sender, EventArgs e)//give action to the lable making it exit from the application
        {
            Application.Exit();
        }

        private void Sellerlabel_Click(object sender, EventArgs e)//give action to the lable making it hide the current form and show the seller form
        {
            this.Hide();
            sellerForm seller = new sellerForm();
            seller.Show();
        }

        private void ProductLabel_Click(object sender, EventArgs e)//give action to the lable making it hide the current form and show the product form
        {
            Exit prod = new Exit();
            prod.Show();
            this.Hide();
        }

        private void Logoutlabel_Click(object sender, EventArgs e)//give action to the lable making it hide the current form and show the login form
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
