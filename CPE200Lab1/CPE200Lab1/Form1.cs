using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPE200Lab1
{
    public partial class Form1 : Form
    {
        double first,second,result,firstp;
        bool percent;
        string operation;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
            lblDisplay.Text = "0";
        }
        private void btnX_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "";
            }
            if (lblDisplay.Text.Length <= 8)
            {
                lblDisplay.Text = lblDisplay.Text + btn.Text;
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            first = Convert.ToDouble(lblDisplay.Text);
            lblDisplay.Text = "0";
            operation = "+";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            first = Convert.ToDouble(lblDisplay.Text);
            lblDisplay.Text = "0";
            operation = "-";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            first = Convert.ToDouble(lblDisplay.Text);
            lblDisplay.Text = "0";
            operation = "*";
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            percent = true;
            firstp = (Convert.ToDouble(lblDisplay.Text) * first) / 100;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            first = Convert.ToDouble(lblDisplay.Text);
            lblDisplay.Text = "0";
            operation = "/";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            second = Convert.ToDouble(lblDisplay.Text);
            if (operation == "+")
            {
                if (percent = false)
                {
                    result = first + second;
                }
                else
                {
                    result = first + firstp;
                }  
            }
            else if(operation == "-")
            {
                if (percent = false)
                {
                    result = first - second;
                }
                else
                {
                    result = first - firstp;
                }
            }
            else if (operation == "*")
            {
                if (percent = false)
                {
                    result = first * second;
                }
                else
                {
                    result = first * firstp;
                }
            }
            else
            {
                if (percent = false)
                {
                    result = first / second;
                }
                else
                {
                    result = first / firstp;
                }
            }
            lblDisplay.Text = Convert.ToString(result);
        }
    }
}
