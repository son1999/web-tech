using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SoChinhPhuong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtReset_Click(object sender, EventArgs e)
        {
            txtSo.Text = "";
            txtKq.Text = "";
        }

        private void txtKiemTra_Click(object sender, EventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(txtSo.Text);
                int s = 0;
                for (int i = 1; i<=n; i++) {
                    for (int j = 1; j<=i; j++) {
                        if (j * j == i) {
                            s += i;
                        }
                    }
                }
                txtKq.Text = "Tổng các số chính phương là : " + s;
            }
            catch (Exception) {
                MessageBox.Show("Hãy nhập đúng định dạng");
                txtSo.Clear();
                txtKq.Clear();
            }
        }
    }
}
