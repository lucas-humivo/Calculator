using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double FirstNumber;
        string Operation;
        
        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
            KeyDown += new KeyEventHandler(Form_KeyDown);
            ActiveControl = btnEqual;
        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }

            if (e.KeyCode == Keys.NumPad0)
            {
                if (txtBoxCollector.Text == "0" && txtBoxCollector.Text != null)
                {
                    txtBoxCollector.Text = "0";
                }
                else
                {
                    txtBoxCollector.Text = txtBoxCollector.Text + "0";
                }
            }

            if (e.KeyCode == Keys.NumPad1)
            {
                if (txtBoxCollector.Text == "0" && txtBoxCollector.Text != null)
                {
                    txtBoxCollector.Text = "1";
                }
                else
                {
                    txtBoxCollector.Text = txtBoxCollector.Text + "1";
                }
            }

            if (e.KeyCode == Keys.NumPad2)
            {
                if (txtBoxCollector.Text == "0" && txtBoxCollector.Text != null)
                {
                    txtBoxCollector.Text = "2";
                }
                else
                {
                    txtBoxCollector.Text = txtBoxCollector.Text + "2";
                }
            }

            if (e.KeyCode == Keys.NumPad3)
            {
                if (txtBoxCollector.Text == "0" && txtBoxCollector.Text != null)
                {
                    txtBoxCollector.Text = "3";
                }
                else
                {
                    txtBoxCollector.Text = txtBoxCollector.Text + "3";
                }
            }

            if (e.KeyCode == Keys.NumPad4)
            {
                if (txtBoxCollector.Text == "0" && txtBoxCollector.Text != null)
                {
                    txtBoxCollector.Text = "4";
                }
                else
                {
                    txtBoxCollector.Text = txtBoxCollector.Text + "4";
                }
            }

            if (e.KeyCode == Keys.NumPad5)
            {
                if (txtBoxCollector.Text == "0" && txtBoxCollector.Text != null)
                {
                    txtBoxCollector.Text = "5";
                }
                else
                {
                    txtBoxCollector.Text = txtBoxCollector.Text + "5";
                }
            }

            if (e.KeyCode == Keys.NumPad6)
            {
                if (txtBoxCollector.Text == "0" && txtBoxCollector.Text != null)
                {
                    txtBoxCollector.Text = "6";
                }
                else
                {
                    txtBoxCollector.Text = txtBoxCollector.Text + "6";
                }
            }

            if (e.KeyCode == Keys.NumPad7)
            {
                if (txtBoxCollector.Text == "0" && txtBoxCollector.Text != null)
                {
                    txtBoxCollector.Text = "7";
                }
                else
                {
                    txtBoxCollector.Text = txtBoxCollector.Text + "7";
                }
            }

            if (e.KeyCode == Keys.NumPad8)
            {
                if (txtBoxCollector.Text == "0" && txtBoxCollector.Text != null)
                {
                    txtBoxCollector.Text = "8";
                }
                else
                {
                    txtBoxCollector.Text = txtBoxCollector.Text + "8";
                }
            }

            if (e.KeyCode == Keys.NumPad9)
            {
                if (txtBoxCollector.Text == "0" && txtBoxCollector.Text != null)
                {
                    txtBoxCollector.Text = "9";
                }
                else
                {
                    txtBoxCollector.Text = txtBoxCollector.Text + "9";
                }
            }

            if (e.KeyCode == Keys.Add)
            {
                FirstNumber = Convert.ToDouble(txtBoxCollector.Text);
                txtBoxCollector.Text = "0";
                Operation = "+";
            }

            if (e.KeyCode == Keys.Subtract)
            {
                FirstNumber = Convert.ToDouble(txtBoxCollector.Text);
                txtBoxCollector.Text = "0";
                Operation = "-";
            }

            if (e.KeyCode == Keys.Divide)
            {
                FirstNumber = Convert.ToDouble(txtBoxCollector.Text);
                txtBoxCollector.Text = "0";
                Operation = "/";
            }

            if (e.KeyCode == Keys.Multiply)
            {
                FirstNumber = Convert.ToDouble(txtBoxCollector.Text);
                txtBoxCollector.Text = "0";
                Operation = "*";
            }
            if (e.KeyCode == Keys.Enter)
            {
                btnEqual.PerformClick();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNo1_Click(object sender, EventArgs e)
        {
            if (txtBoxCollector.Text == "0" && txtBoxCollector.Text != null)
            {
                txtBoxCollector.Text = "1";
            }
            else
            {
                txtBoxCollector.Text = txtBoxCollector.Text + "1";
            }
        }

        private void btnNo0_Click(object sender, EventArgs e)
        {
            if (txtBoxCollector.Text == "0" && txtBoxCollector.Text != null)
            {
                txtBoxCollector.Text = "0";
            }
            else
            {
                txtBoxCollector.Text = txtBoxCollector.Text + "0";
            }
        }

        private void btnNo2_Click(object sender, EventArgs e)
        {
            if (txtBoxCollector.Text == "0" && txtBoxCollector.Text != null)
            {
                txtBoxCollector.Text = "2";
            }
            else
            {
                txtBoxCollector.Text = txtBoxCollector.Text + "2";
            }
        }

        private void btnNo3_Click(object sender, EventArgs e)
        {
            if (txtBoxCollector.Text == "0" && txtBoxCollector.Text != null)
            {
                txtBoxCollector.Text = "3";
            }
            else
            {
                txtBoxCollector.Text = txtBoxCollector.Text + "3";
            }
        }

        private void btnNo4_Click(object sender, EventArgs e)
        {
            if (txtBoxCollector.Text == "0" && txtBoxCollector.Text != null)
            {
                txtBoxCollector.Text = "4";
            }
            else
            {
                txtBoxCollector.Text = txtBoxCollector.Text + "4";
            }
        }

        private void btnNo5_Click(object sender, EventArgs e)
        {
            if (txtBoxCollector.Text == "0" && txtBoxCollector.Text != null)
            {
                txtBoxCollector.Text = "5";
            }
            else
            {
                txtBoxCollector.Text = txtBoxCollector.Text + "5";
            }
        }

        private void btnNo6_Click(object sender, EventArgs e)
        {
            if (txtBoxCollector.Text == "0" && txtBoxCollector.Text != null)
            {
                txtBoxCollector.Text = "6";
            }
            else
            {
                txtBoxCollector.Text = txtBoxCollector.Text + "6";
            }
        }

        private void btnNo7_Click(object sender, EventArgs e)
        {
            if (txtBoxCollector.Text == "0" && txtBoxCollector.Text != null)
            {
                txtBoxCollector.Text = "7";
            }
            else
            {
                txtBoxCollector.Text = txtBoxCollector.Text + "7";
            }
        }

        private void btnNo8_Click(object sender, EventArgs e)
        {
            if (txtBoxCollector.Text == "0" && txtBoxCollector.Text != null)
            {
                txtBoxCollector.Text = "8";
            }
            else
            {
                txtBoxCollector.Text = txtBoxCollector.Text + "8";
            }
        }

        private void btnNo9_Click(object sender, EventArgs e)
        {
            if (txtBoxCollector.Text == "0" && txtBoxCollector.Text != null)
            {
                txtBoxCollector.Text = "9";
            }
            else
            {
                txtBoxCollector.Text = txtBoxCollector.Text + "9";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtBoxCollector.Text);
            txtBoxCollector.Text = "0";
            Operation = "+";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtBoxCollector.Text);
            txtBoxCollector.Text = "0";
            Operation = "-";
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtBoxCollector.Text);
            txtBoxCollector.Text = "0";
            Operation = "*";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtBoxCollector.Text);
            txtBoxCollector.Text = "0";
            Operation = "/";
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            txtBoxCollector.Text = txtBoxCollector.Text + ".";
        }

        private void btnCLR_Click(object sender, EventArgs e)
        {
            txtBoxCollector.Text = "0";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            double Result;

            SecondNumber = Convert.ToDouble(txtBoxCollector.Text);

            if (Operation == "+")
            {
                Result = (FirstNumber + SecondNumber);
                txtBoxCollector.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }

            if (Operation == "-")
            {
                Result = (FirstNumber - SecondNumber);
                txtBoxCollector.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }

            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    txtBoxCollector.Text = "Cannot divide by zero.";
                }
                else
                {
                    Result = Math.Round((FirstNumber / SecondNumber),15);
                    txtBoxCollector.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }

            }

            if (Operation == "*")
            {
                Result = (FirstNumber * SecondNumber);
                txtBoxCollector.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
        }
    }
}
