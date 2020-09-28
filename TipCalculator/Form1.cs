using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tipButton_Click(object sender, EventArgs e)
        {
            double bill = double.Parse(billBox.Text);
            double tip = double.Parse(tipPercentageBox.Text);

            double total = bill + bill * (tip / 100);
            tipBox.Text = total.ToString();
        }

        private void billBox_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(billBox.Text, out double bill)) 
            {
                tipButton.Enabled = false;
            } else
            {
                tipButton.Enabled = true;
            }
        }

        private void tipPercentageBox_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(tipPercentageBox.Text, out double bill))
            {
                tipButton.Enabled = false;
            }
            else
            {
                tipButton.Enabled = true;
            }
        }
    }
}
