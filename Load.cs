using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_sw_visual
{
    public partial class Load : Form
    {
        public Load()
        {
            InitializeComponent();
        }
        int StartPoint = 0;//from which the value of progress bar will start
        private void timer1_Tick(object sender, EventArgs e)//fuction that make the progress bar load
        {
            StartPoint += 1;
            progressBar1.Value = StartPoint;
            if (progressBar1.Value == 100)//hiding the current form when the value of progress bar equal 100
            {
                progressBar1.Value = 0;
                timer1.Stop();
                Login log = new Login();
                this.Hide();
                log.Show();
            }
        }
        private void Load_Load(object sender, EventArgs e)//making the timer start
        {
            timer1.Start();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
