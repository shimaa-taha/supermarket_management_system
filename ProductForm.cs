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
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sohaila\Documents\supermarketdb.mdf;Integrated Security=True;Connect Timeout=30");
        private void FillCombo()//this method will bind the combobox with the database
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select catname from categoryTable", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("catname", typeof(string));
            dt.Load(rdr);
            CatCb.ValueMember = "catname";
            CatCb.DataSource = dt;
            con.Close();
        }
        private void populate()
        {
            con.Open();
            string query = "select*from ProductTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProdDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void label11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Exit_Load(object sender, EventArgs e)
        {
            FillCombo();
            populate();
        }

        private void CatButton_Click(object sender, EventArgs e)
        {
            categoryform cat = new categoryform();
            cat.Show();
            this.Hide();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "insert into ProductTable values(" + ProdId.Text + ",'" + ProdName.Text + "'," + ProdQty.Text + ", " + ProdPrice.Text + ",'" + CatCb.SelectedValue.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product added successfully");
                con.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ProdDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProdId.Text =ProdDGV.SelectedRows[0].Cells[0].Value.ToString();
            ProdName.Text = ProdDGV.SelectedRows[0].Cells[1].Value.ToString();
            ProdQty.Text = ProdDGV.SelectedRows[0].Cells[2].Value.ToString();
            ProdPrice.Text = ProdDGV.SelectedRows[0].Cells[3].Value.ToString();
            CatCb.SelectedValue = ProdDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProdId.Text == "")//if catId <1 
                {
                    MessageBox.Show("Select the category to delete ");
                }
                else
                {
                    con.Open();
                    string query = "delete from ProductTable where productid=" + ProdId.Text + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product deleted successfully");
                    con.Close();
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            sellerForm seller = new sellerForm();
            seller.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }
    }
}
