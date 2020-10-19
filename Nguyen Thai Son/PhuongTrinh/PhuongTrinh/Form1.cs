using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PhuongTrinh
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
            txtA.Text = "";
            txtA.Focus();
            txtB.Text = "";
            txtB.Focus();
            txtC.Text = "";
            txtC.Focus();
            txtX1.Text = "";
            txtX1.Focus();
            txtX2.Text = "";
            txtX2.Focus();
            txtMessageErr.Text = "";
            txtMessageErr.Focus();
        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            try
            {
                Double a = Convert.ToDouble(txtA.Text);
                Double b = Convert.ToDouble(txtB.Text);
                Double c = Convert.ToDouble(txtC.Text);
                Double x1, x2;
                Double delta = (b * b - (4 * a * c));
                if (a == 0) 
                {
                    txtMessageErr.Text = "Phương trình có 1 nghiệm";
                    x1 = x2 = -c / b;
                    txtX1.Text = x1.ToString();
                    txtX2.Text = x2.ToString();
                }
                else if (delta < 0) {
                    txtMessageErr.Text = "Phương trình vô nghiệm";
                }
                else if (delta == 0)
                {
                    x1 = x2 = -b / a;
                    txtMessageErr.Text = "Phương trình có 1 nghiệm kép";
                    txtX1.Text = x1.ToString();
                    txtX2.Text = x2.ToString();
                }
                else
                {
                    x1 = -b + Math.Sqrt(delta) / 2 * a;
                    x2 = -b - Math.Sqrt(delta) / 2 * a;
                    txtMessageErr.Text = "Phương trình có 2 nghiệm phân biệt";
                    txtX1.Text = x1.ToString();
                    txtX2.Text = x2.ToString();
                }
                
            }
            catch (Exception) {
                MessageBox.Show("Hãy nhập đúng định dạng");
                txtA.Text = "";
                txtA.Focus();
                txtB.Text = "";
                txtB.Focus();
                txtC.Text = "";
                txtC.Focus();
                txtX1.Text = "";
                txtX1.Focus();
                txtX2.Text = "";
                txtX2.Focus();
                txtMessageErr.Text = "";
                txtMessageErr.Focus();
            }
            
        }
    }
}
