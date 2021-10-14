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
        public Form1()
        {
            InitializeComponent();
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
    }
}
