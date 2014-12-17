using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public int pointsLeft = 27; //points can be spent on increasing abilities
        public int additionalPoints = 0; // those are needed for alt. human and half-elf customization
        //public string raceFolderPath = Path.Combine(System.IO.Directory.GetCurrentDirectory(), "Races"); //that is an old route, saved just in case
        ability str = new ability();
        ability agi = new ability();
        ability con = new ability();
        ability intel = new ability();
        ability wis = new ability();
        ability cha = new ability();
        //printAbility is kind of function for display ability and change related to it variables
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
        //in few cases buttons related to the race addition is needed to be closed by that function
        public void hideRaces()
        {
            this.button14.Visible = false;

            this.button15.Visible = false;
            this.button16.Visible = false;
            this.button17.Visible = false;
            this.button18.Visible = false;
            this.button19.Visible = false;
            this.button20.Visible = false;
            this.button21.Visible = false;
            this.button22.Visible = false;
            this.button23.Visible = false;
            this.button24.Visible = false;
            this.button25.Visible = false;
            this.button26.Visible = false;
            this.button27.Visible = false;
            this.button28.Visible = false;
            this.button29.Visible = false;
            this.button30.Visible = false;

            this.button31.Visible = false;
            this.button32.Visible = false;
            this.button33.Visible = false;
            this.button34.Visible = false;
            this.button35.Visible = false;
            this.button36.Visible = false;
        }
        //if one or more abilities are changed, this function rewrite all related buttons
        public void reWriteStats()
        {
            str.adjust();
            agi.adjust();
            con.adjust();
            intel.adjust();
            wis.adjust();
            cha.adjust();

            printStr();
            printAgi();
            printCon();
            printIntel();
            printWis();
            printCha();
        }
        //Additiononal buttons are needed for alt. human and half-elf customization and hidden when seitching to another race
        public void hideAditionalCustomizationButton()
        {
            this.button31.Visible = false;
            this.button32.Visible = false;
            this.button33.Visible = false;
            this.button34.Visible = false;
            this.button35.Visible = false;
            this.button36.Visible = false;
        }
        //this functions allow to finish spending points on abilities and lock them and also summon choose race button
        public void ifPointsLeftIsZero()
        {
            if (pointsLeft == 0)
            {
                //this.pictureBox1.Visible = true;
                this.button14.Visible = true;
                //put it in each increase button
            }
        }
        //abilities can be locked before race choosing and only after ALL points spent
        public void ifPointsLeftIsNotZero()
        {
            if (pointsLeft != 0)
            {
                //this.pictureBox1.Visible = true;
                this.button14.Visible = false;
                //put it in each increase button
            }
        }

        public Form1()
        {
            InitializeComponent();
            this.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            reWriteStats();
            hideRaces();
            //pictureBox1.Image = Image.FromFile(xPath);
            //public static string oPath = Path.Combine(System.IO.Directory.GetCurrentDirectory(), "O.png");
        }
        //buttons 1,3,5,7,9,11 is for increase ability ('+'), buttons 2,4,6,8,10,12 is to decrease ('-')
        private void button1_Click(object sender, EventArgs e)
        {
            if ((str.value < 13 & pointsLeft > 0) || ( str.value < 15 & pointsLeft > 1))
            {
                str.increase();
                pointsLeft--;
                if (str.value > 13)
                {
                    pointsLeft--;
                }
                printStr();
                ifPointsLeftIsZero();
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
                ifPointsLeftIsNotZero();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((agi.value < 13 & pointsLeft > 0) || (agi.value < 15 & pointsLeft > 1))
            {
                agi.increase();
                pointsLeft--;
                if (agi.value > 13)
                {
                    pointsLeft--;
                }
                printAgi();
                ifPointsLeftIsZero();
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
                ifPointsLeftIsNotZero();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if ((con.value < 13 & pointsLeft > 0) || (con.value < 15 & pointsLeft > 1))
            {
                con.increase();
                pointsLeft--;
                if (con.value > 13)
                {
                    pointsLeft--;
                }
                printCon();
                ifPointsLeftIsZero();
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
                ifPointsLeftIsNotZero();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if ((intel.value < 13 & pointsLeft > 0) || (intel.value < 15 & pointsLeft > 1))
            {
                intel.increase();
                pointsLeft--;
                if (intel.value > 13)
                {
                    pointsLeft--;
                }
                printIntel();
                ifPointsLeftIsZero();
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
                ifPointsLeftIsNotZero();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if ((wis.value < 13 & pointsLeft > 0) || (wis.value < 15 & pointsLeft > 1))
            {
                wis.increase();
                pointsLeft--;
                if (wis.value > 13)
                {
                    pointsLeft--;
                }
                printWis();
                ifPointsLeftIsZero();
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
                ifPointsLeftIsNotZero();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if ((cha.value < 13 & pointsLeft > 0) || (cha.value < 15 & pointsLeft > 1))
            {
                cha.increase();
                pointsLeft--;
                if (cha.value > 13)
                {
                    pointsLeft--;
                }
                printCha();
                ifPointsLeftIsZero();
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
                ifPointsLeftIsNotZero();
            }
        }
        //reset all button
        private void button13_Click(object sender, EventArgs e)
        {
            str.value = 8;
            agi.value = 8;
            con.value = 8;
            intel.value = 8;
            wis.value = 8;
            cha.value = 8;

            pointsLeft = 27;
            this.pictureBox1.Visible = false;
            hideRaces();
            reWriteStats();

            this.button1.Visible = true;
            this.button2.Visible = true;
            this.button3.Visible = true;
            this.button4.Visible = true;
            this.button5.Visible = true;
            this.button6.Visible = true;
            this.button7.Visible = true;
            this.button8.Visible = true;
            this.button9.Visible = true;
            this.button10.Visible = true;
            this.button11.Visible = true;
            this.button12.Visible = true;
        }
        //choose race button
        private void button14_Click(object sender, EventArgs e)
        {
            this.button1.Visible = false;
            this.button2.Visible = false;
            this.button3.Visible = false;
            this.button4.Visible = false;
            this.button5.Visible = false;
            this.button6.Visible = false;
            this.button7.Visible = false;
            this.button8.Visible = false;
            this.button9.Visible = false;
            this.button10.Visible = false;
            this.button11.Visible = false;
            this.button12.Visible = false;

            str.valueNoRace = str.value;
            agi.valueNoRace = agi.value;
            con.valueNoRace = con.value;
            intel.valueNoRace = intel.value;
            wis.valueNoRace = wis.value;
            cha.valueNoRace = cha.value;

            this.button15.Visible = true;
            this.button16.Visible = true;
            this.button17.Visible = true;
            this.button18.Visible = true;
            this.button19.Visible = true;
            this.button20.Visible = true;
            this.button21.Visible = true;
            this.button22.Visible = true;
            this.button23.Visible = true;
            this.button24.Visible = true;
            this.button25.Visible = true;
            this.button26.Visible = true;
            this.button27.Visible = true;
            this.button28.Visible = true;
            this.button29.Visible = true;
        }
        // buttons 15 - 29 is for races
        private void button15_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = WindowsFormsApplication1.Properties.Resources.Dwarf;
            this.pictureBox1.Visible = true;
            this.button14.Visible = false;
            this.button30.Visible = true;
            hideAditionalCustomizationButton();

            str.value = str.valueNoRace + 2;
            agi.value = agi.valueNoRace;
            con.value = con.valueNoRace + 2;
            intel.value = intel.valueNoRace;
            wis.value = wis.valueNoRace;
            cha.value = cha.valueNoRace;

            reWriteStats();
            //pictureBox1.Image = Image.FromFile(Path.Combine(raceFolderPath, "Dragonborn.png"));
        }

        private void button16_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = WindowsFormsApplication1.Properties.Resources.Dwarf;
            this.pictureBox1.Visible = true;
            this.button14.Visible = false;
            this.button30.Visible = true;
            hideAditionalCustomizationButton();

            str.value = str.valueNoRace;
            agi.value = agi.valueNoRace;
            con.value = con.valueNoRace + 2;
            intel.value = intel.valueNoRace;
            wis.value = wis.valueNoRace + 1;
            cha.value = cha.valueNoRace;

            reWriteStats();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = WindowsFormsApplication1.Properties.Resources.Elf;
            this.pictureBox1.Visible = true;
            this.button14.Visible = false;
            this.button30.Visible = true;
            hideAditionalCustomizationButton();

            str.value = str.valueNoRace;
            agi.value = agi.valueNoRace + 2;
            con.value = con.valueNoRace;
            intel.value = intel.valueNoRace + 1;
            wis.value = wis.valueNoRace;
            cha.value = cha.valueNoRace;

            reWriteStats();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = WindowsFormsApplication1.Properties.Resources.Elf;
            this.pictureBox1.Visible = true;
            this.button14.Visible = false;
            this.button30.Visible = true;
            hideAditionalCustomizationButton();

            str.value = str.valueNoRace;
            agi.value = agi.valueNoRace + 2;
            con.value = con.valueNoRace;
            intel.value = intel.valueNoRace;
            wis.value = wis.valueNoRace + 1;
            cha.value = cha.valueNoRace;

            reWriteStats();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = WindowsFormsApplication1.Properties.Resources.Elf;
            this.pictureBox1.Visible = true;
            this.button14.Visible = false;
            this.button30.Visible = true;
            hideAditionalCustomizationButton();

            str.value = str.valueNoRace;
            agi.value = agi.valueNoRace + 2;
            con.value = con.valueNoRace;
            intel.value = intel.valueNoRace;
            wis.value = wis.valueNoRace;
            cha.value = cha.valueNoRace + 1;

            reWriteStats();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = WindowsFormsApplication1.Properties.Resources.Halfling;
            this.pictureBox1.Visible = true;
            this.button14.Visible = false;
            this.button30.Visible = true;
            hideAditionalCustomizationButton();

            str.value = str.valueNoRace;
            agi.value = agi.valueNoRace + 2;
            con.value = con.valueNoRace;
            intel.value = intel.valueNoRace;
            wis.value = wis.valueNoRace;
            cha.value = cha.valueNoRace + 1;

            reWriteStats();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = WindowsFormsApplication1.Properties.Resources.Halfling;
            this.pictureBox1.Visible = true;
            this.button14.Visible = false;
            this.button30.Visible = true;
            hideAditionalCustomizationButton();

            str.value = str.valueNoRace;
            agi.value = agi.valueNoRace + 2;
            con.value = con.valueNoRace + 1;
            intel.value = intel.valueNoRace;
            wis.value = wis.valueNoRace;
            cha.value = cha.valueNoRace;

            reWriteStats();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = WindowsFormsApplication1.Properties.Resources.Human;
            this.pictureBox1.Visible = true;
            this.button14.Visible = false;
            this.button30.Visible = true;
            hideAditionalCustomizationButton();

            str.value = str.valueNoRace + 1;
            agi.value = agi.valueNoRace + 1;
            con.value = con.valueNoRace + 1;
            intel.value = intel.valueNoRace + 1;
            wis.value = wis.valueNoRace + 1;
            cha.value = cha.valueNoRace + 1;

            reWriteStats();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = WindowsFormsApplication1.Properties.Resources.Human;
            this.pictureBox1.Visible = true;
            this.button14.Visible = false;
            this.button30.Visible = true;
            additionalPoints = 2;

            //those button are for human customization
            this.button31.Visible = true;
            this.button32.Visible = true;
            this.button33.Visible = true;
            this.button34.Visible = true;
            this.button35.Visible = true;
            this.button36.Visible = true;

            str.value = str.valueNoRace;
            agi.value = agi.valueNoRace;
            con.value = con.valueNoRace;
            intel.value = intel.valueNoRace;
            wis.value = wis.valueNoRace;
            cha.value = cha.valueNoRace;

            reWriteStats();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = WindowsFormsApplication1.Properties.Resources.Dragonborn;
            this.pictureBox1.Visible = true;
            this.button14.Visible = false;
            this.button30.Visible = true;
            hideAditionalCustomizationButton();

            str.value = str.valueNoRace + 2;
            agi.value = agi.valueNoRace;
            con.value = con.valueNoRace;
            intel.value = intel.valueNoRace;
            wis.value = wis.valueNoRace;
            cha.value = cha.valueNoRace + 1;

            reWriteStats();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = WindowsFormsApplication1.Properties.Resources.Gnome;
            this.pictureBox1.Visible = true;
            this.button14.Visible = false;
            this.button30.Visible = true;
            hideAditionalCustomizationButton();

            str.value = str.valueNoRace;
            agi.value = agi.valueNoRace + 1;
            con.value = con.valueNoRace;
            intel.value = intel.valueNoRace + 2;
            wis.value = wis.valueNoRace;
            cha.value = cha.valueNoRace;

            reWriteStats();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = WindowsFormsApplication1.Properties.Resources.Gnome;
            this.pictureBox1.Visible = true;
            this.button14.Visible = false;
            this.button30.Visible = true;
            hideAditionalCustomizationButton();

            str.value = str.valueNoRace;
            agi.value = agi.valueNoRace;
            con.value = con.valueNoRace + 1;
            intel.value = intel.valueNoRace + 2;
            wis.value = wis.valueNoRace;
            cha.value = cha.valueNoRace;

            reWriteStats();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = WindowsFormsApplication1.Properties.Resources.Half_elf;
            this.pictureBox1.Visible = true;
            this.button14.Visible = false;
            this.button30.Visible = true;
            additionalPoints = 2;

            //those button are for half-elf customization
            this.button31.Visible = true;
            this.button32.Visible = true;
            this.button33.Visible = true;
            this.button34.Visible = true;
            this.button35.Visible = true;


            str.value = str.valueNoRace;
            agi.value = agi.valueNoRace;
            con.value = con.valueNoRace;
            intel.value = intel.valueNoRace;
            wis.value = wis.valueNoRace;
            cha.value = cha.valueNoRace + 2;

            reWriteStats();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = WindowsFormsApplication1.Properties.Resources.Half_orc;
            this.pictureBox1.Visible = true;
            this.button14.Visible = false;
            this.button30.Visible = true;
            hideAditionalCustomizationButton();

            str.value = str.valueNoRace + 2;
            agi.value = agi.valueNoRace;
            con.value = con.valueNoRace + 1;
            intel.value = intel.valueNoRace;
            wis.value = wis.valueNoRace;
            cha.value = cha.valueNoRace;

            reWriteStats();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = WindowsFormsApplication1.Properties.Resources.Tiefling;
            this.pictureBox1.Visible = true;
            this.button14.Visible = false;
            this.button30.Visible = true;
            hideAditionalCustomizationButton();

            str.value = str.valueNoRace;
            agi.value = agi.valueNoRace;
            con.value = con.valueNoRace;
            intel.value = intel.valueNoRace + 1;
            wis.value = wis.valueNoRace;
            cha.value = cha.valueNoRace + 2;
            
            reWriteStats();
        }
        //reset races button
        private void button30_Click(object sender, EventArgs e)
        {
            str.value = str.valueNoRace;
            agi.value = agi.valueNoRace;
            con.value = con.valueNoRace;
            intel.value = intel.valueNoRace;
            wis.value = wis.valueNoRace;
            cha.value = cha.valueNoRace;

            reWriteStats();
            hideRaces();

            this.pictureBox1.Visible = false;
            this.button14.Visible = true;

            this.button1.Visible = true;
            this.button2.Visible = true;
            this.button3.Visible = true;
            this.button4.Visible = true;
            this.button5.Visible = true;
            this.button6.Visible = true;
            this.button7.Visible = true;
            this.button8.Visible = true;
            this.button9.Visible = true;
            this.button10.Visible = true;
            this.button11.Visible = true;
            this.button12.Visible = true;
        }
        //buttons 31-36 is for customizing Half-elf and Alter. Human
        private void button31_Click(object sender, EventArgs e)
        {
            str.increase();
            printStr();
            this.button31.Visible = false;
            additionalPoints--;
            if (additionalPoints == 0)
            {
                hideAditionalCustomizationButton();
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            agi.increase();
            printAgi();
            this.button32.Visible = false;
            additionalPoints--;
            if (additionalPoints == 0)
            {
                hideAditionalCustomizationButton();
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            con.increase();
            printCon();
            this.button33.Visible = false;
            additionalPoints--;
            if (additionalPoints == 0)
            {
                hideAditionalCustomizationButton();
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            intel.increase();
            printIntel();
            this.button34.Visible = false;
            additionalPoints--;
            if (additionalPoints == 0)
            {
                hideAditionalCustomizationButton();
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            wis.increase();
            printWis();
            this.button35.Visible = false;
            additionalPoints--;
            if (additionalPoints == 0)
            {
                hideAditionalCustomizationButton();
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            cha.increase();
            printCha();
            this.button36.Visible = false;
            additionalPoints--;
            if (additionalPoints == 0)
            {
                hideAditionalCustomizationButton();
            }
        }

    }
    
    
    class ability
    {
        public int value = 8;
        public int valueNoRace = 0;
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
