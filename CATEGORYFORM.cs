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
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sohaila\Documents\supermarketdb.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            con.Open();
            string query = "select*from categoryTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CatDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "insert into categoryTable values("+CatId.Text+",'"+CatName.Text+"','"+CatDesc.Text+"')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("category added successfully");
                con.Close();
                populate();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void categoryform_Load(object sender, EventArgs e)
        {
            populate();
        }
        private void CatDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CatId.Text = CatDGV.SelectedRows[0].Cells[0].Value.ToString();
            CatName.Text = CatDGV.SelectedRows[0].Cells[1].Value.ToString();
            CatDesc.Text = CatDGV.SelectedRows[0].Cells[2].Value.ToString();
        }
        private void CatDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (CatId.Text == "")//if catId <1 
                {
                    MessageBox.Show("Select the category to delete ");
                }
                else
                {
                    con.Open();
                    string query = "delete from categoryTable where catid=" + CatId.Text + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category deleted successfully");
                    con.Close();
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CatEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (CatId.Text == ""||CatName.Text==""||CatDesc.Text=="") 
                {
                    MessageBox.Show("Missing Information ");
                }
                else
                {
                    con.Open();
                    string query = "update categoryTable set catname='" + CatName.Text + "',catdesc='" + CatDesc.Text + "'where catid=" + CatId.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category updated successfully");
                    con.Close();
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ProdButton_Click(object sender, EventArgs e)
        {
            Exit prod = new Exit();
            prod.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            sellerForm seller = new sellerForm();
            seller.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }
    }
}
