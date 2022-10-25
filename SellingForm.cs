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
namespace project_sw_visual
{
    public partial class SellingForm : Form
    {
        public SellingForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5KFGSIE\SQLEXPRESS;Initial Catalog=hos;Integrated Security=True");
        private void populate()
        {
            con.Open();
            string query = "select productnames,prodQTY from ProductTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProdDGV1.DataSource = ds.Tables[0];
            con.Close();
        }
        private void populatebills()
        {
            con.Open();
            string query = "select * from BillTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BillisDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void SellingForm_Load(object sender, EventArgs e)
        {
            populate();
            populatebills();
            FillCombo();
            SellerNamelbl.Text = Login.SellerName; 
        }
        private void ProdDGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            productnames.Text = ProdDGV1.SelectedRows[0].Cells[0].Value.ToString();
            prodPrice.Text = ProdDGV1.SelectedRows[0].Cells[1].Value.ToString();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Datelbl.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
        }
        int Grdtotal = 0, n = 0;

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (Billid.Text == "")
            {
                MessageBox.Show("Missing Bill Id");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "insert into BillTable values(" + Billid.Text + ",'" + SellerNamelbl.Text + "','" + Datelbl.Text + "', " + Amtlbl.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order added successfully");
                    con.Close();
                    populatebills();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void BillisDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Family SuperMarket", new Font("Century Gothic",25,FontStyle.Bold),Brushes.Blue,new Point(230));
            e.Graphics.DrawString("Bill ID :"+BillisDGV.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century Gothic",20,FontStyle.Bold),Brushes.Red,new Point(100,70));
            e.Graphics.DrawString("Seller Name :"+BillisDGV.SelectedRows[0].Cells[1].Value.ToString(), new Font("Century Gothic",20,FontStyle.Bold),Brushes.Red,new Point(100,100));
            e.Graphics.DrawString("Date :"+BillisDGV.SelectedRows[0].Cells[2].Value.ToString(), new Font("Century Gothic",20,FontStyle.Bold),Brushes.Red,new Point(100,130));
            e.Graphics.DrawString("Total Amount :"+BillisDGV.SelectedRows[0].Cells[3].Value.ToString(), new Font("Century Gothic",20,FontStyle.Bold),Brushes.Red,new Point(100,160));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            string query = "select productnames, prodQTY from ProductTable where prodCat = '" + comboBox1.SelectedValue.ToString();
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProdDGV1.DataSource = ds.Tables[0];
            con.Close();
        }
        private void FillCombo()//this method will bind the combobox with the database
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select catname from categoryTable", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("catname", typeof(string));
            dt.Load(rdr);
            con.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void ORDERDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Billid.Text == "")//if catId <1 
                {
                    MessageBox.Show("Select the product to delete ");
                }
                else
                {
                    con.Open();
                    string query = "delete from BillTable where Billid=" + Billid.Text + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product deleted successfully");
                    con.Close();
                    populate();
                    Billid.Text = "";
                    productnames.Text = "";
                    prodPrice.Text = "";
                    prodQTY.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (productnames.Text == "" || prodQTY.Text == "")
            {
                MessageBox.Show("Missing data");
            }
            else
            {
                int total = Convert.ToInt32(prodPrice.Text) * Convert.ToInt32(prodQTY.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(ORDERDGV);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = productnames.Text;
                newRow.Cells[2].Value = prodPrice.Text;
                newRow.Cells[3].Value = prodQTY.Text;
                newRow.Cells[4].Value = Convert.ToInt32(prodPrice.Text) * Convert.ToInt32(prodQTY.Text);
                ORDERDGV.Rows.Add(newRow);
                n++;
                Grdtotal = Grdtotal + total;
                Amtlbl.Text = ""+ Grdtotal;
            }
        }
    }
}
