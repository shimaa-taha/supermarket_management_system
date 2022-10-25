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
    public partial class splush : Form
    {
        public splush()
        {
            InitializeComponent();
        }
        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        int StartPoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            StartPoint += 1;
            progressBar1.Value = StartPoint;
            if (progressBar1.Value == 100)
            {
                progressBar1.Value = 0;
                timer1.Stop();
                Form1 log = new Form1();
                this.Hide();
                log.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splush_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }
    }
}
