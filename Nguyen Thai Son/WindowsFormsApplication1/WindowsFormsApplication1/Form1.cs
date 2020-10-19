using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSoA.Clear();
            txtSoB.Clear();
            txtUCLN.Clear();
            txtBCNN.Clear();
        }

        public double UCLN(double a, double b) 
        {
            return (b == 0) ? a : UCLN(b, a % b);
        }

        public double BCNN(double a, double b) 
        {
            return (a * b) / UCLN(a, b);
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            try
            {
                Double a = Convert.ToDouble(txtSoA.Text);
                Double b = Convert.ToDouble(txtSoB.Text);
                txtUCLN.Text = "UCLN của 2 số " + a + " và " + b + " là : " + UCLN(a,b);
                txtBCNN.Text = "BCNN của 2 số " + a + " và " + b + " là : " + BCNN(a, b);
            }
            catch (Exception)
            {
                MessageBox.Show("Hãy nhập đúng định dạng");
            }
        }

    }
}
