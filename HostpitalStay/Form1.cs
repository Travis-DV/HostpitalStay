using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostpitalStay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //meds, surgical, lab, PT
        private int[] misccosts = { 0, 0, 0, 0, 0 };
        private int basecost = 0;

        private bool Isempty(string inputstr)
        {
            if (inputstr == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private int Turnintoint(string inputstring, int biggerthen = 0)
        {
            int inputnum;
            bool passesdparse = int.TryParse(inputstring, out inputnum);
            if (passesdparse && inputnum > biggerthen) { return inputnum; }
            else
            {
                if (Isempty(inputstring))
                {
                    return biggerthen;
                }
                else
                {
                    return biggerthen - 1;
                }
            }
        }

        private void calculatemisccost()
        {
            misccosts[0] = Turnintoint(medsTB.Text);
            misccosts[1] = Turnintoint(surgicalTB.Text);
            misccosts[2] = Turnintoint(labTB.Text);
            misccosts[3] = Turnintoint(rehabTB.Text);
            if (misccosts[0] >= 0 && misccosts[1] >= 0 && misccosts[2] >= 0 && misccosts[3] >= 0)
            {
                misccosts[4] = misccosts[0] + misccosts[1] + misccosts[2] + misccosts[3];
                totalcost();
            }
            else
            {
                outputLB.Text = "Please input a number!";
            }
        }

        private void totalcost()
        {
            int totalcost = misccosts[4] + basecost;
            outputLB.Text = $"Your total cost is: {totalcost}";
        }

        private void medsTB_TextChanged(object sender, EventArgs e)
        {
            calculatemisccost();
        }

        private void surgicalTB_TextChanged(object sender, EventArgs e)
        {
            calculatemisccost();
        }

        private void labTB_TextChanged(object sender, EventArgs e)
        {
            calculatemisccost();
        }

        private void rehabTB_TextChanged(object sender, EventArgs e)
        {
            calculatemisccost();
        }

        private void daysTB_TextChanged(object sender, EventArgs e)
        {
            basecost = Turnintoint(daysTB.Text);
            if (basecost > -1)
            {
                basecost = basecost * 350;
                totalcost();
            }
            else
            {
                outputLB.Text = "Please input a number!";
            }
        }
    }
}
