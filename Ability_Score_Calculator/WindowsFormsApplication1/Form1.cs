using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public int pointsLeft = 27;
        public int str = 8;

        public Form1()
        {
            InitializeComponent();
            this.label1.Text = pointsLeft.ToString();
            this.label3.Text = str.ToString();
            this.label4.Text = "-1";
            this.label5.Text = "1";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.label1.Text = "Time " + DateTime.Now.ToLongTimeString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }



    }
}
