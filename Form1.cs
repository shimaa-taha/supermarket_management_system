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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string sellerName = "";
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sohaila\Documents\supermarketdb.mdf;Integrated Security=True;Connect Timeout=30");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UnameTb.Text == "" || passTb.Text == "")
            {
                MessageBox.Show("Enter The UserName And Password");
            }
            else
            {
                if (RoleCb.SelectedIndex > -1)
                {
                    if (RoleCb.SelectedItem.ToString() == "ADMIN")
                    {
                        if (UnameTb.Text == "Admin" && passTb.Text == "Admin")
                        {
                            Exit prod = new Exit();
                            prod.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("If You Are The Admin , Enter The Correct Id and Password");
                        }
                    }
                    else
                    {
                        //  MessageBox.Show("You In The Seller Section"); 
                        con.Open();
                        SqlDataAdapter sda = new SqlDataAdapter("Select count(8) from sellerTable where sellername ='" + UnameTb.Text + "'and sellerpass ='" + passTb.Text + "'", con);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        if(dt.Rows[0][0].ToString() == "1")
                        {
                            sellerName = UnameTb.Text;
                            SellingForm sell = new SellingForm();
                            sell.Show();
                            this.Hide();
                            con.Close();
                        } 
                        else
                        {
                            MessageBox.Show("Wrong UserName or Passwoed");
                        }
                        con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Select a Role");
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            UnameTb.Text = "";
            passTb.Text = "";
        }
    }
}
