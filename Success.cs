using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PharmacyApp
{
    public partial class Success : Form
    {
        public Success()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();

        }

        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private void Success_Load(object sender, EventArgs e)
        {
            timer.Interval = 300;
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
