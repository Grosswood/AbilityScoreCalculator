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
        attribute str = new attribute();
        attribute agi = new attribute();
        attribute con = new attribute();
        attribute intel = new attribute();
        attribute wis = new attribute();
        attribute cha = new attribute();

        public void printStr()
        {
            this.label3.Text = str.value.ToString();
            this.label4.Text = (((str.value - 8) / 2) - 1).ToString();
            this.label5.Text = str.cost.ToString();
            this.label1.Text = pointsLeft.ToString();
        }

        public void printAgi()
        {
            this.label6.Text = agi.value.ToString();
            this.label7.Text = (((agi.value - 8) / 2) - 1).ToString();
            this.label8.Text = agi.cost.ToString();
            this.label1.Text = pointsLeft.ToString();
        }

        public void printCon()
        {
            this.label10.Text = con.value.ToString();
            this.label11.Text = (((con.value - 8) / 2) - 1).ToString();
            this.label12.Text = con.cost.ToString();
            this.label1.Text = pointsLeft.ToString();
        }

        public void printIntel()
        {
            this.label14.Text = intel.value.ToString();
            this.label15.Text = (((intel.value - 8) / 2) - 1).ToString();
            this.label16.Text = intel.cost.ToString();
            this.label1.Text = pointsLeft.ToString();
        }

        public void printWis()
        {
            this.label18.Text = wis.value.ToString();
            this.label19.Text = (((wis.value - 8) / 2) - 1).ToString();
            this.label20.Text = wis.cost.ToString();
            this.label1.Text = pointsLeft.ToString();
        }

        public void printCha()
        {
            this.label22.Text = cha.value.ToString();
            this.label23.Text = (((cha.value - 8) / 2) - 1).ToString();
            this.label24.Text = cha.cost.ToString();
            this.label1.Text = pointsLeft.ToString();
        }

        public Form1()
        {
            InitializeComponent();
            printStr();
            printAgi();
            printCon();
            printIntel();
            printWis();
            printCha();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (str.value < 15)
            {
                str.increase();
                pointsLeft--;
                if (str.value > 13)
                {
                    pointsLeft--;
                }
                printStr();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (str.value > 8)
            {
                str.decrease();
                pointsLeft++;
                if (str.value > 12)
                {
                    pointsLeft++;
                }
                printStr();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (agi.value < 15)
            {
                agi.increase();
                pointsLeft--;
                if (agi.value > 13)
                {
                    pointsLeft--;
                }
                printAgi();
            }
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            if (agi.value > 8)
            {
                agi.decrease();
                pointsLeft++;
                if (agi.value > 12)
                {
                    pointsLeft++;
                }
                printAgi();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (con.value < 15)
            {
                con.increase();
                pointsLeft--;
                if (con.value > 13)
                {
                    pointsLeft--;
                }
                printCon();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (con.value > 8)
            {
                con.decrease();
                pointsLeft++;
                if (con.value > 12)
                {
                    pointsLeft++;
                }
                printCon();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (intel.value < 15)
            {
                intel.increase();
                pointsLeft--;
                if (intel.value > 13)
                {
                    pointsLeft--;
                }
                printIntel();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (intel.value > 8)
            {
                intel.decrease();
                pointsLeft++;
                if (intel.value > 12)
                {
                    pointsLeft++;
                }
                printIntel();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (wis.value < 15)
            {
                wis.increase();
                pointsLeft--;
                if (wis.value > 13)
                {
                    pointsLeft--;
                }
                printWis();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (wis.value > 8)
            {
                wis.decrease();
                pointsLeft++;
                if (wis.value > 12)
                {
                    pointsLeft++;
                }
                printWis();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (cha.value < 15)
            {
                cha.increase();
                pointsLeft--;
                if (cha.value > 13)
                {
                    pointsLeft--;
                }
                printCha();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (cha.value > 8)
            {
                cha.decrease();
                pointsLeft++;
                if (cha.value > 12)
                {
                    pointsLeft++;
                }
                printCha();
            }
        }

    }
    
    
    class attribute
    {
        public int value = 8;
        public int modifier = -1;
        public int cost = 1;
        public void adjust()
        {
            modifier = ((value - 8) / 2) - 1;
            if (value > 12)
            {
                cost = 2;
            }
            else
            {
                cost = 1;
            }
        }
        public void increase()
        {
            value++;
            adjust();
        }
        public void decrease()
        {
            value--;
            adjust();
        }
    }
}
